## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E244F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFF2E647D98]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF2E98D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       dword ptr [rbp-50],1
       mov       dword ptr [rbp-58],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E004780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-60],r9
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       mov       r9,1F6BF4F0008
       mov       [rsp+28],r9
       lea       r9,[rbp-58]
       lea       rdx,[rbp-50]
       mov       ecx,[rbp+18]
       mov       r8,1F6BF4F4368
       call      qword ptr [7FFF2E2479F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E8E4FE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L02:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+18]
       call      qword ptr [7FFF2E00DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       dword ptr [rbp-98],3E8
       jmp       near ptr M02_L06
M02_L03:
       mov       rcx,7FFF2E8FD9A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E8E5038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L05:
       mov       rcx,[rbp-88]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E64CBB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0272C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-64]
       add       ecx,1
       jo        near ptr M02_L10
       mov       [rbp-64],ecx
M02_L06:
       mov       ecx,[rbp-98]
       dec       ecx
       mov       [rbp-98],ecx
       cmp       dword ptr [rbp-98],0
       jg        short M02_L07
       lea       rcx,[rbp-98]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       ecx,[rbp-64]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L03
       mov       rcx,7FFF2E8FD9AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-90],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E8E5088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M02_L09:
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFF2E7567A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 582
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
       mov       rdx,7FFF2EA80000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2445A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EA74C48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2654B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFF2E667D98]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF2EA7EAC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rbp-50],1
       mov       dword ptr [rbp-58],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-60],r9
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       mov       r9,1C6534F0008
       mov       [rsp+28],r9
       lea       r9,[rbp-58]
       lea       rdx,[rbp-50]
       mov       ecx,[rbp+18]
       mov       r8,1C6534F4368
       call      qword ptr [7FFF2E26C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E973BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L02:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+18]
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       dword ptr [rbp-98],3E8
       jmp       near ptr M02_L06
M02_L03:
       mov       rcx,7FFF2E96C478
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E973C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L05:
       mov       rcx,[rbp-88]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E66CBB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-64]
       add       ecx,1
       jo        near ptr M02_L10
       mov       [rbp-64],ecx
M02_L06:
       mov       ecx,[rbp-98]
       dec       ecx
       mov       [rbp-98],ecx
       cmp       dword ptr [rbp-98],0
       jg        short M02_L07
       lea       rcx,[rbp-98]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       ecx,[rbp-64]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L03
       mov       rcx,7FFF2E96C47C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-90],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E973C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M02_L09:
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFF2E7767A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 582
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
       mov       rdx,7FFF2EB17558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EAFCE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2754B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFF2E677D98]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF2EB3D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rbp-50],1
       mov       dword ptr [rbp-58],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E034780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-60],r9
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       mov       r9,2FF9EE30008
       mov       [rsp+28],r9
       lea       r9,[rbp-58]
       lea       rdx,[rbp-50]
       mov       ecx,[rbp+18]
       mov       r8,2FF9EE34368
       call      qword ptr [7FFF2E27C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E9F6950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L02:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+18]
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       dword ptr [rbp-98],3E8
       jmp       near ptr M02_L06
M02_L03:
       mov       rcx,7FFF2EA10730
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E9F69A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L05:
       mov       rcx,[rbp-88]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E67CBB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0572C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-64]
       add       ecx,1
       jo        near ptr M02_L10
       mov       [rbp-64],ecx
M02_L06:
       mov       ecx,[rbp-98]
       dec       ecx
       mov       [rbp-98],ecx
       cmp       dword ptr [rbp-98],0
       jg        short M02_L07
       lea       rcx,[rbp-98]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       ecx,[rbp-64]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L03
       mov       rcx,7FFF2EA10734
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-90],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2E9F69F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M02_L09:
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFF2E7867A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 582
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
       mov       rdx,7FFF2EC22988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E274B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC345A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E284F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFF2E687D98]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF2EBDEE98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rbp-50],1
       mov       dword ptr [rbp-58],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E044780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-60],r9
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       mov       r9,1F7716E0008
       mov       [rsp+28],r9
       lea       r9,[rbp-58]
       lea       rdx,[rbp-50]
       mov       ecx,[rbp+18]
       mov       r8,1F7716E4368
       call      qword ptr [7FFF2E2879F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
; 		var people = new List<Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EA35CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L02:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+18]
       call      qword ptr [7FFF2E04DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-48],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       dword ptr [rbp-98],3E8
       jmp       near ptr M02_L06
M02_L03:
       mov       rcx,7FFF2EA496C0
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonRef<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EA35D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L05:
       mov       rcx,[rbp-88]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E68CBB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0672C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-64]
       add       ecx,1
       jo        near ptr M02_L10
       mov       [rbp-64],ecx
M02_L06:
       mov       ecx,[rbp-98]
       dec       ecx
       mov       [rbp-98],ecx
       cmp       dword ptr [rbp-98],0
       jg        short M02_L07
       lea       rcx,[rbp-98]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       ecx,[rbp-64]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L03
       mov       rcx,7FFF2EA496C4
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-90],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EA35D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M02_L09:
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFF2E7967A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 582
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
       mov       rdx,7FFF2EC486C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2845A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC55AD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2654B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FFF2E667D98]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF2EC451D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       dword ptr [rbp-50],1
       mov       dword ptr [rbp-58],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-60],r9
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       mov       r9,24C7B5C0008
       mov       [rsp+28],r9
       lea       r9,[rbp-58]
       lea       rdx,[rbp-50]
       mov       ecx,[rbp+18]
       mov       r8,24C7B5C4368
       call      qword ptr [7FFF2E26C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+18],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EAA8260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M02_L02:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+18]
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       dword ptr [rbp-98],3E8
       jmp       near ptr M02_L06
M02_L03:
       mov       rcx,7FFF2EABD410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EAA82B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L05:
       mov       rcx,[rbp-88]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E66CBB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-64]
       add       ecx,1
       jo        near ptr M02_L10
       mov       [rbp-64],ecx
M02_L06:
       mov       ecx,[rbp-98]
       dec       ecx
       mov       [rbp-98],ecx
       cmp       dword ptr [rbp-98],0
       jg        short M02_L07
       lea       rcx,[rbp-98]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       ecx,[rbp-64]
       cmp       ecx,[rbp+18]
       jl        near ptr M02_L03
       mov       rcx,7FFF2EABD414
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-90],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFF2EAA8300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M02_L09:
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFF2E7767A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 582
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
       mov       rdx,7FFF2EC3B550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC462B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,26A23004D00
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
       mov       rcx,26A23001DD8
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
       mov       rdx,26A23004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26A23004D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E154F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E154F30]
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
       call      qword ptr [7FFF2DF941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,21A1F802D08
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
       mov       rcx,21A27801DD8
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
       mov       rdx,21A1F802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21A1F802D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E134F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       call      qword ptr [7FFF2DF741F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,24EBEC02D08
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
       mov       rcx,24EC2C01DD8
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
       mov       rdx,24EBEC02CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24EBEC02D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,24D31404D00
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
       mov       rcx,24D31401DD8
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
       mov       rdx,24D31404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24D31404D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E134F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       call      qword ptr [7FFF2DF741F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,27CC7402D08
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
       mov       rcx,27CCB401DD8
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
       mov       rdx,27CC7402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27CC7402D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E114F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E114F30]
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
       call      qword ptr [7FFF2DF541F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,27208002D08
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
       mov       rcx,2720C001DD8
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
       mov       rdx,27208002CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27208002D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,19240804D00
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
       mov       rcx,19240801DE0
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
       mov       rdx,19240804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19240804D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,26CE5804D00
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
       mov       rcx,26CE5801DE0
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
       mov       rdx,26CE5804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26CE5804D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E134F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       call      qword ptr [7FFF2DF741F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E16C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E27CE70]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E27CC90]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,2F039304368
       mov       r8,r15
       call      qword ptr [7FFF2E03D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE40F50
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE40F58
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE40F60
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E03E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E5A2FA0
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
       call      qword ptr [7FFF2E11ED48]
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
       mov       rdx,7FFF2E5A2F90
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
       call      qword ptr [7FFF2DED6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF84390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2EAE5980]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF8F708]
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
       call      qword ptr [7FFF2E03DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E15C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E26CE70]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E26CC90]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,265D8014368
       mov       r8,r15
       call      qword ptr [7FFF2E02D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE30F50
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE30F58
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE30F60
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E02E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E593228
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E593218
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
       call      qword ptr [7FFF2DEC6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF74390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2EAD5980]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       call      qword ptr [7FFF2E02DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E01DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E14C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0147B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E25C9A8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E25C7C8]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,2060F454368
       mov       r8,r15
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE210F8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE21100
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE21108
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E01E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E583378
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
       call      qword ptr [7FFF2E0FED48]
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
       mov       rdx,7FFF2E583368
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
       call      qword ptr [7FFF2DEB6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF64390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6A4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E9CC228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F708]
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
       call      qword ptr [7FFF2E01DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E16C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E67E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E27C9A8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E27C7C8]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,28C8B1F4368
       mov       r8,r15
       call      qword ptr [7FFF2E03D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE411D0
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE411D8
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE411E0
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E03E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E5A39D8
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
       call      qword ptr [7FFF2E11ED48]
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
       mov       rdx,7FFF2E5A39C8
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
       call      qword ptr [7FFF2DED6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF84390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E9EC228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF8F708]
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
       call      qword ptr [7FFF2E03DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E15C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E26CE70]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E26CC90]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,254C0064368
       mov       r8,r15
       call      qword ptr [7FFF2E02D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE318B8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE318C0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE318C8
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E02E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E593088
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E593078
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
       call      qword ptr [7FFF2DEC6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF74390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7F5A28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       call      qword ptr [7FFF2E02DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E04DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E17C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E68E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E68E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E68E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0447B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E28CE70]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E28CC90]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,240CC2F4368
       mov       r8,r15
       call      qword ptr [7FFF2E04D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE51C08
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE51C10
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE51C18
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E04E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E5B38A0
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
       call      qword ptr [7FFF2E12ED48]
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
       mov       rdx,7FFF2E5B3890
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
       call      qword ptr [7FFF2DEE6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF94390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6D4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E815A40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF9F708]
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
       call      qword ptr [7FFF2E04DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E15C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E66E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E26C9A8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E26C7C8]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,23720954368
       mov       r8,r15
       call      qword ptr [7FFF2E02D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE31CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE31CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE31CB8
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E02E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E594298
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E594288
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
       call      qword ptr [7FFF2DEC6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF74390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7F5A28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       call      qword ptr [7FFF2E02DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E01DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF2E14C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+28],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+28]
       mov       rdx,r8
       mov       r15,[rdx]
       mov       r13,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r15,r13
       jne       near ptr M00_L13
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L14
       mov       r8,[rsp+28]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E65E628]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r15,r13
       jne       near ptr M00_L15
       mov       r8,[rsp+28]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L16
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       r14d,1
       jo        short M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0147B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E25C9A8]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L12
       call      qword ptr [7FFF2E25C7C8]
       mov       r15,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,170F1814368
       mov       r8,r15
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M00_L13:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFF2DE21DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L14:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE21DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L15:
       mov       rcx,[rsp+28]
       mov       edx,eax
       mov       r11,7FFF2DE21DC8
       call      qword ptr [r11]
       mov       r8,[rsp+28]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFF2E01E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 601
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
       mov       rdx,7FFF2E5831E0
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
       call      qword ptr [7FFF2E0FED48]
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
       mov       rdx,7FFF2E5831D0
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
       call      qword ptr [7FFF2DEB6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFF2DF64390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FF8043C3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M03_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7E59E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F708]
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
       call      qword ptr [7FFF2E01DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2E967BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0347B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E27CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E27CC90]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,326CFEC4368
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,2E642004D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E967BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E03DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E27CE70]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E27CC90]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,326CFEC4368
       mov       r8,rdi
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E124C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2EA670F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2E967DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2E97C060]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0447B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E28C9A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E28C7C8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27ADB594368
       mov       r8,rbx
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,23A49804D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E97C030]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E04DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E28C9A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E28C7C8]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27ADB594368
       mov       r8,rdi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E134C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2EA77528]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2E97C258]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6D4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2E957BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0247B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E26CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E26CC90]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1BD30A04368
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,1BD30A07D08
       call      qword ptr [7FFF2E3BCF78]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       rdx,17C9EC04D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E957BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E02DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E26CE70]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFF2E26CC90]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,1BD30A04368
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2E957DC8]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF2E6B4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 720
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2E9CD260]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0447B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E28CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E28CC90]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,201810A4368
       mov       r8,rbx
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,201810A7D08
       call      qword ptr [7FFF2E3DCF78]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       rdx,1C0F3004D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E9CD230]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E04DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E28CE70]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L13
       call      qword ptr [7FFF2E28CC90]
       mov       rsi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,201810A4368
       mov       r8,rsi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2E9CD458]
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF2E6D4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 720
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2EA8E070]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0347B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E27C9A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E27C7C8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24FF30A4368
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,20F61002D90
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2EA8E040]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E03DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E27C9A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E27C7C8]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24FF30A4368
       mov       r8,rdi
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E124C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2E7B69D0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2EA8E268]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2EB1D260]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0147B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E25C9A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E25C7C8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23D018D4368
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,1FC73C04D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2EB1D230]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E01DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0147B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E25C9A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E25C7C8]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23D018D4368
       mov       r8,rdi
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E104C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2E7969D0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2EB1D458]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6A4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2EB9EF28]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0047B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E24CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E24CC90]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C9A7B74368
       mov       r8,rbx
       call      qword ptr [7FFF2E00D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,18915C02D90
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2EB9EEF8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E00DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0047B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E24CE70]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E24CC90]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C9A7B74368
       mov       r8,rdi
       call      qword ptr [7FFF2E00D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E0F4C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2E7869D0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2EB9F120]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E694D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      ecx,ecx
       jle       short M00_L02
       xor       esi,esi
       cmp       ecx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       call      qword ptr [7FFF2EC55980]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       short M00_L00
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0347B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E27C9A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E27C7C8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2314BDC4368
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 212
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
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       test      ebx,ebx
       cmovg     ecx,eax
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
       mov       rdx,1F0BE004D88
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
       mov       rax,7FF8043C3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L05
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2EC55950]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFF2E03DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E0347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFF2E27C9A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFF2E27C7C8]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2314BDC4368
       mov       r8,rdi
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFF2E124C00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF2E7B69D0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFF2EC55B78]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 742
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      esi,esi
       jle       near ptr M00_L09
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L10
M00_L00:
       test      eax,eax
       je        near ptr M00_L11
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,26C95802DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L13
       mov       r15,[rcx+18]
M00_L03:
       test      r15,r15
       je        near ptr M00_L18
       mov       rcx,r15
       call      qword ptr [7FFF2E665FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L14
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFF2E6B5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E22E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L04:
       mov       rcx,26C95802DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L15
       mov       r13,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6B5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFF2E95C1C8]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],rdi
       lea       r8,[rsp+40]
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2E95C360]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L16
M00_L06:
       add       r14d,1
       jo        near ptr M00_L08
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2AD2782F6A0
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2AD27820008
       call      qword ptr [7FFF2E5B4330]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L17
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E95C4F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L10:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFF2E26CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF2E26CC90]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,2AD27824368
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FFF2E5FF5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L14:
       xor       r15d,r15d
       jmp       near ptr M00_L04
M00_L15:
       call      qword ptr [7FFF2E5FF5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L16:
       sub       r14d,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L17:
       mov       ecx,14
       call      qword ptr [7FFF2E10ED00]
       int       3
M00_L18:
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,2AD2782F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,2AD2782021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,2AD27820008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 844
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
       mov       rdx,7FFF2E592C98
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E592C88
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
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE310A8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE310A0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE31098
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE31088
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE31090
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
       mov       rdx,7FFF2E6A6AC0
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
       mov       rdx,7FFF2E6A6B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E6B59E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFF2E6B5A28]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L04:
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 296
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
       mov       rdx,7FFF2E9B7128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9B7670
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
       mov       rdx,7FFF2E9B7318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9B7640
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
       mov       rdx,7FFF2E9B7658
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
       mov       rdx,7FFF2E9B7448
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE31008
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
       mov       rdx,7FFF2E9B7568
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
       call      qword ptr [7FFF2E134F30]
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
       mov       r11,7FFF2DE31010
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
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE31058
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
       mov       rdx,7FFF2E6A4698
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
       mov       rdx,7FFF2E6A46E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFF2E6B5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E097900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE31050
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFF2DE31048
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFF2DE31038
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE31040
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
       mov       rdx,7FFF2E2356D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E136640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFF2E2356D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E136640]
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
       mov       rdx,7FFF2E9456F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,2AD27820008
       mov       r9,2AD27837A90
       call      qword ptr [7FFF2E95C3D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFF2E9457A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFF2E95C420]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFF2E9457C0
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
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E64DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
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
       call      qword ptr [7FFF2E26CE88]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2AD27820210
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E136670]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
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
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      esi,esi
       jle       near ptr M00_L11
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L12
M00_L00:
       test      eax,eax
       je        near ptr M00_L13
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,2A186C04DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L15
       mov       r15,[rcx+18]
M00_L03:
       test      r15,r15
       je        near ptr M00_L09
       mov       rcx,r15
       call      qword ptr [7FFF2E665FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L16
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFF2E6B5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E22E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L04:
       mov       rcx,2A186C04DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L17
       mov       r13,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6B5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFF2E95C030]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],rdi
       lea       r8,[rsp+40]
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2E95C1C8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L08
M00_L06:
       add       r14d,1
       jo        near ptr M00_L10
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2E218CAF6A0
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2E218CA0008
       call      qword ptr [7FFF2E5B4330]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L18
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
       call      qword ptr [7FFF2E95C360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       sub       r14d,1
       jo        near ptr M00_L10
       jmp       near ptr M00_L06
M00_L09:
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,2E218CAF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,2E218CA021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,2E218CA0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      CORINFO_HELP_OVERFLOW
M00_L11:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L12:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L13:
       call      qword ptr [7FFF2E26CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L14
       call      qword ptr [7FFF2E26CC90]
       mov       rbx,rax
M00_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,2E218CA4368
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L15:
       call      qword ptr [7FFF2E5FF5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L16:
       xor       r15d,r15d
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FFF2E5FF5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       ecx,14
       call      qword ptr [7FFF2E10ED00]
       int       3
; Total bytes of code 844
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
       mov       rdx,7FFF2E592F58
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E592F48
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
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE31098
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE31090
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE31088
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE31078
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE31080
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
       mov       rdx,7FFF2E6A6AC0
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
       mov       rdx,7FFF2E6A6B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E6B59E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFF2E6B5A28]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L04:
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 296
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
       mov       rdx,7FFF2E9B8190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9B86D8
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
       mov       rdx,7FFF2E9B8380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9B86A8
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
       mov       rdx,7FFF2E9B86C0
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
       mov       rdx,7FFF2E9B84B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE30FF8
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
       mov       rdx,7FFF2E9B85D0
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
       call      qword ptr [7FFF2E134F30]
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
       mov       r11,7FFF2DE31000
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
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE31048
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
       mov       rdx,7FFF2E6A4698
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
       mov       rdx,7FFF2E6A46E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFF2E6B5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E097900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE31040
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFF2DE31038
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFF2DE31028
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE31030
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
       mov       rdx,7FFF2E2356D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E136640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFF2E2356D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E136640]
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
       mov       rdx,7FFF2E945648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,2E218CA0008
       mov       r9,2E218CB7A90
       call      qword ptr [7FFF2E95C240]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFF2E9456F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFF2E95C288]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFF2E945718
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
       call      qword ptr [7FFF2E26CE88]
       mov       ecx,43
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E64D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
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
       call      qword ptr [7FFF2E26CE88]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2E218CA0210
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E26CC78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E136670]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
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
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      esi,esi
       jle       near ptr M00_L11
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L12
M00_L00:
       test      eax,eax
       je        near ptr M00_L13
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,20328004DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L15
       mov       r15,[rcx+18]
M00_L03:
       test      r15,r15
       je        near ptr M00_L09
       mov       rcx,r15
       call      qword ptr [7FFF2E675FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L16
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFF2E6C5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E23E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L04:
       mov       rcx,20328004DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L17
       mov       r13,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6C5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFF2E967B70]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],rdi
       lea       r8,[rsp+40]
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2E967D08]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L08
M00_L06:
       add       r14d,1
       jo        near ptr M00_L10
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,243B9DDF6A0
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,243B9DD0008
       call      qword ptr [7FFF2E5C4330]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L18
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
       call      qword ptr [7FFF2E967EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       sub       r14d,1
       jo        near ptr M00_L10
       jmp       near ptr M00_L06
M00_L09:
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,243B9DDF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,243B9DD021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,243B9DD0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      CORINFO_HELP_OVERFLOW
M00_L11:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L12:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E0347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L13:
       call      qword ptr [7FFF2E27CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L14
       call      qword ptr [7FFF2E27CC90]
       mov       rbx,rax
M00_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,243B9DD4368
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L15:
       call      qword ptr [7FFF2E60F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L16:
       xor       r15d,r15d
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FFF2E60F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       ecx,14
       call      qword ptr [7FFF2E11ED00]
       int       3
; Total bytes of code 844
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
       mov       rdx,7FFF2E5A3100
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
       call      qword ptr [7FFF2E11ED48]
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
       mov       rdx,7FFF2E5A30F0
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
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE41098
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE41090
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE41088
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE41078
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE41080
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
       mov       rdx,7FFF2E6B6AC0
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
       mov       rdx,7FFF2E6B6B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E6C59E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFF2E6C5A28]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L04:
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 296
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
       mov       rdx,7FFF2E9C86B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9C8BF8
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
       mov       rdx,7FFF2E9C88A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9C8BC8
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
       mov       rdx,7FFF2E9C8BE0
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
       mov       rdx,7FFF2E9C89D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE40FF8
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
       mov       rdx,7FFF2E9C8AF0
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
       call      qword ptr [7FFF2E144F30]
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
       mov       r11,7FFF2DE41000
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
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE41048
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
       mov       rdx,7FFF2E6B4698
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
       mov       rdx,7FFF2E6B46E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFF2E6C5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E0A7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE41040
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFF2DE41038
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFF2DE41028
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE41030
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
       mov       rdx,7FFF2E2456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E146640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFF2E2456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E146640]
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
       mov       rdx,7FFF2E955D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,243B9DD0008
       mov       r9,243B9DE7A90
       call      qword ptr [7FFF2E967D80]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFF2E955DE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFF2E967DC8]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFF2E955E00
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
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E65DB10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
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
       call      qword ptr [7FFF2E27CE88]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,243B9DD0210
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E146670]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
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
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       test      esi,esi
       jle       near ptr M00_L11
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M00_L12
M00_L00:
       test      eax,eax
       je        near ptr M00_L13
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,1F850C02DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L15
       mov       r15,[rcx+18]
M00_L03:
       test      r15,r15
       je        near ptr M00_L09
       mov       rcx,r15
       call      qword ptr [7FFF2E675FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L16
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFF2E6C5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E23E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L04:
       mov       rcx,1F850C02DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L17
       mov       r13,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6C5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFF2E9BEAF0]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],rdi
       lea       r8,[rsp+40]
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2E9BEC88]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L08
M00_L06:
       add       r14d,1
       jo        near ptr M00_L10
       cmp       r14d,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,238E2B5F6A0
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,238E2B50008
       call      qword ptr [7FFF2E5C4330]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L18
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
       call      qword ptr [7FFF2EAA5500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       sub       r14d,1
       jo        near ptr M00_L10
       jmp       near ptr M00_L06
M00_L09:
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,238E2B5F6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,238E2B5021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,238E2B50008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      CORINFO_HELP_OVERFLOW
M00_L11:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M00_L00
M00_L12:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E0347B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L13:
       call      qword ptr [7FFF2E27CE70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L14
       call      qword ptr [7FFF2E27CC90]
       mov       rbx,rax
M00_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,238E2B54368
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L15:
       call      qword ptr [7FFF2E60F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L16:
       xor       r15d,r15d
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FFF2E60F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       ecx,14
       call      qword ptr [7FFF2E11ED00]
       int       3
; Total bytes of code 844
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
       mov       rdx,7FFF2E5A3228
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
       call      qword ptr [7FFF2E11ED48]
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
       mov       rdx,7FFF2E5A3218
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
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE41278
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE41270
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE41268
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE41258
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE41260
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
       mov       rdx,7FFF2E6B6AC0
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
       mov       rdx,7FFF2E6B6B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E6C59E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFF2E6C5A28]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L04:
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 296
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
       mov       rdx,7FFF2E9AADF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9AB340
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
       mov       rdx,7FFF2E9AAFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E9AB310
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
       mov       rdx,7FFF2E9AB328
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
       mov       rdx,7FFF2E9AB118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE41188
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
       mov       rdx,7FFF2E9AB238
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
       call      qword ptr [7FFF2E144F30]
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
       mov       r11,7FFF2DE41190
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
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE41228
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
       mov       rdx,7FFF2E6B4698
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
       mov       rdx,7FFF2E6B46E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFF2E6C5908]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E0A7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE41220
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFF2DE41218
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFF2DE41208
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE41210
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
       mov       rdx,7FFF2E2456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E146640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFF2E2456D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E146640]
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
       mov       rdx,7FFF2E9A86F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,238E2B50008
       mov       r9,238E2B67A90
       call      qword ptr [7FFF2E9BED00]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFF2E9A87A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFF2E9BED48]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFF2E9A87C8
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
       call      qword ptr [7FFF2E27CE88]
       mov       ecx,43
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E65D9C0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
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
       call      qword ptr [7FFF2E27CE88]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,238E2B50210
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E27CC78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E146670]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
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
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
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
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2554B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E657B10]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2EA6EC58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E014780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,23C27A50008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,23C27A54368
       call      qword ptr [7FFF2E25C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E01DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-90],3E8
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,1FB99C04DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5EF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6A5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-80],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,1FB99C04DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5EF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6A5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0A8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2EA6EAF0]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-88]
       mov       [rbp-68],r8
       lea       r8,[rbp-68]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2EA6EC88]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L02
       mov       rcx,7FFF2EA795A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-5C]
       sub       ecx,1
       jo        near ptr M02_L05
       mov       [rbp-5C],ecx
M02_L02:
       mov       rcx,7FFF2EA795A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L05
       mov       [rbp-5C],ecx
M02_L03:
       mov       ecx,[rbp-90]
       dec       ecx
       mov       [rbp-90],ecx
       cmp       dword ptr [rbp-90],0
       jg        short M02_L04
       lea       rcx,[rbp-90]
       mov       edx,6E
       call      CORINFO_HELP_PATCHPOINT
M02_L04:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EA795A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2E766B08]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0E0
       pop       rbp
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
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
       mov       rdx,7FFF2EB01398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E254B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EAECC90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2754B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E677B10]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2EB3D368]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
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
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E034780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,22826CA0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,22826CA4368
       call      qword ptr [7FFF2E27C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-90],3E8
       jmp       near ptr M02_L03
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L01:
       mov       rcx,1E794C04DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E60F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6C5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-80],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,1E794C04DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E60F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6C5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0A8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2EB3D200]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-88]
       mov       [rbp-68],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-68]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2EB3D398]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L02
       mov       rcx,7FFF2EB49970
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-5C]
       sub       ecx,1
       jo        near ptr M02_L05
       mov       [rbp-5C],ecx
M02_L02:
       mov       rcx,7FFF2EB49974
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L05
       mov       [rbp-5C],ecx
M02_L03:
       mov       ecx,[rbp-90]
       dec       ecx
       mov       [rbp-90],ecx
       cmp       dword ptr [rbp-90],0
       jg        short M02_L04
       lea       rcx,[rbp-90]
       mov       edx,6E
       call      CORINFO_HELP_PATCHPOINT
M02_L04:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EB49978
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2E7867A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0E0
       pop       rbp
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
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
       mov       rdx,7FFF2EC24A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E274B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC34B70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2554B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E657B10]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2EBAF030]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
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
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E014780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,2E0C50E0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,2E0C50E4368
       call      qword ptr [7FFF2E25C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E01DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-90],3E8
       jmp       near ptr M02_L03
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L01:
       mov       rcx,2A03B002DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5EF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6A5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-80],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,2A03B002DB0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5EF630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6A5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0A8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2EBAEEC8]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-88]
       mov       [rbp-68],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-68]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2EBAF060]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L02
       mov       rcx,7FFF2EBD1EA0
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-5C]
       sub       ecx,1
       jo        near ptr M02_L05
       mov       [rbp-5C],ecx
M02_L02:
       mov       rcx,7FFF2EBD1EA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L05
       mov       [rbp-5C],ecx
M02_L03:
       mov       ecx,[rbp-90]
       dec       ecx
       mov       [rbp-90],ecx
       cmp       dword ptr [rbp-90],0
       jg        short M02_L04
       lea       rcx,[rbp-90]
       mov       edx,6E
       call      CORINFO_HELP_PATCHPOINT
M02_L04:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EBD1EA8
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2E7667A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0E0
       pop       rbp
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
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
       mov       rdx,7FFF2EC1A4C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E254B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC26088]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2854B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E687B10]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonNames(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2EC65368]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
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
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       mov       edx,1
       call      qword ptr [7FFF2E044780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-70]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,22B8D450008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,22B8D454368
       call      qword ptr [7FFF2E28C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var names = new List<PersonName>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E04DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
; 		for (var nameIndex = 0; nameIndex < count; nameIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-90],3E8
       jmp       near ptr M02_L03
; 			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L01:
       mov       rcx,1EAFF404DA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E61F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6D5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-80],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,1EAFF404DA8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E61F630]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6D5758]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0A8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2EC65200]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       r8,[rbp-88]
       mov       [rbp-68],r8
; 			if (names.AddIfNotExists(personName) is false)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       r8,[rbp-68]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFF2EC65398]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L02
       mov       rcx,7FFF2EC4F3F8
       call      CORINFO_HELP_COUNTPROFILE32
; 				nameIndex--;
; 				^^^^^^^^^^^^
       mov       ecx,[rbp-5C]
       sub       ecx,1
       jo        near ptr M02_L05
       mov       [rbp-5C],ecx
M02_L02:
       mov       rcx,7FFF2EC4F3FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L05
       mov       [rbp-5C],ecx
M02_L03:
       mov       ecx,[rbp-90]
       dec       ecx
       mov       [rbp-90],ecx
       cmp       dword ptr [rbp-90],0
       jg        short M02_L04
       lea       rcx,[rbp-90]
       mov       edx,6E
       call      CORINFO_HELP_PATCHPOINT
M02_L04:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EC4F400
       call      CORINFO_HELP_COUNTPROFILE32
; 		return names.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>)
       call      qword ptr [7FFF2E7967A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0E0
       pop       rbp
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
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
       mov       rdx,7FFF2EC5D5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E284B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC66A48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E274F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E677B40]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E9BD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E034780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,20184FF0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,20184FF4368
       call      qword ptr [7FFF2E2779F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-78],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF2E76E858
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF2E677B28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0572C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-5C],ecx
M02_L01:
       mov       ecx,[rbp-78]
       dec       ecx
       mov       [rbp-78],ecx
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF2E76E85C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E7867A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
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
       mov       rdx,7FFF2E9F9608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2745A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E9EF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E274F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E677B40]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2EA7F480]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E034780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,2A543FC0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,2A543FC4368
       call      qword ptr [7FFF2E2779F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E03DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-78],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF2E76E858
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF2E677B28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0572C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-5C],ecx
M02_L01:
       mov       ecx,[rbp-78]
       dec       ecx
       mov       [rbp-78],ecx
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF2E76E85C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E7867A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
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
       mov       rdx,7FFF2EB24DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2745A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EB0D968]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E254F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E657B40]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2EB1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E014780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,26BBDAE0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,26BBDAE4368
       call      qword ptr [7FFF2E2579F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E01DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-78],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF2E74E858
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF2E657B28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0372C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-5C],ecx
M02_L01:
       mov       ecx,[rbp-78]
       dec       ecx
       mov       [rbp-78],ecx
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF2E74E85C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E7667A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
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
       mov       rdx,7FFF2EB7CD80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2545A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC145A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2654B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E667B40]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2EBBEE98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,23781400008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,23781404368
       call      qword ptr [7FFF2E26C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-78],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF2E75E858
       call      CORINFO_HELP_COUNTPROFILE32
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF2E667B28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-5C],ecx
M02_L01:
       mov       ecx,[rbp-78]
       dec       ecx
       mov       [rbp-78],ecx
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF2E75E85C
       call      CORINFO_HELP_COUNTPROFILE32
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E7767A8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
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
       mov       rdx,7FFF2EC28CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC35AD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E667B40]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2EC451D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,23A53F70008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,23A53F74368
       call      qword ptr [7FFF2E2679F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-78],3E8
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF2E75E808
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF2E667B28]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E0472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L03
       mov       [rbp-5C],ecx
M02_L01:
       mov       ecx,[rbp-78]
       dec       ecx
       mov       [rbp-78],ecx
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF2E75E80C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFF2E776B08]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
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
       mov       rdx,7FFF2EC3B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2645A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC46178]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E667DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFF2E9AD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,130
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,2D1C23A0008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,2D1C23A4368
       call      qword ptr [7FFF2E2679F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E7A6820]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-0C0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF2E90FC00
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0B8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E66CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-110],rcx
       lea       rdi,[rbp-108]
       lea       rsi,[rbp-0B8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-110]
       lea       rdx,[rbp-108]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7C53F8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-5C],ecx
M02_L02:
       mov       ecx,[rbp-0C0]
       dec       ecx
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jg        short M02_L03
       lea       rcx,[rbp-0C0]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2E90FC04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF2E925A70]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,130
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 431
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
       mov       rdx,7FFF2EAACD20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2645A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EA867D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E254F30]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E657DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFF2EA6EAC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,130
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E014780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,3021E700008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,3021E704368
       call      qword ptr [7FFF2E2579F0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E7ED818]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-0C0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF2E95E7F8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0B8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E65CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-110],rcx
       lea       rdi,[rbp-108]
       lea       rsi,[rbp-0B8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-110]
       lea       rdx,[rbp-108]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7F68F8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-5C],ecx
M02_L02:
       mov       ecx,[rbp-0C0]
       dec       ecx
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jg        short M02_L03
       lea       rcx,[rbp-0C0]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2E95E7FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF2E94C720]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,130
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 431
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
       mov       rdx,7FFF2EB0DEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2545A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EAED278]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2754B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E677DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFF2EB3D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,130
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
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
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E034780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,1B941560008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,1B941564368
       call      qword ptr [7FFF2E27C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E80DBF0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-0C0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF2EAD0F60
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0B8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E67CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-110],rcx
       lea       rdi,[rbp-108]
       lea       rsi,[rbp-0B8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-110]
       lea       rdx,[rbp-108]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E818850]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-5C],ecx
M02_L02:
       mov       ecx,[rbp-0C0]
       dec       ecx
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jg        short M02_L03
       lea       rcx,[rbp-0C0]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EAD0F64
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF2EA87000]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,130
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 431
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
       mov       rdx,7FFF2EC22A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E274B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC345A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2654B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E667DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFF2EBBEB08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,130
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E024780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,23D7A370008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,23D7A374368
       call      qword ptr [7FFF2E26C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E7FDBF0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-0C0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF2EADA380
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0B8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E66CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-110],rcx
       lea       rdi,[rbp-108]
       lea       rsi,[rbp-0B8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-110]
       lea       rdx,[rbp-108]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E808A30]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-5C],ecx
M02_L02:
       mov       ecx,[rbp-0C0]
       dec       ecx
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jg        short M02_L03
       lea       rcx,[rbp-0C0]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EADA384
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF2EAACF18]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,130
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 431
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
       mov       rdx,7FFF2EC287F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E264B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC356F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E2554B8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFF2E657DE0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FFF2EC351D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       sub       rsp,130
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
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
       mov       dword ptr [rbp-48],1
       mov       dword ptr [rbp-50],7FFFFFFF
       xor       ecx,ecx
       mov       [rbp-68],rcx
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FFF2E014780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r9,[rbp-68]
       mov       [rbp-58],r9
       lea       r9,[rbp-58]
       mov       [rsp+20],r9
       mov       r9,25574060008
       mov       [rsp+28],r9
       lea       r9,[rbp-50]
       lea       rdx,[rbp-48]
       mov       ecx,[rbp+10]
       mov       r8,25574064368
       call      qword ptr [7FFF2E25C0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32 ByRef, System.String, Int32 ByRef, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
; 		var people = new List<Models.ValueTypes.Person<TAddress>>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFF2E7EDBD8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       dword ptr [rbp-0C0],3E8
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF2EB9D1B0
       call      CORINFO_HELP_COUNTPROFILE32
; 			people.Add(GeneratePersonVal<TAddress>());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp-0B8]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF2E65CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-110],rcx
       lea       rdi,[rbp-108]
       lea       rsi,[rbp-0B8]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-110]
       lea       rdx,[rbp-108]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7F8828]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M02_L04
       mov       [rbp-5C],ecx
M02_L02:
       mov       ecx,[rbp-0C0]
       dec       ecx
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jg        short M02_L03
       lea       rcx,[rbp-0C0]
       mov       edx,49
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       ecx,[rbp-5C]
       cmp       ecx,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF2EB9D1B4
       call      CORINFO_HELP_COUNTPROFILE32
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF2EBB50F8]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       nop
       add       rsp,130
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 431
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
       mov       rdx,7FFF2EC2BE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF2E254B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2EC36178]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,2228A004CF8
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
       mov       rcx,2228A001DD8
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
       mov       rdx,2228A004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2228A004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,138E2004CF8
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
       mov       rcx,138E2001DD8
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
       mov       rdx,138E2004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,138E2004CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,1DEBD404CF8
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
       mov       rcx,1DEBD401DD8
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
       mov       rdx,1DEBD404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DEBD404CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,28550C04CF8
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
       mov       rcx,28550C01DE0
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
       mov       rdx,28550C04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28550C04CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,1958F402D00
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
       mov       rcx,19593401DD8
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
       mov       rdx,1958F402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1958F402D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E154F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E154F30]
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
       call      qword ptr [7FFF2DF941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,22613C02D00
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
       mov       rcx,22617C01DD8
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
       mov       rdx,22613C02CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22613C02D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E134F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       call      qword ptr [7FFF2DF741F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,25FCCC04CF8
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
       mov       rcx,25FCCC01DD8
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
       mov       rdx,25FCCC04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25FCCC04CF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,1BFFAC02D00
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
       mov       rcx,1BFFEC01DE0
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
       mov       rdx,1BFFAC02CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BFFAC02D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,2079C402D10
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
       mov       rcx,207A0401DD8
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
       mov       rdx,2079C402CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2079C402D10
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,17602004D08
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
       mov       rcx,17602001DE0
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
       mov       rdx,17602004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17602004D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,1FB46804D08
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
       mov       rcx,1FB46801DD8
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
       mov       rdx,1FB46804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FB46804D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,12CF9404D08
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
       mov       rcx,12CF9401DE0
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
       mov       rdx,12CF9404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12CF9404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,17C1E004D08
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
       mov       rcx,17C1E001DE0
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
       mov       rdx,17C1E004CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17C1E004D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,21964404D08
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
       mov       rcx,21964401DD8
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
       mov       rdx,21964404CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21964404D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E154F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E154F30]
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
       call      qword ptr [7FFF2DF941F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,297CA804D08
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
       mov       rcx,297CA801DD8
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
       mov       rdx,297CA804CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,297CA804D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E144F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E144F30]
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
       call      qword ptr [7FFF2DF841F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,28AFEC04D08
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
       mov       rcx,28AFEC01DE0
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
       mov       rdx,28AFEC04CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28AFEC04D08
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
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
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

