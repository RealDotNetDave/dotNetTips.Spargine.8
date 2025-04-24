## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A5578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFB9BB1F330]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFB9BCDD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B364780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,2095B3A0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2095B3A4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B5AC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBF6300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFB9BC0C530
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-78],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBF6350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B99C738]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3872C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-54]
       add       ecx,1
       jo        near ptr M02_L09
       mov       [rbp-54],ecx
M02_L05:
       mov       ecx,[rbp-88]
       dec       ecx
       mov       [rbp-88],ecx
       cmp       dword ptr [rbp-88],0
       jg        short M02_L06
       lea       rcx,[rbp-88]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L06:
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L02
       mov       rcx,7FFB9BC0C534
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-80],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBF6400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB9BC14D80]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0C0
       pop       rbp
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 547
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BD91938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A4BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BD06D90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B595578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFB9BB0F330]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFB9BDDE5C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B354780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,1DADA0F0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1DADA0F4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B59C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBE6DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFB9BC0C530
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-78],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBE6E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B98C738]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3772C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-54]
       add       ecx,1
       jo        near ptr M02_L09
       mov       [rbp-54],ecx
M02_L05:
       mov       ecx,[rbp-88]
       dec       ecx
       mov       [rbp-88],ecx
       cmp       dword ptr [rbp-88],0
       jg        short M02_L06
       lea       rcx,[rbp-88]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L06:
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L02
       mov       rcx,7FFB9BC0C534
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-80],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBE6EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB9BBF4E10]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0C0
       pop       rbp
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 547
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BEA7F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B594BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE7FC48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B565578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFB9BADEA18]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFB9BE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B324780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,23415D10008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,23415D14368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B56C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBB6DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFB9B32DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFB9BBCC530
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-78],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBB6E20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B957BA0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-54]
       add       ecx,1
       jo        near ptr M02_L09
       mov       [rbp-54],ecx
M02_L05:
       mov       ecx,[rbp-88]
       dec       ecx
       mov       [rbp-88],ecx
       cmp       dword ptr [rbp-88],0
       jg        short M02_L06
       lea       rcx,[rbp-88]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L06:
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L02
       mov       rcx,7FFB9BBCC534
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-80],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BBB6ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB9BBD44B0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0C0
       pop       rbp
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 547
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BE6F040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B564BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF04168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A5578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFB9BBBD5C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFB9BEFEB08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B364780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,2ED41760008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2ED41764368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B5AC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BC86DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFB9BC96440
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-78],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BC86DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B997BA0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3872C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-54]
       add       ecx,1
       jo        near ptr M02_L09
       mov       [rbp-54],ecx
M02_L05:
       mov       ecx,[rbp-88]
       dec       ecx
       mov       [rbp-88],ecx
       cmp       dword ptr [rbp-88],0
       jg        short M02_L06
       lea       rcx,[rbp-88]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L06:
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L02
       mov       rcx,7FFB9BC96444
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-80],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BC86EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB9BC5F120]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0C0
       pop       rbp
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 547
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF599B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A4BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF652A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B575578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFB9BB8F138]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFB9BF551D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,298827B0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,298827B4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B57C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BD32150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFB9BD41590
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-78],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BD321A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B96C738]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3572C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-54]
       add       ecx,1
       jo        near ptr M02_L09
       mov       [rbp-54],ecx
M02_L05:
       mov       ecx,[rbp-88]
       dec       ecx
       mov       [rbp-88],ecx
       cmp       dword ptr [rbp-88],0
       jg        short M02_L06
       lea       rcx,[rbp-88]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L06:
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L02
       mov       rcx,7FFB9BD41594
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-80],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB9BD32250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFB9BD07168]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0C0
       pop       rbp
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 547
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF3BD40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF55CE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,20A84004D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20A84001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20A84004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2B4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20A84004D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B474F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B474F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2B41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,1F230804D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F230801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F230804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2B4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F230804D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B474F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B474F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2B41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,20567804D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20567801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20567804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B294210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20567804D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B454F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B454F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,2D36B802D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2D36F801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2D36B802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2D36B802D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,257BC804D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,257BC801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,257BC804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,257BC804D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,2140F004D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2140F001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2140F004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2140F004D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,225F2802D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,225F6801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,225F2802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,225F2802D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,1E990404D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E990401DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E990404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B294210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E990404D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B454F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B454F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B46C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B57D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B57CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2413B804368
       mov       r8,r15
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B140F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B140F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B140FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B33E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B86D450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B41ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B86D440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1D6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B284390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B9B47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BE06250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B28F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M04_L01
M04_L00:
       mov       edx,4
M04_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B33DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B48C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3547B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B59D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B59CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2A115484368
       mov       r8,r15
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B160F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B160F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B160FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B35E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B88D498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B43ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B88D488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1F6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B2A4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B98FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BE265B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B35DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B34DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B47C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3447B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B58D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B58CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1EE512F4368
       mov       r8,r15
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B150F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B150F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B150FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B34E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B87D0E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B42ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B87D0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1E6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B294390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B9D47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BE16250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B29F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B34DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B48C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3547B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B59D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B59CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1DF4E564368
       mov       r8,r15
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B161168
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B161170
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B161178
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B35E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B88D720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B43ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B88D710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1F6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B2A4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B9D47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BE16C28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B35DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B49C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B99D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B99D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B99D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3647B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B5AD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B5ACF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,216FFCC4368
       mov       r8,r15
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B1713E8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B1713F0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B1713F8
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B36E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B89D3E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B44ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B89D3D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B206E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B2B4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B99FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BCEEE50]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2BF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B36DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B48C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B98D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3547B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B59D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B59CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,16163614368
       mov       r8,r15
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B161AC8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B161AD0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B161AD8
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B35E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B88D3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B43ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B88D390
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1F6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B2A4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B98FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BD5E2B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B35DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B46C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B96D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B57D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B57CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2A5A2324368
       mov       r8,r15
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B141C80
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B141C88
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B141C90
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B33E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B86CF68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B41ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B86CF58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1D6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B284390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B96FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BD4DBC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B28F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B33DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B34DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFB9B47C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFB9B97D698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3447B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B58D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFB9B58CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1F7FA524368
       mov       r8,r15
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFB9B151CE8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B151CF0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFB9B151CF8
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFB9B34E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B87D348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B42ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B87D338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFB9B1E6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFB9B294390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M03_L02
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFB9B97FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9BDF6520]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B29F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFB9B34DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BC87BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3647B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B5ACC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B5ACA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CA85754368
       mov       r8,rbx
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,289F3804D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BC87BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B36DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3647B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B5ACC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B5ACA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CA85754368
       mov       r8,rdi
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B454C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BD070F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BC87DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B9E47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BC57BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3347B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B57CC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B57CA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2097AF24368
       mov       r8,rbx
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,1C8E9004D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BC57BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B33DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B57CC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B57CA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2097AF24368
       mov       r8,rdi
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B424C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BCD70F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BC57DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B9C47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BC7C060]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3547B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B59CC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B59CA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24994544368
       mov       r8,rbx
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,2090E802D90
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BC7C030]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B35DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3547B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B59CC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B59CA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24994544368
       mov       r8,rdi
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B444C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BD775E8]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BC7C258]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B9D47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BC8E070]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3447B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B58D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B58CF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CE32D04368
       mov       r8,rbx
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,28DA1004D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BC8E040]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B34DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B58D0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B58CF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CE32D04368
       mov       r8,rdi
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B434C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BD66B20]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BC8E268]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B97FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BDCDE90]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3447B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B58D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B58CF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2DADD574368
       mov       r8,rbx
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,ebx
       mov       rdx,2DADD5775D8
       call      qword ptr [7FFB9B5E4C30]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,29A4F404D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L16
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BDCDE60]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L14
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B34DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B58D0F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFB9B58CF18]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2DADD574368
       mov       r8,rsi
       call      qword ptr [7FFB9B34D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BDCE088]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFB9B97FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 709
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BE4C270]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3447B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B58D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B58CF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26DEA234368
       mov       r8,rbx
       call      qword ptr [7FFB9B34D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,ebx
       mov       rdx,26DEA2375D8
       call      qword ptr [7FFB9B5E4C30]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,22D5C404D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L16
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BE4C240]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L14
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B34DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B58D0F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFB9B58CF18]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,26DEA234368
       mov       r8,rsi
       call      qword ptr [7FFB9B34D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BE4C468]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFB9B97FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 709
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BECF510]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3347B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B57D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B57CF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2504F7B4368
       mov       r8,rbx
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,20FBD804D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BECF4E0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B33DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B57D0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B57CF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2504F7B4368
       mov       r8,rdi
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B424C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BB4E130]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BECF708]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B96FC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFB9BF75260]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB9B3647B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFB9B5AD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFB9B5ACF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22019984368
       mov       r8,rbx
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,1DF87C04D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFC59E83670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFBFB14A0DC],0
       je        short M01_L05
       call      qword ptr [7FFBFB13A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFB9BF75230]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB9B36DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB9B3647B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFB9B5AD0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFB9B5ACF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22019984368
       mov       r8,rdi
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFB9B454C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB9BB7E580]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFB9BF75458]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFB9B9E47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,22FA5004DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFB9B9954A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFB9B9F4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFB9B50C6C0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,22FA5004DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9F46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFB9BC87810]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BC879A8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L06:
       add       ebp,1
       jo        near ptr M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2703702F6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,27037020008
       call      qword ptr [7FFB9B5AE310]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L16
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BC87B40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFB9B3647B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B5ACC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFB9B5ACA50]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,27037024368
       mov       r8,rbx
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFB9B92EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFB9B92EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFB9B44ED00]
       int       3
M00_L17:
       call      qword ptr [7FFB9B5ACC48]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,2703702F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,2703702021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,27037020008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B89D720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B44ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B89D710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFB9B1710D8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFB9B1710D0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFB9B1710C8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFB9B1710B8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFB9B1710C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9B9D6AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9B9D6B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB9B9F4960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFB9B9F49A8]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFB9B5ACC48]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576600
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9D40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA068
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B171038
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFB9B474F30]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B171040
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFB9B171088
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFB9B9D4680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFB9B9D46D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFB9B9F4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9B3D7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFB9B5ACC48]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576600
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFB9B171080
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFB9B171078
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFB9B171068
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFB9B171070
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFB9B575858
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B476640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFB9B575858
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B476640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,27037020008
       mov       r9,27037037B60
       call      qword ptr [7FFB9BC87A20]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFB9BC87A68]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFB9B5ACC48]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576600
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFB9B5ACC48]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,27037020210
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9B5ACA38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB9B476670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,1D868404DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFB9B995FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFB9B9E53E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFB9B56E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,1D868404DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9E5230]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFB9BC87B70]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BC87D08]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L06:
       add       ebp,1
       jo        near ptr M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,218FA2DF6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,218FA2D0008
       call      qword ptr [7FFB9B5AE7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L16
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BC87EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFB9B3647B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B5AD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFB9B5ACF18]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,218FA2D4368
       mov       r8,rbx
       call      qword ptr [7FFB9B36D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFB9B92F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFB9B92F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFB9B44ED00]
       int       3
M00_L17:
       call      qword ptr [7FFB9B5AD110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,218FA2DF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,218FA2D021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,218FA2D0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B89D5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B44ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B89D5C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFB9B1710D8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFB9B1710D0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFB9B1710C8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFB9B1710B8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFB9B1710C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9B9D6AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9B9D6B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB9B9E54B8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFB9B9E5500]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFB9B5AD110]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA0E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA0F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFB9BCE9EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B171038
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFB9BCEA008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFB9B474F30]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B171040
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFB9B171088
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFB9B9D4680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFB9B9D46D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFB9B9E53E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9B3D7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFB9B5AD110]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFB9B171080
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFB9B171078
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFB9B171068
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFB9B171070
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFB9B5756D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B476640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFB9B5756D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B476640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,218FA2D0008
       mov       r9,218FA2E7B60
       call      qword ptr [7FFB9BC87D80]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFB9BC87DC8]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFB9BC77160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFB9B5AD110]
       mov       ecx,43
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B576480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B97EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B5ACF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFB9B5AD110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,218FA2D0210
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB9B2B6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9B5ACF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB9B476670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,25AC9004DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFB9B9654A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFB9B9C4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFB9B53E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,25AC9004DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9C46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFB9BC57A98]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BC57C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L06:
       add       ebp,1
       jo        near ptr M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,29B5AEBF6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,29B5AEB0008
       call      qword ptr [7FFB9B57E7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L16
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BC5E988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFB9B3347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFB9B57D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFB9B57CF18]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,29B5AEB4368
       mov       r8,rbx
       call      qword ptr [7FFB9B33D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFB9B8FEDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFB9B8FEDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFB9B41ED00]
       int       3
M00_L17:
       call      qword ptr [7FFB9B57D110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,29B5AEBF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,29B5AEB021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,29B5AEB0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B57CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B446670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B86E068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B41ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B86E058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFB9B1410F8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFB9B1410F0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFB9B1410E8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFB9B1410D8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFB9B1410E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9B9A6AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9B9A6B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB9B9C4960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFB9B9C49A8]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFB9B57D110]
       mov       ecx,43
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B546480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B57CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B446670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA7A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA448
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B141058
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFB9BCBA698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B141060
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFB9B1410A8
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFB9B9A4680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFB9B9A46D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFB9B9C4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9B3A7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFB9B57D110]
       mov       ecx,43
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B546480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B57CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B446670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFB9B1410A0
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFB9B141098
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFB9B141088
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFB9B141090
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFB9B5456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B446640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFB9B5456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B446640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BC476C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,29B5AEB0008
       mov       r9,29B5AEC7B60
       call      qword ptr [7FFB9BC57CA8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BC47778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFB9BC57CF0]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFB9BC47798
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFB9B57D110]
       mov       ecx,43
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B546480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B94EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B57CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B446670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFB9B57D110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,29B5AEB0210
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB9B286B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9B57CF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB9B446670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L11
M00_L00:
       test      eax,eax
       je        near ptr M00_L12
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,212D2002DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L09
       mov       rcx,r14
       call      qword ptr [7FFB9B9854A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L15
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFB9B9E4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFB9B55E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,212D2002DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L16
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9E46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFB9BC9E4C0]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BC9E658]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L08
M00_L06:
       add       ebp,1
       jo        near ptr M00_L10
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25363D3F6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,25363D30008
       call      qword ptr [7FFB9B59E7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L17
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BCCD4D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       sub       ebp,1
       jo        near ptr M00_L10
       jmp       near ptr M00_L06
M00_L09:
       call      qword ptr [7FFB9B59D110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,25363D3F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,25363D3021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,25363D30008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B59CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B466670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      CORINFO_HELP_OVERFLOW
M00_L11:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFB9B3547B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFB9B59D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFB9B59CF18]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,25363D34368
       mov       r8,rbx
       call      qword ptr [7FFB9B35D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       call      qword ptr [7FFB9B91EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L15:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L16:
       call      qword ptr [7FFB9B91EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L17:
       mov       ecx,14
       call      qword ptr [7FFB9B43ED00]
       int       3
; Total bytes of code 815
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB9B88D2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB9B43ED48]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB9B88D2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFB9B161240
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFB9B161238
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFB9B161230
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFB9B161220
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFB9B161228
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9B9C6AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9B9C6B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB9B9E4960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFB9B9E49A8]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFB9B59D110]
       mov       ecx,43
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B566480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B59CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B466670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BCD9F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BCDA4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFB9BCDA170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFB9BCDA498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,offset System.Text.Encodings.Web.OptimizedInboxTextEncoder.GetIndexOfFirstByteToEncode(System.ReadOnlySpan`1<Byte>)
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFB9BCDA2A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B1611B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFB9BCDA3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFB9B1611B8
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFB9B1611F0
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFB9B9C4680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFB9B9C46D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFB9B9E4888]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9B3C7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFB9B59D110]
       mov       ecx,43
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B566480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B59CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B466670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFB9B1611E8
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFB9B2A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFB9B1611E0
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFB9B1611D0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFB9B1611D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFB9B5656D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B466640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFB9B5656D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B466640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFB9BC8BE58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,25363D30008
       mov       r9,25363D47B60
       call      qword ptr [7FFB9BC9E6D0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFB9BC8BF08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFB9BC9E718]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFB9BC8BF28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFB9B59D110]
       mov       ecx,43
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFB9B566480
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB9B96F038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB9B59CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB9B466670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFB9B59D110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,25363D30210
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB9B2A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB9B59CF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB9B466670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       lea       rax,[7FFBFAC53CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       lea       rdx,[7FFBFAAD4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       call      qword ptr [7FFBFAC53C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       call      qword ptr [7FFBFAC53C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       call      qword ptr [7FFBFAC4B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       call      qword ptr [7FFBFAC53C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       call      qword ptr [7FFBFAC36918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       call      qword ptr [7FFBFAC595D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       call      qword ptr [7FFBFAC53CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       call      qword ptr [7FFBFAC53CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574FA8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B96C288]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BE1C960]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				nameIndex--;
; 				^^^^^^^^^^^^
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,19CC6D40008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,19CC6D44368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B577A68]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-80],3E8
       jmp       near ptr M02_L02
M02_L00:
       mov       rcx,15C35002DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9B5230]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,15C35002DB0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9B5230]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFB9BE1C7F8]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BE1C990]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFB9BE284E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFB9BE284EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-80]
       dec       ecx
       mov       [rbp-80],ecx
       cmp       dword ptr [rbp-80],0
       jg        short M02_L03
       lea       rcx,[rbp-80]
       mov       edx,62
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L00
       mov       rcx,7FFB9BE284F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BBD4E10]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 539
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BE7CF20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574600]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE94180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B585578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B9776F0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BE4C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B344780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,161FC580008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,161FC584368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B58C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B34DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-40],rcx
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-80],3E8
       jmp       near ptr M02_L02
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,1216A404DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B90EE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9D46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,1216A404DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B90EE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9D46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFB9BE4C030]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BE4C1C8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFB9BE3C388
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFB9BE3C38C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-80]
       dec       ecx
       mov       [rbp-80],ecx
       cmp       dword ptr [rbp-80],0
       jg        short M02_L03
       lea       rcx,[rbp-80]
       mov       edx,62
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L00
       mov       rcx,7FFB9BE3C390
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BBF44B0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 539
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF20A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B584BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE7F5D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574FA8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B9676F0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BECF618]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				nameIndex--;
; 				^^^^^^^^^^^^
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,2B23CDA0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2B23CDA4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B577A68]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-80],3E8
       jmp       near ptr M02_L02
M02_L00:
       mov       rcx,271AB004DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FEE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9C46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,271AB004DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FEE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9C46D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFB9BECF4B0]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BECF648]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFB9BED4900
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFB9BED4904
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-80]
       dec       ecx
       mov       [rbp-80],ecx
       cmp       dword ptr [rbp-80],0
       jg        short M02_L03
       lea       rcx,[rbp-80]
       mov       edx,62
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L00
       mov       rcx,7FFB9BED4908
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BC2F120]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 539
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF42C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574600]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF264C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B575578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B96C288]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BF55368]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,20445E30008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,20445E34368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B57C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-40],rcx
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-80],3E8
       jmp       near ptr M02_L02
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,1C3B4004DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9C5230]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,1C3B4004DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B8FF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFB9B9C5230]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFB9BF55200]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFB9BF55398]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFB9BF48110
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFB9BF48114
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-80]
       dec       ecx
       mov       [rbp-80],ecx
       cmp       dword ptr [rbp-80],0
       jg        short M02_L03
       lea       rcx,[rbp-80]
       mov       edx,62
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L00
       mov       rcx,7FFB9BF48118
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFB9BD47E88]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 539
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF3DB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF564A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A5578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B997720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BDAD8F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B364780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,18DA5F20008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,18DA5F24368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B5AC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B36DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFB9BC79B68
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFB9B997708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3872C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-4C],ecx
M02_L01:
       mov       ecx,[rbp-68]
       dec       ecx
       mov       [rbp-68],ecx
       cmp       dword ptr [rbp-68],0
       jg        short M02_L02
       lea       rcx,[rbp-68]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFB9BC79B6C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BC14588]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 339
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BEB73B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B5A4BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE9EE08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B575578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B967720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BE2D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,237FCEA0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,237FCEA4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B57C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B33DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFB9BDB4470
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFB9B967708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3572C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-4C],ecx
M02_L01:
       mov       ecx,[rbp-68]
       dec       ecx
       mov       [rbp-68],ecx
       cmp       dword ptr [rbp-68],0
       jg        short M02_L02
       lea       rcx,[rbp-68]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFB9BDB4474
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BBE44B0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 339
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BE7F0C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF14168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B595578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B98C2B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BEEFA68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B354780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1EC74F90008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1EC74F94368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B59C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFB9BDECC28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFB9B98C2A0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3772C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-4C],ecx
M02_L01:
       mov       ecx,[rbp-68]
       dec       ecx
       mov       [rbp-68],ecx
       cmp       dword ptr [rbp-68],0
       jg        short M02_L02
       lea       rcx,[rbp-68]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFB9BDECC2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BC4F120]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 339
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF49970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B594BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF56088]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B595578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9B98C2B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BF751D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B354780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,24785F20008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,24785F24368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B59C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9B35DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFB9BEE2E20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFB9B98C2A0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9B3772C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-4C],ecx
M02_L01:
       mov       ecx,[rbp-68]
       dec       ecx
       mov       [rbp-68],ecx
       cmp       dword ptr [rbp-68],0
       jg        short M02_L02
       lea       rcx,[rbp-68]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFB9BEE2E24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFB9BD364A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 339
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF5D638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B594BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF75D10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B595578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9BB64DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFB9BCCEB98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,120
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B354780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,2DA69950008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2DA69954368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B59C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9BB0E250]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFB9BBFE478
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B98C768]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BB2AC90]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-0B0]
       dec       ecx
       mov       [rbp-0B0],ecx
       cmp       dword ptr [rbp-0B0],0
       jg        short M02_L03
       lea       rcx,[rbp-0B0]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFB9BBFE47C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFB9BC05B60]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,120
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 412
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BDCFDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B594BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BDDE670]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B565578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9BB342B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFB9BE0C7C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,120
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B324780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,23E2B9A0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,23E2B9A4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B56C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9BADD938]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFB9BC35120
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B957BD0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BAFAC90]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-0B0]
       dec       ecx
       mov       [rbp-0B0],ecx
       cmp       dword ptr [rbp-0B0],0
       jg        short M02_L03
       lea       rcx,[rbp-0B0]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFB9BC35124
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFB9BC26970]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,120
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 412
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BE6E350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B564BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE5FC78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B575578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9BB44DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFB9BE2CA80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,120
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B334780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,273EC060008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,273EC064368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B57C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9BAEE250]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFB9BD7DD80
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B96C768]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BB0AC90]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-0B0]
       dec       ecx
       mov       [rbp-0B0],ecx
       cmp       dword ptr [rbp-0B0],0
       jg        short M02_L03
       lea       rcx,[rbp-0B0]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFB9BD7DD84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFB9BDA5C50]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,120
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 412
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BE7F1B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B574BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BE6FBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B585578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9BB9F870]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFB9BEDF7B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,120
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B344780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,2506BD70008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2506BD74368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B58C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9BB5E310]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFB9BDDC318
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B977BD0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BB719B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-0B0]
       dec       ecx
       mov       [rbp-0B0],ecx
       cmp       dword ptr [rbp-0B0],0
       jg        short M02_L03
       lea       rcx,[rbp-0B0]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFB9BDDC31C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFB9BDCD338]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,120
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 412
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF39930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B584BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF46088]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B585578]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFB9BBF4588]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFB9BF65500]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+278]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,120
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFB9B344780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,21152FA0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,21152FA4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFB9B58C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFB9BB9DA40]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFB9BEE2750
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFB9B977BD0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BBB6F40]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L02:
       mov       ecx,[rbp-0B0]
       dec       ecx
       mov       [rbp-0B0],ecx
       cmp       dword ptr [rbp-0B0],0
       jg        short M02_L03
       lea       rcx,[rbp-0B0]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-4C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFB9BEE2754
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFB9BEC5200]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,120
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 412
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L00
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-10],rcx
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFB9BF4C0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB9B584BD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB9BF66040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,2286A804CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2286A801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2286A804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B294210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2286A804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B454F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B454F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,22F2E004CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22F2E001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22F2E004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22F2E004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,261BBC02D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,261BFC01DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,261BBC02CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,261BBC02D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,1D0A6004CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D0A6001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0A6004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D0A6004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,20CC3404CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20CC3401DE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20CC3404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20CC3404CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,27B9DC04CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27B9DC01DE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27B9DC04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27B9DC04CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,1A666804CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A666801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A666804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B294210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A666804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B454F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B454F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,22CCE804CF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22CCE801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22CCE804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFB9B274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22CCE804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B434F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B434F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2741F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,2A3A3004D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2A3A3001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2A3A3004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2B4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A3A3004D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B474F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B474F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2B41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,1A3C5C04D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A3C5C01DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A3C5C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A3C5C04D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,22351C04D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22351C01DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22351C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22351C04D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,18663C04D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18663C01DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18663C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B294210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18663C04D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B454F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B454F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,224EC404D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,224EC401DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,224EC404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,224EC404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,2072E804D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2072E801DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2072E804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2072E804D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,201DD004D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,201DD001DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,201DD004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,201DD004D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B444F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B444F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,15B38404D08
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,15B38401DD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,15B38404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFB9B2A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15B38404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFB9B464F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFB9B464F30]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFB9B2A41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

