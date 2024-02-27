## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9050C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA17498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE24828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6C4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,2A39C6C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2A39C6C43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCA72B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA1E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCB3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCA7480]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE06408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE24858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA27498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE57A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,18998C50008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,18998C543B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCB7510]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA2E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCC3A58]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCB76D8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE45C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE57AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA27498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CF75398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,25FCC000008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,25FCC0043B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCB72B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA2E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCC3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCB7480]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CF3CBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF753C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C914BB8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA26B68]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFBE9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E4350],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4E48],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,242CABC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,242CABC43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCC5908]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA2E340]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCB3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCC5AD0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8E4350],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFA85A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFBEA18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA47498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFF5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,241D47F0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,241D47F43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCD72B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA4E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCE3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCD7480]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFD86B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF53C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA27498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFD5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,315A8440008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,315A84443B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCB7318]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA2E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCC3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCB74E0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFB8B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD53C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9450C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA57498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86D005398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9142F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C914DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,204389B0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,204389B43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCE72B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA5E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCF3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCE7480]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFE96B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86D0053C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA37498]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,185F2330008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,185F23343B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CCC7318]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-38],rcx
       lea       rcx,[rbp-48]
       call      qword ptr [7FF86CA3E9E8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-38]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       mov       ecx,[rbp-40]
       mov       [rbp-58],ecx
       mov       rcx,[rbp-68]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCD3BB0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-0C],ecx
M02_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CCC74E0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 343
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFC9CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE53C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9450C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA5D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE64828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9142F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C914DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,23958FF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,23958FF43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD033F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C70DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD03440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA5EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C726D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C70E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE46408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE64858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA4D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE77D08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,319398B0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,319398B43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CCF3228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CCF3278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA4EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE65DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE77D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA4D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CF47A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,1FC77620008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1FC776243B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CCF33F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CCF3440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA4EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CF1FBD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF47D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA3D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,28AA5B70008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,28AA5B743B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD71040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD71090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCADE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9050C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA1D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF86CFC5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6C4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,1BCEDAC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1BCEDAC43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD58BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD58C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA1EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6E6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6CE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFAB488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA2D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF86CFD5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,23199A00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,23199A043B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD682B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD68300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA2EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6F6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6DE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFB9F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA4D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF86CFF5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,22D85C40008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,22D85C443B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD88838
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD88888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA4EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFDA530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       call      qword ptr [7FF86CA3D398]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF86CFE5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,29EAAB90008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,29EAAB943B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD78220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M02_L07
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF86CD78270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA00]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L06
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       [rbp-14],eax
M02_L07:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M02_L03
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 455
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCAC28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE6718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,20F6B004A18
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,20F6B001DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE348B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20F6B004A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20F6B004A18
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE165C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE348E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF2B4DC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF2B4D8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,26601404A18
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,26601401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE77408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26601404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26601404A18
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE67C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE77438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF72BFC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF72BF8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,249E1804A18
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,249E1801DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CF6CD80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,249E1804A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,249E1804A18
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CF55D20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF6CDB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,29223C04A18
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,29223C01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFF48D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29223C04A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29223C04A18
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFD8CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF4900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,20D1D802A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,20D19801DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFC5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20D1D802A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C614210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20D1D802A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7D4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFA88F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6141F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,1681C404A18
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1681C401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1681C404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1681C404A18
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFB8C58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,179B8802A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,179BC801DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFC5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,179B8802A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C614210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,179B8802A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7D4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFA94B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6141F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,18F33002A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,18F37001DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFC5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18F33002A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C614210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18F33002A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7D4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFA9DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6141F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA37048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE44828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,21C48BF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,21C48BF43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,21C48BF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,21C48BFE1D0
       mov       r9d,64
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,21C48BF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,21C48BFE200
       mov       r9d,32
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA74828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,21C48BF0008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CE44858]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA7D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC9C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA55CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09F0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCC4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09E8
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC9F9F0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09F8
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE26C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE449C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA37048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE55ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,22B020A0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,22B020A43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,22B020A0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,22B020AE1D0
       mov       r9d,64
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,22B020A0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,22B020AE200
       mov       r9d,32
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA74828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,22B020A0008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CE55F08]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA7D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC9C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA55CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09F0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCC4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09E8
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC9F9F0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F09F8
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE384C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE56070]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA47048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CF5D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,21472210008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,214722143B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,21472210008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,2147221E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,21472210008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,2147221E200
       mov       r9d,32
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA84828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,21472210008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CF5D3B0]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA8D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CCAC888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA65CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C500BF8
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCD4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C500BF0
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CCAF7E0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C500C00
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CF75690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF5D518]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C944BB8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA56718]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFFE9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C914348],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C914E40],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,1C3A3660008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,1C3A36643B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,1C3A3660008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,1C3A366E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA9C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,1C3A3660008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,1C3A366E200
       mov       r9d,32
       call      qword ptr [7FF86CA9C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C70DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA94180]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1C3A3660008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CFFEA18]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CCB6AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA75CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C510CF8
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCBF018]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C726D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C510CF0
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CCBE0A0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C510D00
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C914348],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFD9378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFFEB80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA37048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,297BE570008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,297BE5743B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,297BE570008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,297BE57E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,297BE570008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,297BE57E200
       mov       r9d,32
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA74828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,297BE570008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CFE53C8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA7D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC9C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA55CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F0CF0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCC4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F0CE8
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC9F9F0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4F0CF8
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCAD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE5530]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9050C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA17048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFC5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6C4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,1E6A2A00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,1E6A2A043B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,1E6A2A00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,1E6A2A0E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,1E6A2A00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,1E6A2A0E200
       mov       r9d,32
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA54828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1E6A2A00008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CFC53C8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA5D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC7C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA35CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0CF0
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCA4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6E6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0CE8
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC7F7E0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0CF8
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFA9300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5530]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       edx,eax
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA27048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFD5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,287AA670008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,287AA6743B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,287AA670008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,287AA67E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,287AA670008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,287AA67E200
       mov       r9d,32
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA64828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,287AA670008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CFD53C8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA6D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC8C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA45CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4E0D50
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCB4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6F6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4E0D48
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC8F9F0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4E0D58
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFB9A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5530]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9050C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       ecx,0EB
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA17048]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CFC5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.CountryName, Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,2
       call      qword ptr [7FF86C6C4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,25661840008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,256618443B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,25661840008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,2566184E1D0
       mov       r9d,64
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,25661840008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,2566184E200
       mov       r9d,32
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+28],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA54828]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       eax,[rbp+10]
       mov       [rcx+8],eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,25661840008
       mov       [rbp-70],rcx
       mov       rcx,[rbp-60]
       call      qword ptr [7FF86CFC53C8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,[rbp-68]
       mov       r9,[rbp-70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.Country, System.String, System.String)
       call      qword ptr [7FF86CA5D698]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-80],rax
       mov       edx,[rbp+28]
       mov       [rsp+20],edx
       mov       rdx,[rbp-80]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       call      qword ptr [7FF86CC7C888]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA35CC8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-20],rcx
       nop
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0D90
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-28]
       call      qword ptr [7FF86CCA4AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.ToAddress(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6E6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
M02_L03:
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0D88
       call      qword ptr [r11]
       mov       [rbp-94],eax
       cmp       dword ptr [rbp-94],0
       jne       short M02_L02
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>)
       call      qword ptr [7FF86CC7F7E0]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L05
       mov       rcx,[rbp-20]
       mov       r11,7FF86C4D0D98
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 812
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFF7FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86D014AE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA37240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE44828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2E1D7DE0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2E1D7DE43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA37228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE26410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE44858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9450C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA57240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE64828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9142F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C914DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2601FEE0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2601FEE43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C70DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA57228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C726D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C70E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE46408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE64858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA37240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFB5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,21E95880008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,21E958843B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA37228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFE5498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFB6928]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA27240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFD5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2D881730008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2D8817343B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA27228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6F6D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6DE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFBB158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924BB8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA36910]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FF86CFDE9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DD8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,1704EAC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1704EAC43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA368F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C8F42E0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFB9F30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFDF168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA47240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FF86CFF5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,319F4E10008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,319F4E143B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA47228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFDA388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934BB8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA46910]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FF86CFDEC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C904348],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C904E40],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,214A06F0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,214A06F43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8C600]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA468F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C904348],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCAA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFDF3C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9450C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CA57240]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FF86D005398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9142F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C914DF0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2B15C530008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2B15C5343B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C70DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M02_L03
M02_L01:
       nop
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF86CA57228]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C726D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M02_L02
       call      CORINFO_HELP_OVERFLOW
M02_L02:
       mov       [rbp-0C],ecx
M02_L03:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C70E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 323
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFEA720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86D005B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CCCD8D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE44828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,25733620008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,257336243B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA3DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA58FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA3DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE26408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE44858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9150C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CCBD8D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CE5C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,26607110008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,266071143B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA2DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA2EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA48FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA2DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CE45D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE5C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD15248]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CF94D08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,311EEF00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,311EEF043B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA4DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA4EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA68FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA4DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CF5CB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF94D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD67120]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,3186F2C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,3186F2C43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA3DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA58FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA3DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCA308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9350C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD77108]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FF86CFF5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C904DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,216DCE00008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,216DCE043B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA4DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA4EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA68FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA4DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFDA070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD67108]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2980A040008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2980A0443B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA3DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA58FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA3DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFC9D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9250C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD67150]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FF86CFE5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,202EEFE0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,202EEFE43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA3DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA3EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA58FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA3DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFCA9C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFE5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C9050C8]; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FF86CD47108]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>>)
       call      qword ptr [7FF86CFC5398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,110
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6C4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,19FBA9F0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,19FBA9F43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA5D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86CA1DD10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M02_L04
M02_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF86CA1EA30]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-0E8],rcx
       lea       rdi,[rbp-0E0]
       lea       rsi,[rbp-90]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbp-0E8]
       lea       rdx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA38FC8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-1C],ecx
M02_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M02_L02
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA1DED8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]].AsReadOnly()
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,110
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 405
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CFAAA90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,271F3404A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,271F3401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE548B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,271F3404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,271F3404A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE36560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE548E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF594D4
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF594D0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,1BE07804A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1BE07801DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE65F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1BE07804A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BE07804A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE47ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE65F98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF6187C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF61878
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,17580004A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,17580001DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CF7E448]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,17580004A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17580004A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CF83098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF7E478]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,2ABB4004A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,2ABB4001DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2ABB4004A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2ABB4004A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFB8700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,2D6A8404A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,2D6A8401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2D6A8404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2D6A8404A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFBA7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,1B348C04A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1B348C01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B348C04A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B348C04A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFBA558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,1F33EC02A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1F33AC01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFF5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F33EC02A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F33EC02A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFD91E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rcx,1601A804A20
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1601A801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFEF000]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1601A804A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF86C654210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1601A804A20
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C814F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C814F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C914330],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFD9808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFEF030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6541F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__10_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,1E01A802A30
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1E016801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE2F408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E01A802A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E01A802A30
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C904330],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE365C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE2F438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF59514
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF59510
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,1C867C04A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1C867C01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CE47E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C867C04A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C867C04A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CE37C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CE47E88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,7FF86CF44F04
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,7FF86CF44F00
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 82
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,28608404A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,28608401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CF6C8D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,28608404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C614210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28608404A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7D4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CF72F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CF6C900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6141F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,1316AC04A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1316AC01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1316AC04A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1316AC04A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFB8868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,24F38C04A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,24F38C01DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFC5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24F38C04A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C614210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24F38C04A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7D4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7D4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFA8B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFC5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6141F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,1D0A0804A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,1D0A0801DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0A0804A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D0A0804A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFB8D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,2A86C404A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,2A86C401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFF5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2A86C404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C644210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A86C404A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C804F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C804F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFD9608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFF5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6441F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rcx,22216404A28
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L01
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
       mov       rcx,22216401DC8
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,rbx
       mov       r8,rbp
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Linq.IOrderedEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]], System.Linq]](System.Linq.IOrderedEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86CFD5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22216404A10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FF86C624210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22216404A28
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FF86C7E4F30]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FF86C7E4F30]
       int       3
; Total bytes of code 255
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86CFB97A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CFD5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF86C6241F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

