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
       call      qword ptr [7FFEBE1F54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFEBE76EF28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFEBE8D7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,2AFF25E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2AFF25E4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1FC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
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
       mov       rdx,7FFEBE8462E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFEBE85C500
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
       mov       rdx,7FFEBE846338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5E7AC8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFD72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE85C504
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
       mov       rdx,7FFEBE8463E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFEBE864480]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBE933C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE92D290]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE2054D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFEBE77EF28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFEBEAAC480]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFC4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,283EDFF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,283EDFF4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE20C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
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
       mov       rdx,7FFEBE856DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFEBDFCDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFEBE86C500
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
       mov       rdx,7FFEBE856E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5F7AC8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFE72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE86C504
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
       mov       rdx,7FFEBE856EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFEBE874558]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEB07F88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE204B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEAFF078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1D54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFEBE74F840]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFEBEA8D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF94780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,1D7AEB90008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1D7AEB94368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1DC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
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
       mov       rdx,7FFEBE827B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFEBE83D860
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
       mov       rdx,7FFEBE827B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5CC738]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFB72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE83D864
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
       mov       rdx,7FFEBE827C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFEBE844F90]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEADEFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1D4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEB74168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1F54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFEBE80DB90]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFEBEB4EB08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,2C776520008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2C776524368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1FC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
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
       mov       rdx,7FFEBE8CDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFEBE8EA248
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
       mov       rdx,7FFEBE8CDE38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5EC738]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFD72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE8EA24C
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
       mov       rdx,7FFEBE8CDEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFEBE8AF330]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEBA8930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBB5290]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1F54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFEBE80EFA0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFEBEBD51D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,29883B30008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,29883B34368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1FC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
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
       mov       rdx,7FFEBE9BD710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L01:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+18]
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       dword ptr [rbp-88],3E8
       jmp       near ptr M02_L05
M02_L02:
       mov       rcx,7FFEBE9E8B78
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
       mov       rdx,7FFEBE9BD760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L04:
       mov       rcx,[rbp-78]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5E7AC8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFD72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE9E8B7C
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
       mov       rdx,7FFEBE9BD810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L08:
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFEBE9C7CD8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEBBB838
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBD5D10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,187F4002D08
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
       mov       rcx,187F8001DF0
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
       mov       rdx,187F4002CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,187F4002D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,16417C04D00
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
       mov       rcx,16417C01DD8
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
       mov       rdx,16417C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16417C04D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0B4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0B4F30]
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
       call      qword ptr [7FFEBDEF41F8]
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
       mov       rcx,234C2004D00
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
       mov       rcx,234C2001DD8
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
       mov       rdx,234C2004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDED4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,234C2004D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE094F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE094F30]
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
       call      qword ptr [7FFEBDED41F8]
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
       mov       rcx,16703004D00
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
       mov       rcx,16703001DD8
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
       mov       rdx,16703004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16703004D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,1D609404D00
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
       mov       rcx,1D609401DD8
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
       mov       rdx,1D609404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D609404D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0B4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0B4F30]
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
       call      qword ptr [7FFEBDEF41F8]
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
       mov       rcx,26244402D08
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
       mov       rcx,26248401DD8
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
       mov       rdx,26244402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26244402D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,16753802D08
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
       mov       rcx,16757801DD8
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
       mov       rdx,16753802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16753802D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,2397A402D08
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
       mov       rcx,2397E401DD8
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
       mov       rdx,2397A402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF04210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2397A402D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0C4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0C4F30]
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
       call      qword ptr [7FFEBDF041F8]
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
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0CC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1DD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1DCF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18E56E74368
       mov       r8,r15
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDA0F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA0F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA0FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDF9E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4CDC70
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
       call      qword ptr [7FFEBE07ED48]
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
       mov       rdx,7FFEBE4CDC60
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
       call      qword ptr [7FFEBDE36E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDEE4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE5CFC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA66250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEEF708]
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
       call      qword ptr [7FFEBDF9DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0DC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5DE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5DE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5DE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDFA47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1ED0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1ECF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2ADE25A4368
       mov       r8,r15
       call      qword ptr [7FFEBDFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDB0F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDB0F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDB0FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4DD270
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
       call      qword ptr [7FFEBE08ED48]
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
       mov       rdx,7FFEBE4DD260
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
       call      qword ptr [7FFEBDE46E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDEF4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE6347C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA76280]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEFF708]
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
       call      qword ptr [7FFEBDFADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0EC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5EE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5EE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5EE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1FD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1FCF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,231DF124368
       mov       r8,r15
       call      qword ptr [7FFEBDFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDC0F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDC0F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDC0FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4ED6C0
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
       call      qword ptr [7FFEBE09ED48]
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
       mov       rdx,7FFEBE4ED6B0
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
       call      qword ptr [7FFEBDE56E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDF04390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE6347C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA86250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF0F708]
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
       call      qword ptr [7FFEBDFBDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0DC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5DD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5DD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5DD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDFA47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1ED0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1ECF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,28E0B714368
       mov       r8,r15
       call      qword ptr [7FFEBDFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDB0F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDB0F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDB0FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4DDD58
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
       call      qword ptr [7FFEBE08ED48]
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
       mov       rdx,7FFEBE4DDD48
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
       call      qword ptr [7FFEBDE46E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDEF4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE5DFC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA765B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEFF708]
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
       call      qword ptr [7FFEBDFADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0EC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5ED698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5ED698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5ED698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1FD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1FCF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2EF3D794368
       mov       r8,r15
       call      qword ptr [7FFEBDFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDC1240
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDC1248
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDC1250
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4ED3A0
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
       call      qword ptr [7FFEBE09ED48]
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
       mov       rdx,7FFEBE4ED390
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
       call      qword ptr [7FFEBDE56E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDF04390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE5EFC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA85740]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF0F708]
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
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFEBDFBDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0CC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1DD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1DCF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1F5A2854368
       mov       r8,r15
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDA1AC0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA1AC8
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA1AD0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDF9E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4CDC00
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
       call      qword ptr [7FFEBE07ED48]
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
       mov       rdx,7FFEBE4CDBF0
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
       call      qword ptr [7FFEBDE36E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDEE4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE5CFC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE91F078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEEF708]
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
       call      qword ptr [7FFEBDF9DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDFCDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0FC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5FE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5FE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5FE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDFC47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE20D0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE20CF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,25895864368
       mov       r8,r15
       call      qword ptr [7FFEBDFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDD1C78
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDD1C80
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDD1C88
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDFCE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE4FE390
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
       call      qword ptr [7FFEBE0AED48]
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
       mov       rdx,7FFEBE4FE380
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
       call      qword ptr [7FFEBDE66E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDF14390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE6447C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE9DDF50]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF1F708]
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
       call      qword ptr [7FFEBDFCDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFEBE0CC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFEBE5CD698]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1DD0F8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFEBE1DCF18]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,30A5FF04368
       mov       r8,r15
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFEBDDA1CE8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA1CF0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFEBDDA1CF8
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFEBDF9E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFEBE520068
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
       call      qword ptr [7FFEBE07ED48]
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
       mov       rdx,7FFEBE520058
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
       call      qword ptr [7FFEBDE36E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFEBDEE4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF44203670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M03_L02
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE5CFC60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEA463D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEEF708]
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
       call      qword ptr [7FFEBDF9DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       call      qword ptr [7FFEBE8B7AF8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1DCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23F58074368
       mov       r8,rbx
       call      qword ptr [7FFEBDF9D470]
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
       mov       rdx,1FEC6004D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE8B7AC8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDF9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFEBE1DCF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23F58074368
       mov       r8,rdi
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFEBE084C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFEBE9370F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBE8B7CF0]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFEBE5CFC60]
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
       call      qword ptr [7FFEBE8D7BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1FD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1FCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2668E624368
       mov       r8,rbx
       call      qword ptr [7FFEBDFBD470]
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
       mov       rdx,225FC802D90
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE8D7BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDFBDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1FD0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFEBE1FCF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2668E624368
       mov       r8,rdi
       call      qword ptr [7FFEBDFBD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFEBE0A4C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFEBE9570F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBE8D7DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFEBE6347C8]
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
       call      qword ptr [7FFEBE8D7E28]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1FCC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1FCA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EA84644368
       mov       r8,rbx
       call      qword ptr [7FFEBDFBD470]
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
       mov       rdx,1A9F2804D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE8D7DF8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDFBDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1FCC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFEBE1FCA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EA84644368
       mov       r8,rdi
       call      qword ptr [7FFEBDFBD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFEBE0A4C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFEBE9D70F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBE8DC1C8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFEBE6347C8]
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
       call      qword ptr [7FFEBE8C7AF8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDFA47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1ED0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1ECF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1BDBE274368
       mov       r8,rbx
       call      qword ptr [7FFEBDFAD470]
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
       mov       rdx,17D2C404D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBE8C7AC8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDFADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDFA47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1ED0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFEBE1ECF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1BDBE274368
       mov       r8,rdi
       call      qword ptr [7FFEBDFAD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFEBE094C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFEBE9C6B20]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBE8C7CF0]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFEBE5DFC60]
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
       call      qword ptr [7FFEBEA2D260]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1FD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1FCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,269F0064368
       mov       r8,rbx
       call      qword ptr [7FFEBDFBD470]
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
       mov       rdx,269F00675D8
       call      qword ptr [7FFEBE254C30]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       rdx,2295E004D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBEA2D230]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDFBDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDFB47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1FD0F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFEBE1FCF18]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,269F0064368
       mov       r8,rsi
       call      qword ptr [7FFEBDFBD470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBEA2D458]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFEBE5EFC60]
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
       call      qword ptr [7FFEBEA7CB10]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDF847B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1CD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1CCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,258FCD24368
       mov       r8,rbx
       call      qword ptr [7FFEBDF8D470]
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
       mov       rdx,258FCD275D8
       call      qword ptr [7FFEBE224C30]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       rdx,2186B004D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBEA7CAE0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDF8DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDF847B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1CD0F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFEBE1CCF18]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,258FCD24368
       mov       r8,rsi
       call      qword ptr [7FFEBDF8D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBEA7CD08]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFEBE5BFC60]
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
       call      qword ptr [7FFEBEB2EF28]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1DCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F0CC944368
       mov       r8,rbx
       call      qword ptr [7FFEBDF9D470]
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
       mov       rdx,2F0CC9475D8
       call      qword ptr [7FFEBE234C30]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       rdx,2B03A804D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBEB2EEF8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDF9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFEBE1DCF18]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2F0CC944368
       mov       r8,rsi
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBEB2F120]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFEBE5CFC60]
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
       call      qword ptr [7FFEBEBB5260]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEBE1DCF18]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28793D54368
       mov       r8,rbx
       call      qword ptr [7FFEBDF9D470]
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
       mov       rdx,24702004D88
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
       mov       rax,7FFF44203670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF1DDAA0DC],0
       je        short M01_L05
       call      qword ptr [7FFF1DD9A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFEBEBB5230]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFEBDF9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBDF947B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFEBE1DCF18]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28793D54368
       mov       r8,rdi
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFEBE084C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFEBE7AE6D0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEBEBB5458]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFEBE6147C8]
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
       call      qword ptr [7FFEBDFCDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,20A76002DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFEBE5F5FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFEBE6453B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFEBE1CE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,20A76002DB0
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
       call      qword ptr [7FFEBE645200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFEBE8E7B70]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBE8E7D08]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
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
       mov       rdx,24B0805F6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,24B08050008
       call      qword ptr [7FFEBE20E7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FFEBE8E7EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBDFC47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE20D0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFEBE20CF18]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,24B08054368
       mov       r8,rbx
       call      qword ptr [7FFEBDFCD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFEBE58F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFEBE58F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFEBE0AED00]
       int       3
M00_L17:
       call      qword ptr [7FFEBE20D110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,24B0805F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,24B0805021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,24B08050008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE20CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0D6670]
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
       mov       rdx,7FFEBE4FD588
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
       call      qword ptr [7FFEBE0AED48]
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
       mov       rdx,7FFEBE4FD578
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
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDD10D8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFEBDDD10D0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFEBDDD10C8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFEBDDD10B8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFEBDDD10C0
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
       mov       rdx,7FFEBE636AA8
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
       mov       rdx,7FFEBE636B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFEBE645488]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFEBE6454D0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFEBE20D110]
       mov       ecx,43
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1D6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE20CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0D6670]
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
       mov       rdx,7FFEBE949BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE94A110
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
       mov       rdx,7FFEBE949DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE94A0E0
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
       mov       rdx,7FFEBE94A0F8
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
       mov       rdx,7FFEBE949EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFEBDDD1038
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
       mov       rdx,7FFEBE94A008
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
       call      qword ptr [7FFEBE0D4F30]
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
       mov       r11,7FFEBDDD1040
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
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDD1088
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
       mov       rdx,7FFEBE634680
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
       mov       rdx,7FFEBE6346D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFEBE6453B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFEBE037900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBE20D110]
       mov       ecx,43
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1D6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE20CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFEBDDD1080
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDF14348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFEBDDD1078
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFEBDDD1068
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFEBDDD1070
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
       mov       rdx,7FFEBE1D56D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0D6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFEBE1D56D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0D6640]
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
       mov       rdx,7FFEBE8D7070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,24B08050008
       mov       r9,24B08067AF0
       call      qword ptr [7FFEBE8E7D80]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFEBE8D7120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFEBE8E7DC8]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFEBE8D7140
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
       call      qword ptr [7FFEBE20D110]
       mov       ecx,43
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1D6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5DEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE20CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0D6670]
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
       call      qword ptr [7FFEBE20D110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,24B08050210
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBDF16B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE20CF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE0D6670]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
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
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
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
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
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
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
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
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
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
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,1D070404DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFEBE5C5FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFEBE6153B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFEBE19E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,1D070404DA8
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
       call      qword ptr [7FFEBE615200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFEBE8B7B70]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBE8B7D08]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
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
       mov       rdx,2110213F6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21102130008
       call      qword ptr [7FFEBE1DE7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FFEBE8B7EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBDF947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFEBE1DCF18]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,21102134368
       mov       r8,rbx
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFEBE55F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFEBE55F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFEBE07ED00]
       int       3
M00_L17:
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,2110213F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,2110213021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,21102130008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       mov       rdx,7FFEBE4CDC18
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
       call      qword ptr [7FFEBE07ED48]
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
       mov       rdx,7FFEBE4CDC08
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
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDA10D8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFEBDDA10D0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFEBDDA10C8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFEBDDA10B0
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFEBDDA10B8
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
       mov       rdx,7FFEBE606AA8
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
       mov       rdx,7FFEBE606B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFEBE615488]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFEBE6154D0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       mov       rdx,7FFEBE919BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE91A110
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
       mov       rdx,7FFEBE919DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE91A0E0
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
       mov       rdx,7FFEBE91A0F8
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
       mov       rdx,7FFEBE919EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFEBDDA1030
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
       mov       rdx,7FFEBE91A008
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
       call      qword ptr [7FFEBE0A4F30]
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
       mov       r11,7FFEBDDA1038
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
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDA1080
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
       mov       rdx,7FFEBE604680
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
       mov       rdx,7FFEBE6046D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFEBE6153B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFEBE007900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFEBDDA1078
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFEBDDA1070
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFEBDDA1060
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFEBDDA1068
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
       mov       rdx,7FFEBE1A56D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFEBE1A56D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6640]
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
       mov       rdx,7FFEBE8A7090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,21102130008
       mov       r9,21102147AF0
       call      qword ptr [7FFEBE8B7D80]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFEBE8A7140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFEBE8B7DC8]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFEBE8A7160
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
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       call      qword ptr [7FFEBE1DD110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,21102130210
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6670]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
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
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
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
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
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
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
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
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
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
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,20F01C04DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFEBE5D54A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFEBE634858]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFEBE1A5D10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,20F01C04DA8
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
       call      qword ptr [7FFEBE6346A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFEBE8C7A98]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBE8C7C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
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
       mov       rdx,24F8FCAF6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,24F8FCA0008
       call      qword ptr [7FFEBE1EE310]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FFEBE8CE7D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBDFA47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFEBE1ECC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFEBE1ECA50]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,24F8FCA4368
       mov       r8,rbx
       call      qword ptr [7FFEBDFAD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFEBE56EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFEBE56EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFEBE08ED00]
       int       3
M00_L17:
       call      qword ptr [7FFEBE1ECC48]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,24F8FCAF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,24F8FCA021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,24F8FCA0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0B6670]
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
       mov       rdx,7FFEBE4DD720
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
       call      qword ptr [7FFEBE08ED48]
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
       mov       rdx,7FFEBE4DD710
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
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDB10F8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFEBDDB10F0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFEBDDB10E8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFEBDDB10D8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFEBDDB10E0
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
       mov       rdx,7FFEBE616AA8
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
       mov       rdx,7FFEBE616B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFEBE634930]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFEBE634978]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFEBE1ECC48]
       mov       ecx,43
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1B6458
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0B6670]
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
       mov       rdx,7FFEBE92A288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE92A7D0
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
       mov       rdx,7FFEBE92A478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE92A7A0
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
       mov       rdx,7FFEBE92A7B8
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
       mov       rdx,7FFEBE92A5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFEBDDB1058
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
       mov       rdx,7FFEBE92A6C8
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
       call      qword ptr [7FFEBE0B4F30]
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
       mov       r11,7FFEBDDB1060
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
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDB10A8
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
       mov       rdx,7FFEBE614680
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
       mov       rdx,7FFEBE6146D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFEBE634858]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFEBE017900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBE1ECC48]
       mov       ecx,43
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1B6458
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFEBDDB10A0
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFEBDDB1098
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFEBDDB1088
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFEBDDB1090
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
       mov       rdx,7FFEBE1B56E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0B6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFEBE1B56E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0B6640]
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
       mov       rdx,7FFEBE8B76C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,24F8FCA0008
       mov       r9,24F8FCB7AF0
       call      qword ptr [7FFEBE8C7CA8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFEBE8B7778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFEBE8C7CF0]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFEBE8B7798
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
       call      qword ptr [7FFEBE1ECC48]
       mov       ecx,43
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1B6458
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5BEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0B6670]
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
       call      qword ptr [7FFEBE1ECC48]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,24F8FCA0210
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBDEF6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE1ECA38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE0B6670]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
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
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
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
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
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
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
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
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
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
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,1F2A3804DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L09
       mov       rcx,r14
       call      qword ptr [7FFEBE5C54A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L15
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFEBE624858]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFEBE19E280]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,1F2A3804DA8
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
       call      qword ptr [7FFEBE6246A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFEBE8DE4C0]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBE8DE658]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
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
       mov       rdx,2333556F6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,23335560008
       call      qword ptr [7FFEBE1DE7D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FFEBE90D4D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,2333556F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,2333556021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,23335560008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       call      qword ptr [7FFEBDF947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFEBE1DD0F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFEBE1DCF18]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,23335564368
       mov       r8,rbx
       call      qword ptr [7FFEBDF9D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       call      qword ptr [7FFEBE55EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L15:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L16:
       call      qword ptr [7FFEBE55EDA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L17:
       mov       ecx,14
       call      qword ptr [7FFEBE07ED00]
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
       mov       rdx,7FFEBE4CD670
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
       call      qword ptr [7FFEBE07ED48]
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
       mov       rdx,7FFEBE4CD660
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
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDA1240
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFEBDDA1238
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFEBDDA1230
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFEBDDA1220
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFEBDDA1228
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
       mov       rdx,7FFEBE606AA8
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
       mov       rdx,7FFEBE606B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFEBE624930]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFEBE624978]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6468
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       mov       rdx,7FFEBE91A010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE91A558
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
       mov       rdx,7FFEBE91A200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEBE91A528
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
       mov       rdx,7FFEBE91A330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFEBDDA11B0
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
       mov       rdx,7FFEBE91A450
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
       call      qword ptr [7FFEBE0A4F30]
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
       mov       r11,7FFEBDDA11B8
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
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFEBDDA11F0
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
       mov       rdx,7FFEBE604680
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
       mov       rdx,7FFEBE6046D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFEBE624858]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFEBE007900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6468
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFEBDDA11E8
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFEBDEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFEBDDA11E0
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFEBDDA11D0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFEBDDA11D8
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
       mov       rdx,7FFEBE1A56F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFEBE1A56F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6640]
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
       mov       rdx,7FFEBE8CC1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,23335560008
       mov       r9,23335577AF0
       call      qword ptr [7FFEBE8DE6D0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFEBE8CC278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFEBE8DE718]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFEBE8CC298
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
       call      qword ptr [7FFEBE1DD110]
       mov       ecx,43
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFEBE1A6468
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBE5AF038
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE0A6670]
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
       call      qword ptr [7FFEBE1DD110]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,23335560210
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBDEE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBE1DCF00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE0A6670]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
       lea       rax,[7FFEE7363CC8]
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
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
       lea       rdx,[7FFEE71E4638]
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
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
       call      qword ptr [7FFEE7363C90]
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
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
       call      qword ptr [7FFEE7363C98]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
       call      qword ptr [7FFEE735B0E8]
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
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
       call      qword ptr [7FFEE7363C88]
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
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       call      qword ptr [7FFEE7346918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
       call      qword ptr [7FFEE73695D0]
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
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
       call      qword ptr [7FFEE7363CA0]
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
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
       call      qword ptr [7FFEE7363CB0]
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
       call      qword ptr [7FFEBE1F4F48]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5E7618]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBEA3DCF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,21FF0E30008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,21FF0E34368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1F7A08]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-68]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-80],3E8
       jmp       near ptr M02_L02
M02_L00:
       mov       rcx,1DF63004DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE57EE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE6446A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,1DF63004DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE57EE38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE6446A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFEBEA3DB90]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBEA3DD28]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFEBEA48A88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFEBEA48A8C
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
       mov       rcx,7FFEBEA48A90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBE864558]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEB02F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEAEF810]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1D4F48]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5CC288]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBEA8D368]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF94780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,2896A3D0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2896A3D4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1D7A08]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rcx,248D8404DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE55F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE615200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,248D8404DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE55F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE615200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFEBEA8D200]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBEA8D398]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFEBEA9CB50
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFEBEA9CB54
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
       mov       rcx,7FFEBEA9CB58
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBE844D50]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEB80CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEB74768]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1E54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5DC288]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBEB3FC00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,21A43470008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,21A43474368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1EC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rcx,1D9B5404DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE56F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE635200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,1D9B5404DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE56F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE635200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFEBEB3FA98]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBEB3FC30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFEBEB44190
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFEBEB44194
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
       mov       rcx,7FFEBEB44198
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBE89F0F0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEBB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1E4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEB96868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1F54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5EC288]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBEBD5368]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,208DC0D0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,208DC0D4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1FC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDFBDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rcx,1C84A404DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE57F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-88],rax
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE645200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,1C84A404DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE57F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFEBE645200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       r8,[rbp-98]
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFEBEBD5200]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-78]
       mov       [rbp-58],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-58]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFEBEBD5398]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rcx,7FFEBEBC7BB0
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-4C]
       sub       ecx,1
       jo        short M02_L04
       mov       [rbp-4C],ecx
M02_L01:
       mov       rcx,7FFEBEBC7BB4
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
       mov       rcx,7FFEBEBC7BB8
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFEBE994F60]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEBBF4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBD64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1D54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5C7648]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE90C7C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF94780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,31EE50B0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,31EE50B4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1DC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFEBE8A4DD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEBE5C7630]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFB72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE8A4DDC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE844480]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBE9C1070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1D4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE936358]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1C54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5B7648]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBEA6C7C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF84780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,14B02FC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,14B02FC4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1CC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDF8DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFEBE99FCA8
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEBE5B7630]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFA72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBE99FCAC
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE834558]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEACB0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1C4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEABF7E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1E54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5DC2B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBEA9D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1D38C280008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1D38C284368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1EC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFEBEA24060
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEBE5DC2A0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFC72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBEA24064
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE854F90]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEAEEB68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1E4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEB84168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1E54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5D7648]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBEB3EB08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1D7D2260008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1D7D2264368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1EC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDFADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFEBEA3CB18
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEBE5D7630]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFC72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBEA3CB1C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE89EAF0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEB98DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1E4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBA5290]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1D54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE5C7648]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBEBB51D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF94780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1EAABCD0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1EAABCD4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1DC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBDF9DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-68],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFEBEB32F70
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEBE5C7630]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBDFB72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,7FFEBEB32F74
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFEBE966DD8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBEB9BDF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1D4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBB5D10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1D54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE7942B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFEBEA1D8F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDF94780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,22EE4860008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,22EE4864368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1DC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBE74DE48]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFEBE8A4580
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5C7AF8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE76CA38]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
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
       mov       rcx,7FFEBE8A4584
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFEBE8966A0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
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
       mov       rdx,7FFEBEAE8420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1D4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEACF000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1E54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE7A42B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFEBEA9CA80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,288B3B10008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,288B3B14368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1EC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBE75DE48]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFEBEA215A0
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5D7AF8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE77CA38]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
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
       mov       rcx,7FFEBEA215A4
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFEBEA16910]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
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
       mov       rdx,7FFEBEAEEDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1E4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEADFBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1E54D0]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE7FFCF0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFEBEB3FA68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1DD8BDB0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1DD8BDB4368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1EC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBE7BEBB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFEBEA3C2B8
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5DC768]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7C3AD8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
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
       mov       rcx,7FFEBEA3C2BC
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFEBEA2DAA0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
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
       mov       rdx,7FFEBEB98950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1E4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBA6070]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFEBE1F4F48]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEBE8642B8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFEBEBD51D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFEBDFB4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,1C5B8840008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1C5B8844368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEBE1F7A08]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEBE80DE90]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       dword ptr [rbp-0B0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFEBEB522E8
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0A8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEBE5E7AF8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-100],rcx
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-0A8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-100]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE819148]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
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
       mov       rcx,7FFEBEB522EC
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFEBEB351A0]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
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
       mov       rdx,7FFEBEBBBE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEBE1F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEBD5CE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,18800C04CF8
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
       mov       rcx,18800C01DD8
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
       mov       rdx,18800C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDF04210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18800C04CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0C4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0C4F30]
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
       call      qword ptr [7FFEBDF041F8]
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
       mov       rcx,1B59A804CF8
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
       mov       rcx,1B59A801DD8
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
       mov       rdx,1B59A804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B59A804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0B4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0B4F30]
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
       call      qword ptr [7FFEBDEF41F8]
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
       mov       rcx,16E74002D00
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
       mov       rcx,16E78001DD8
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
       mov       rdx,16E74002CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDF04210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16E74002D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0C4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0C4F30]
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
       call      qword ptr [7FFEBDF041F8]
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
       mov       rcx,1D1CF402D00
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
       mov       rcx,1D1D3401DD8
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
       mov       rdx,1D1CF402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D1CF402D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,1C560004CF8
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
       mov       rcx,1C560001DD8
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
       mov       rdx,1C560004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C560004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,23429004CF8
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
       mov       rcx,23429001DD8
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
       mov       rdx,23429004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23429004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,29EFF804CF8
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
       mov       rcx,29EFF801DD8
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
       mov       rdx,29EFF804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29EFF804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,22EB6804CF8
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
       mov       rcx,22EB6801DD8
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
       mov       rdx,22EB6804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFEBDEE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22EB6804CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0A4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0A4F30]
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
       call      qword ptr [7FFEBDEE41F8]
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
       mov       rcx,19E99802D10
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
       mov       rcx,19E9D801DE0
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
       mov       rdx,19E99802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19E99802D10
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,2E358404D08
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
       mov       rcx,2E358401DD8
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
       mov       rdx,2E358404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2E358404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,1EF77002D10
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
       mov       rcx,1EF7B001DD8
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
       mov       rdx,1EF77002CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EF77002D10
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,1A830002D10
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
       mov       rcx,1A834001DD8
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
       mov       rdx,1A830002CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A830002D10
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0B4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0B4F30]
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
       call      qword ptr [7FFEBDEF41F8]
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
       mov       rcx,26241404D08
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
       mov       rcx,26241401DD8
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
       mov       rdx,26241404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26241404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,1D523804D08
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
       mov       rcx,1D523801DD8
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
       mov       rdx,1D523804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF14210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D523804D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0D4F30]
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
       call      qword ptr [7FFEBDF141F8]
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
       mov       rcx,2A7AB404D08
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
       mov       rcx,2A7AB401DD8
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
       mov       rdx,2A7AB404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A7AB404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0B4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0B4F30]
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
       call      qword ptr [7FFEBDEF41F8]
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
       mov       rcx,2C617004D08
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
       mov       rcx,2C617001DD8
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
       mov       rdx,2C617004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEBDF04210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C617004D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFEBE0C4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFEBE0C4F30]
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
       call      qword ptr [7FFEBDF041F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

