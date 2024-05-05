## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [7FFE38809688]
       call      qword ptr [7FFE38447B10]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3870E6A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,100
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0D0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D8],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       cmp       dword ptr [7FFE382E4D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       vmovsd    xmm0,qword ptr [rbp+10]
       vmovsd    qword ptr [rbp-30],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFE380791D0]
       setae     al
       mov       [rbp-34],eax
       xor       eax,eax
       mov       [rbp-40],rax
       call      qword ptr [7FFE38164270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-48],rax
       call      qword ptr [7FFE384768F8]; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp-50],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       r8,[rbp-58]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp-58]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE38026C28]; System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp-60],rax
       mov       rdx,1B3DB9B4238
       mov       [rsp+20],rdx
       vmovsd    xmm0,qword ptr [rbp-30]
       mov       edx,[rbp-34]
       vmovsd    xmm2,qword ptr [rbp-40]
       mov       r9,[rbp-60]
       call      qword ptr [7FFE3870E6D0]; DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp-68],xmm0
       vmovsd    xmm0,qword ptr [rbp-68]
       vmovsd    qword ptr [rbp+10],xmm0
       mov       rdx,17349C02AD0
       mov       rdx,[rdx]
       mov       [rbp-8],rdx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE3802E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rax,[rax]
       mov       [rbp-70],rax
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFE380791D8]
       call      qword ptr [7FFE3827F360]; System.Convert.ToInt32(Double)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-80],rax
       lea       rcx,[rbp-90]
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE3816E988]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rcx,[rbp-70]
       mov       [rbp-0D0],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-0C8],xmm0
       mov       rcx,[rbp-0D0]
       lea       rdx,[rbp-0C8]
       mov       rax,[rbp-0D0]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       nop
       nop
       nop
       mov       rcx,rsp
       call      M01_L02
       nop
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFE380791D8]
       call      qword ptr [7FFE3827F360]; System.Convert.ToInt32(Double)
       mov       [rbp-94],eax
       mov       edx,[rbp-94]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       lea       rcx,[rbp-0B0]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFE3816E988]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-0B0]
       vmovdqu   xmmword ptr [rbp-20],xmm0
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE3816EC28]; System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,100
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+100]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L03
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE382E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38305638]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE386FDB40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38734C18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38456DA8]; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter()
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38747DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Char, System.Private.CoreLib]](Char)
; Total bytes of code 30
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       cmp       dword ptr [7FFE38304D70],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FFE38456DC0]; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter(Char, Char)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       movzx     eax,ax
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Char, System.Private.CoreLib]](Char)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE38304330],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38747DE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE38447930]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+38]
       mov       [rsp+28],ecx
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE3873C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rcx,7FFE382F5128
       mov       edx,5
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       dword ptr [7FFE382F4D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE384756C8]; System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-20]
       mov       [rbp-10],rcx
       mov       ecx,[rbp-18]
       mov       [rbp-8],ecx
       lea       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE38447648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-2C],eax
       mov       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE382EF6D8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_X(Int32)
       nop
       lea       rcx,[rbp-10]
       mov       [rbp-38],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE38447648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-3C],eax
       mov       rcx,[rbp-38]
       mov       edx,[rbp-3C]
       call      qword ptr [7FFE382EF738]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_Y(Int32)
       nop
       lea       rcx,[rbp-10]
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE38447648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-4C],eax
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       call      qword ptr [7FFE382EF798]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_Z(Int32)
       nop
       mov       rax,[rbp+10]
       mov       rcx,[rbp-10]
       mov       [rax],rcx
       mov       ecx,[rbp-8]
       mov       [rax+8],ecx
       mov       rax,[rbp+10]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 252
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE382F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3873C990]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 78
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       mov       rbx,rcx
       xor       edx,edx
       mov       [rsp+30],edx
       mov       [rsp+34],edx
       mov       [rsp+38],rdx
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       qword ptr [rsp+28],3E8
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       lea       rcx,[rsp+40]
       mov       r9d,2
       call      qword ptr [7FFE38456E38]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovups   xmm0,[rsp+40]
       vmovups   [rsp+30],xmm0
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE38747DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal)
       nop
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 112
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       push      rbp
       sub       rsp,180
       vzeroupper
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE38304D70],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       xor       edx,edx
       call      qword ptr [7FFE380F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,2685C5C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       xor       edx,edx
       mov       r8,2685C5D4338
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3848DE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+28],ecx
       lea       rcx,[rbp-40]
       mov       edx,[rbp+28]
       call      qword ptr [7FFE38164870]; System.Decimal.op_Implicit(Int32)
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-50],xmm0
       lea       rcx,[rbp-50]
       mov       edx,0A
       call      qword ptr [7FFE38164018]; System.Decimal..ctor(Int32)
       vmovups   xmm0,[rbp-40]
       vmovups   [rbp-0C0],xmm0
       vmovups   xmm0,[rbp-50]
       vmovups   [rbp-0D0],xmm0
       lea       rdx,[rbp-0C0]
       lea       r8,[rbp-0D0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE38164A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-10],xmm0
       mov       rdx,[rbp+18]
       vmovups   xmm0,[rdx]
       vmovups   [rbp-0E0],xmm0
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-0F0],xmm0
       lea       rdx,[rbp-0E0]
       lea       r8,[rbp-0F0]
       lea       rcx,[rbp-70]
       call      qword ptr [7FFE38164A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-70]
       vmovups   [rbp-100],xmm0
       lea       rcx,[rbp-100]
       call      qword ptr [7FFE38164978]; System.Decimal.op_Explicit(System.Decimal)
       mov       [rbp-74],eax
       mov       rdx,[rbp+20]
       vmovups   xmm0,[rdx]
       vmovups   [rbp-110],xmm0
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-120],xmm0
       lea       rdx,[rbp-110]
       lea       r8,[rbp-120]
       lea       rcx,[rbp-88]
       call      qword ptr [7FFE38164A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-88]
       vmovups   [rbp-130],xmm0
       lea       rcx,[rbp-130]
       call      qword ptr [7FFE38164978]; System.Decimal.op_Explicit(System.Decimal)
       mov       [rbp-8C],eax
       mov       ecx,[rbp-74]
       mov       edx,[rbp-8C]
       call      qword ptr [7FFE38456EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-90],eax
       lea       rcx,[rbp-0A0]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE38164870]; System.Decimal.op_Implicit(Int32)
       vmovups   xmm0,[rbp-0A0]
       vmovups   [rbp-140],xmm0
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-150],xmm0
       lea       rdx,[rbp-140]
       lea       r8,[rbp-150]
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFE38164AB0]; System.Decimal.op_Division(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-0B0]
       vmovups   [rbp-20],xmm0
       nop
       mov       rax,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rbp-20]
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rbp+10]
       add       rsp,180
       pop       rbp
       ret
; Total bytes of code 548
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE38304330],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3874C498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 78
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE384575B8]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3874C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       cmp       dword ptr [7FFE38304D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,109C5804AA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFE383E76F0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FFE38457498]; DotNetTips.Spargine.Tester.RandomData.Of(System.String[])
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 85
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
       cmp       dword ptr [7FFE383042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3872BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3874C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE384675D0]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3875C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       cmp       dword ptr [7FFE38314D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       lea       rcx,[rbp-28]
       mov       edx,2
       mov       r8d,3
       call      qword ptr [7FFE381756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-28]
       mov       [rbp-30],rcx
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE384678E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE38175830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       rdx,1E05DE2FA48
       call      qword ptr [7FFE38175788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       [rbp-40],rcx
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE384678E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-48],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE38175830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       rdx,1E05DE20C48
       call      qword ptr [7FFE38175788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rax,[rbp-28]
       mov       [rbp-50],rax
       call      qword ptr [7FFE384675B8]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       call      qword ptr [7FFE38175830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE38175740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 300
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
       cmp       dword ptr [7FFE383142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38344B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3873BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+118]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L05
       mov       rbp,2C17DEB4244
       mov       rcx,rbp
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0D
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE38327A20]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L05
       add       rsi,0C
       lea       ecx,[rdi-1]
       cmp       ecx,edi
       jae       near ptr M00_L06
       movzx     ecx,word ptr [rsi+rcx*2]
       cmp       ecx,5C
       je        short M00_L00
       cmp       ecx,2F
       je        short M00_L00
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       mov       ecx,1
M00_L01:
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,2C17DEA8854
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       dword ptr [rsp+30],0D
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FFE38036B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       mov       [rsp+38],rbp
       mov       dword ptr [rsp+40],0D
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFE38036B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFE384475E8]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE3873C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,1B46F
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE381F66E8]
       int       3
M00_L05:
       mov       rcx,2C17DEB4238
       jmp       short M00_L03
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       edx,ecx
       test      edx,edx
       jle       short M01_L00
       movzx     edx,word ptr [rax]
       cmp       edx,5C
       je        short M01_L02
       cmp       edx,2F
       je        short M01_L02
M01_L00:
       cmp       ecx,2
       jl        short M01_L01
       movzx     ecx,word ptr [rax]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       ja        short M01_L01
       cmp       word ptr [rax+2],3A
       sete      al
       movzx     eax,al
       ret
M01_L01:
       xor       eax,eax
       ret
M01_L02:
       mov       eax,1
       ret
; Total bytes of code 65
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[r8]
       mov       esi,[r8+8]
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       ecx,r15d
       add       ecx,ebp
       jo        near ptr M02_L00
       add       ecx,esi
       jo        near ptr M02_L00
       test      ecx,ecx
       je        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       r15d,eax
       ja        near ptr M02_L02
       mov       r8d,r15d
       add       r8,r8
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r15d
       lea       r12,[r12+r8*2]
       mov       r14d,[rsp+24]
       sub       r14d,r15d
       cmp       ebp,r14d
       ja        short M02_L02
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       mov       rax,2C17DEA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       call      qword ptr [7FFE381CE9B8]
       int       3
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE382F4D38],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       mov       rcx,2C17DEB4268
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C17DEA0008
       call      qword ptr [7FFE3847E460]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       mov       edx,1
       call      qword ptr [7FFE380E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,2C17DEA0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2C17DEB4290
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3847E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FFE384474B0]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       nop
       mov       rax,[rbp+10]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 214
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
       cmp       dword ptr [7FFE382F42F8],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871CEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3873DB00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FFE38446EB0]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38737A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE382F5000],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,28087DE96C8
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,28087DE0008
       call      qword ptr [7FFE3847E040]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+10],rcx
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,1
       call      qword ptr [7FFE380E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,28087DE0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,28087DE43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3847DE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE380E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,28087DE0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,1
       mov       r8,28087DF4238
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3847DE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-4C],eax
       mov       ecx,[rbp-4C]
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE384459E0]; System.IO.Directory.CreateDirectory(System.String)
       mov       [rbp-58],rax
       nop
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+18]
       call      qword ptr [7FFE380EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-60]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp+10]
       mov       edx,0A
       mov       r8,28087DF4268
       call      qword ptr [7FFE38447030]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       edx,[rbp+20]
       call      qword ptr [7FFE38446D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       nop
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38106D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-0C],ecx
M01_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       jne       short M01_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 515
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
       cmp       dword ptr [7FFE382F45C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871D0B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3873CDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE38477648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3876C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-14],xmm4
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-30],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE38324D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       edx,[rbp+10]
       add       edx,1
       jno       short M01_L01
       call      CORINFO_HELP_OVERFLOW
M01_L01:
       mov       ecx,[rbp+18]
       call      qword ptr [7FFE386C7B58]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-18],eax
       mov       edx,[rbp-18]
       mov       [rbp+18],edx
       mov       rdx,1BE49404AC8
       mov       rdx,[rdx]
       mov       [rbp-8],rdx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE3806E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       mov       ecx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FFE384A6790]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       [rbp-14],ecx
       nop
       mov       rcx,rsp
       call      M01_L02
       nop
       mov       eax,[rbp-14]
       add       rsp,50
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L03
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE383242F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38354B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3876C990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38446EF8]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38737A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE382F4770],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FFE3869F5B8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 52
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
       cmp       dword ptr [7FFE382F3D30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38737AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE38477690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3876C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-80],rsp
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE38324D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FFE38114780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,1C2CE130008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1C2CE139A90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE384AE268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,18240004AC0
       mov       rcx,[rcx]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-70]
       mov       rax,[rbp-70]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rdx,[rbp-40]
       mov       [rbp-8],rdx
       nop
       mov       rdx,18240004AC8
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       xor       edx,edx
       mov       [rbp-18],edx
       lea       rdx,[rbp-18]
       mov       rcx,[rbp-10]
       call      qword ptr [7FFE3806E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       edx,9
       call      qword ptr [7FFE384A6790]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rbp-4C],eax
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3829C450]; System.Text.StringBuilder.Append(Int32)
       mov       [rbp-58],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-1C],ecx
M01_L04:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       short M01_L02
       nop
       nop
       mov       rcx,rsp
       call      M01_L05
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FFE384773D8]; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-28],rcx
       nop
       mov       rcx,rsp
       call      M01_L07
       nop
       mov       rax,[rbp-28]
       add       rsp,0B0
       pop       rbp
       ret
M01_L05:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0B0]
       mov       ecx,[rbp-18]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L06
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
M01_L06:
       nop
       add       rsp,40
       pop       rbp
       ret
M01_L07:
       push      rbp
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,18240004AC0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 543
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
       cmp       dword ptr [7FFE383242F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38354B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3874BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3876C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE3843C348]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3872C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       push      rbp
       sub       rsp,100
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE382E4D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FFE380D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,239366E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,239366EF2E8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3846E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,239366E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,239366EF318
       mov       r9d,64
       call      qword ptr [7FFE3846E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,239366E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,239366EF348
       mov       r9d,32
       call      qword ptr [7FFE3846E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FFE384377C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38693268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE3843C708]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CC30]; DotNetTips.Spargine.Tester.PersonData.get_Country()
       mov       [rbp-60],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38693998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FFE3868D188]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CBD0]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C50]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CC00]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C60]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CC60]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CC90]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C80]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FFE38437660]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450C90]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CCC0]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450CA0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3868CCF0]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38450CB0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       nop
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,100
       pop       rbp
       ret
; Total bytes of code 875
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
       cmp       dword ptr [7FFE382E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38314B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3870BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3872C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateValPerson()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       lea       rcx,[rsp+68]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE3846CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+68]
       mov       ecx,9
       rep movsq
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE3875C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,1E0
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE38314D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-100],rcx
       lea       rcx,[rbp-100]
       mov       edx,2
       call      qword ptr [7FFE38104780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-100]
       mov       [rsp+20],rcx
       mov       rcx,1932C4C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,1932C4CF2E8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3849E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-104],eax
       mov       ecx,[rbp-104]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       rcx,1932C4C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,1932C4CF318
       mov       r9d,64
       call      qword ptr [7FFE3849E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-108],eax
       mov       ecx,[rbp-108]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       rcx,1932C4C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,1932C4CF348
       mov       r9d,32
       call      qword ptr [7FFE3849E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-10C],eax
       mov       eax,[rbp-10C]
       mov       [rbp+28],eax
       call      qword ptr [7FFE384677C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       [rbp-118],rax
       mov       rcx,[rbp-118]
       mov       [rbp-18],rcx
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFE38344588]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]..ctor()
       lea       rcx,[rbp-0B0]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCC30]; DotNetTips.Spargine.Tester.PersonData.get_Country()
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       edx,[rbp+18]
       mov       r8d,[rbp+20]
       mov       r9d,[rbp+28]
       call      qword ptr [7FFE386E6190]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-130],rax
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFE383447F8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Addresses(System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       lea       rdx,[rbp-0B0]
       mov       [rbp-138],rdx
       lea       rdx,[rbp-148]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCBD0]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-138]
       mov       [rbp-1C0],rcx
       vmovups   xmm0,[rbp-148]
       vmovups   [rbp-1B8],xmm0
       mov       rcx,[rbp-1C0]
       lea       rdx,[rbp-1B8]
       call      qword ptr [7FFE383448A0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_BornOn(System.DateTimeOffset)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCC00]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-158],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-158]
       call      qword ptr [7FFE38344900]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_CellPhone(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-160],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCC60]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-168],rax
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-168]
       call      qword ptr [7FFE38344960]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Email(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCC90]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-178],rax
       mov       rcx,[rbp-170]
       mov       rdx,[rbp-178]
       call      qword ptr [7FFE383449C0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_FirstName(System.String)
       nop
       lea       rax,[rbp-0B0]
       mov       [rbp-180],rax
       call      qword ptr [7FFE38467660]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-188],rax
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-188]
       call      qword ptr [7FFE38344A38]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Id(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCCC0]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-198],rax
       mov       rcx,[rbp-190]
       mov       rdx,[rbp-198]
       call      qword ptr [7FFE38344A98]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_LastName(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BCCF0]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A0]
       mov       rdx,[rbp-1A8]
       call      qword ptr [7FFE38344AF8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Phone(System.String)
       nop
       lea       rdi,[rbp-60]
       lea       rsi,[rbp-0B0]
       mov       ecx,9
       rep movsq
       lea       rdi,[rbp-0F8]
       lea       rsi,[rbp-60]
       mov       ecx,9
       rep movsq
       nop
       mov       rdi,[rbp+10]
       lea       rsi,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rbp+10]
       add       rsp,1E0
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 959
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38344B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875C840]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 78
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,0EB
       xor       edx,edx
       call      qword ptr [7FFE38477768]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3876C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
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
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE38324D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       ecx,[rbp+10]
       mov       rdx,28A47B80008
       mov       r8,28A47B94238
       call      qword ptr [7FFE3876C9A8]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Tester.Data.CountryName, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.CountryName, System.String, System.String)
       mov       [rbp-14],eax
       mov       ecx,[rbp-14]
       mov       [rbp+10],ecx
       mov       ecx,[rbp+10]
       call      qword ptr [7FFE384A5740]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384A5D88]; DotNetTips.Spargine.Tester.Data.Country.get_PhoneNumberLength()
       mov       [rbp-4C],eax
       mov       ecx,[rbp-4C]
       call      qword ptr [7FFE38477690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384A5D58]
       mov       [rbp-28],rax
       mov       rcx,28A47B80C30
       mov       [rbp-30],rcx
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384A5D88]; DotNetTips.Spargine.Tester.Data.Country.get_PhoneNumberLength()
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE38477690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE38066B20]; System.String.Concat(System.String, System.String, System.String)
       mov       [rbp-48],rax
M01_L02:
       mov       rax,[rbp-48]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 281
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
       cmp       dword ptr [7FFE383242F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38354B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3874CD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3876CB40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,0A
       mov       r8,23F2EEA4238
       call      qword ptr [7FFE38447030]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38737DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE382F4770],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rsp+20],rcx
       mov       rcx,23F2EE90008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,23F2EEA4270
       mov       r9d,100
       call      qword ptr [7FFE3847DE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+18],ecx
       mov       rcx,23F2EEA42A8
       mov       [rsp+20],rcx
       mov       rcx,[rbp+20]
       mov       edx,1
       mov       r8,23F2EEA4238
       mov       r9,23F2EE90008
       call      qword ptr [7FFE3847E040]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       lea       rcx,[rbp-38]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE381556B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-38]
       mov       [rbp-58],rcx
       mov       ecx,[rbp+18]
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE38447168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       [rbp-60],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE38155830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-38]
       mov       edx,2E
       call      qword ptr [7FFE38737DF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFE38155830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE38155740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFE38327108]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       mov       [rbp-40],rax
       nop
       mov       rax,[rbp-40]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 373
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
       cmp       dword ptr [7FFE382F3D30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871BDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38737E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE384677F8]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3875C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       cmp       dword ptr [7FFE38314D38],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,2AFF5802AC8
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       call      qword ptr [7FFE38467840]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3828C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-0C],ecx
M01_L04:
       mov       ecx,[rbp-0C]
       mov       [rbp-24],ecx
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE38467648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-28],eax
       mov       eax,[rbp-24]
       cmp       eax,[rbp-28]
       setl      al
       movzx     eax,al
       mov       [rbp-10],eax
       cmp       dword ptr [rbp-10],0
       jne       short M01_L02
       mov       rcx,[rbp-8]
       mov       edx,2F
       cmp       [rcx],ecx
       call      qword ptr [7FFE3828C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L05
       nop
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L05:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,2AFF5802AC8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 383
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
       cmp       dword ptr [7FFE383142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38344B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3873BD60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFE384370A8]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38727A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE382E4D70],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,400
       call      qword ptr [7FFE380D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,25BBD010008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,25BBD024238
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3846DE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       ecx,0A
       mov       rdx,25BBD024268
       call      qword ptr [7FFE38437018]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FFE38437138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFE38386FA0]; System.IO.File.WriteAllText(System.String, System.String)
       nop
       mov       rax,[rbp-8]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 225
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
       cmp       dword ptr [7FFE382E4330],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38314588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3870C508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3872C2D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38447828]; DotNetTips.Spargine.Tester.RandomData.GenerateUrl()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3873C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrl()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE382F4D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FFE38447858]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       [rbp-10],rax
       call      qword ptr [7FFE384477F8]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFE38036B08]; System.String.Concat(System.String, System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 89
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
       cmp       dword ptr [7FFE382F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871BEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3873C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlFragment()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38457840]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3874C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE38304D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,253E41C6680
       mov       [rbp-10],rcx
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE384578E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFE38046B08]; System.String.Concat(System.String, System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 115
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
       cmp       dword ptr [7FFE383042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3872BC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3874C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38457858]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3874C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE38304D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,1C3CB7E4238
       mov       [rbp-10],rax
       call      qword ptr [7FFE38457870]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFE38046B08]; System.String.Concat(System.String, System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 93
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
       cmp       dword ptr [7FFE383042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3872BCD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3874C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38467870]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3875C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE38314D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,21411904238
       mov       [rbp-10],rcx
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE384678E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-18],rax
       mov       rax,214118F0C48
       mov       [rbp-20],rax
       call      qword ptr [7FFE38467888]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       [rbp-28],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-20]
       mov       r9,[rbp-28]
       call      qword ptr [7FFE38056B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 152
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
       cmp       dword ptr [7FFE383142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38344B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3873BC70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE38457888]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3874C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FFE38304D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FFE384575B8]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 52
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
       cmp       dword ptr [7FFE383042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38334B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3872BC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3874C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE384478A0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3873C828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE382F4D38],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       mov       edx,1
       call      qword ptr [7FFE380E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,2EBC0280008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2EBC0289A90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE3847E268]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       [rbp+10],ecx
       mov       ecx,[rbp+10]
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE384478D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 183
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
       cmp       dword ptr [7FFE382F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38324B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3871BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3873C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      qword ptr [7FFE38477198]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38767A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE38324770],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE38114780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,2EDEA240008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,2EDEA2443B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE384ADE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FFE38114780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,2EDEA240008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2EDEA24FA90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE384ADE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFE38114780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rsp+20],rcx
       mov       rcx,2EDEA240008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,1
       mov       r8,2EDEA24FAB8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE384ADE48]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+10]
       call      qword ptr [7FFE3811DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-50]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-58],rcx
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       call      qword ptr [7FFE38477150]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       [rbp-60],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38136D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-0C],ecx
M01_L04:
       mov       ecx,[rbp-0C]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M01_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3811E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 502
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
       cmp       dword ptr [7FFE38323D30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38354588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3874BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38767AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

