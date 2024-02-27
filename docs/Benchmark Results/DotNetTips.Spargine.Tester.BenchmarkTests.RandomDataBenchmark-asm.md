## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [7FF86CE1A1E8]
       call      qword ptr [7FF86CA47B10]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD0EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       vmovsd    xmm0,qword ptr [rbp+10]
       vmovsd    qword ptr [rbp-30],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF86C67B1F0]
       setae     al
       mov       [rbp-34],eax
       xor       eax,eax
       mov       [rbp-40],rax
       call      qword ptr [7FF86C764270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-48],rax
       call      qword ptr [7FF86CA768F8]; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp-50],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       r8,[rbp-58]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp-58]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       call      qword ptr [7FF86C626C28]; System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp-60],rax
       mov       rdx,2651FC74238
       mov       [rsp+20],rdx
       vmovsd    xmm0,qword ptr [rbp-30]
       mov       edx,[rbp-34]
       vmovsd    xmm2,qword ptr [rbp-40]
       mov       r9,[rbp-60]
       call      qword ptr [7FF86CD0EC58]; DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp-68],xmm0
       vmovsd    xmm0,qword ptr [rbp-68]
       vmovsd    qword ptr [rbp+10],xmm0
       mov       rdx,2248DC04AC8
       mov       rdx,[rdx]
       mov       [rbp-8],rdx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF86C62E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rax,[rax]
       mov       [rbp-70],rax
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FF86C67B1F8]
       call      qword ptr [7FF86C87F360]; System.Convert.ToInt32(Double)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-80],rax
       lea       rcx,[rbp-90]
       mov       rdx,[rbp-80]
       call      qword ptr [7FF86C76E988]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
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
       vmulsd    xmm0,xmm0,qword ptr [7FF86C67B1F8]
       call      qword ptr [7FF86C87F360]; System.Convert.ToInt32(Double)
       mov       [rbp-94],eax
       mov       edx,[rbp-94]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       lea       rcx,[rbp-0B0]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF86C76E988]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-0B0]
       vmovdqu   xmmword ptr [rbp-20],xmm0
       lea       rcx,[rbp-20]
       call      qword ptr [7FF86C76EC28]; System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C905500]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CCFF440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD35338]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA46DA8]; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter()
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD36C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Char, System.Private.CoreLib]](Char)
; Total bytes of code 30
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FF86CA46DC0]; DotNetTips.Spargine.Tester.RandomData.GenerateCharacter(Char, Char)
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD36C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
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
       call      qword ptr [7FF86CA471C8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+38]
       mov       [rsp+28],ecx
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       call      qword ptr [7FF86CD36C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
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
       mov       rcx,7FF86C8F51E0
       mov       edx,5
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       lea       rcx,[rbp-20]
       call      qword ptr [7FF86CA74AF8]; System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rbp-20]
       mov       [rbp-10],rcx
       mov       ecx,[rbp-18]
       mov       [rbp-8],ecx
       lea       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FF86CA46EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-2C],eax
       mov       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FF86C8EF6D8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_X(Int32)
       nop
       lea       rcx,[rbp-10]
       mov       [rbp-38],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FF86CA46EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-3C],eax
       mov       rcx,[rbp-38]
       mov       edx,[rbp-3C]
       call      qword ptr [7FF86C8EF738]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_Y(Int32)
       nop
       lea       rcx,[rbp-10]
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FF86CA46EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-4C],eax
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       call      qword ptr [7FF86C8EF798]; DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate.set_Z(Int32)
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD36C40]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
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
       call      qword ptr [7FF86CA56E38]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovups   xmm0,[rsp+40]
       vmovups   [rsp+30],xmm0
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       call      qword ptr [7FF86CD469D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-28],rcx
       lea       rcx,[rbp-28]
       xor       edx,edx
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-28]
       mov       [rsp+20],rcx
       mov       rcx,2B4697E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       xor       edx,edx
       mov       r8,2B4697F4338
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+28],ecx
       lea       rcx,[rbp-40]
       mov       edx,[rbp+28]
       call      qword ptr [7FF86C764870]; System.Decimal.op_Implicit(Int32)
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-50],xmm0
       lea       rcx,[rbp-50]
       mov       edx,0A
       call      qword ptr [7FF86C764018]; System.Decimal..ctor(Int32)
       vmovups   xmm0,[rbp-40]
       vmovups   [rbp-0C0],xmm0
       vmovups   xmm0,[rbp-50]
       vmovups   [rbp-0D0],xmm0
       lea       rdx,[rbp-0C0]
       lea       r8,[rbp-0D0]
       lea       rcx,[rbp-60]
       call      qword ptr [7FF86C764A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
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
       call      qword ptr [7FF86C764A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-70]
       vmovups   [rbp-100],xmm0
       lea       rcx,[rbp-100]
       call      qword ptr [7FF86C764978]; System.Decimal.op_Explicit(System.Decimal)
       mov       [rbp-74],eax
       mov       rdx,[rbp+20]
       vmovups   xmm0,[rdx]
       vmovups   [rbp-110],xmm0
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-120],xmm0
       lea       rdx,[rbp-110]
       lea       r8,[rbp-120]
       lea       rcx,[rbp-88]
       call      qword ptr [7FF86C764A98]; System.Decimal.op_Multiply(System.Decimal, System.Decimal)
       vmovups   xmm0,[rbp-88]
       vmovups   [rbp-130],xmm0
       lea       rcx,[rbp-130]
       call      qword ptr [7FF86C764978]; System.Decimal.op_Explicit(System.Decimal)
       mov       [rbp-8C],eax
       mov       ecx,[rbp-74]
       mov       edx,[rbp-8C]
       call      qword ptr [7FF86CA56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbp-90],eax
       lea       rcx,[rbp-0A0]
       mov       edx,[rbp-90]
       call      qword ptr [7FF86C764870]; System.Decimal.op_Implicit(Int32)
       vmovups   xmm0,[rbp-0A0]
       vmovups   [rbp-140],xmm0
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-150],xmm0
       lea       rdx,[rbp-140]
       lea       r8,[rbp-150]
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FF86C764AB0]; System.Decimal.op_Division(System.Decimal, System.Decimal)
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD46EF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       call      qword ptr [7FF86CA66E50]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD56C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C914DA8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,1DEFC804AA0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C9F6EF8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF86CA66D30]; DotNetTips.Spargine.Tester.RandomData.Of(System.String[])
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
       cmp       dword ptr [7FF86C9142B0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD3BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD56C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA36E68]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD269D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       lea       rcx,[rbp-28]
       mov       edx,2
       mov       r8d,3
       call      qword ptr [7FF86C7456B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-28]
       mov       [rbp-30],rcx
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FF86CA37180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF86C745830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       rdx,2B64929FA48
       call      qword ptr [7FF86C745788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       [rbp-40],rcx
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FF86CA37180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-48],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF86C745830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       mov       rdx,2B649290C48
       call      qword ptr [7FF86C745788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rax,[rbp-28]
       mov       [rbp-50],rax
       call      qword ptr [7FF86CA36E50]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF86C745830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-28]
       call      qword ptr [7FF86C745740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD0BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD26A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L05
       mov       rbp,278E77F4244
       mov       rcx,rbp
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0D
       lea       rcx,[rsp+48]
       call      qword ptr [7FF86C9179D8]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,278E77E8854
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       dword ptr [rsp+30],0D
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FF86C626B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       mov       [rsp+38],rbp
       mov       dword ptr [rsp+40],0D
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FF86C626B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FF86CA36E80]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF86CD26C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,1B46F
       mov       rdx,7FF86C4D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF86C7E66E8]
       int       3
M00_L05:
       mov       rcx,278E77F4238
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
       call      qword ptr [7FF86C6D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF86C6D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FF86C6D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,278E77E0008
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
       call      qword ptr [7FF86C7BE9B8]
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
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       mov       rcx,278E77F4268
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,278E77E0008
       call      qword ptr [7FF86CA6D8A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       mov       edx,1
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,278E77E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,278E77F4290
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86CA36D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD0CEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD27F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+128]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FF86CA56EB0]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD46C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,2DBD42C96C8
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2DBD42C0008
       call      qword ptr [7FF86CA8D8A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+10],rcx
       xor       ecx,ecx
       mov       [rbp-38],rcx
       lea       rcx,[rbp-38]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-38]
       mov       [rsp+20],rcx
       mov       rcx,2DBD42C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,2DBD42C43B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-48]
       mov       [rsp+20],rcx
       mov       rcx,2DBD42C0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,1
       mov       r8,2DBD42D4238
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-4C],eax
       mov       ecx,[rbp-4C]
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86CA559E0]; System.IO.Directory.CreateDirectory(System.String)
       mov       [rbp-58],rax
       nop
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86C6FDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       r8,2DBD42D4268
       call      qword ptr [7FF86CA57030]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       edx,[rbp+20]
       call      qword ptr [7FF86CA56D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       nop
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C716D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       call      qword ptr [7FF86C6FE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD2D0B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD47F60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD469D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       ecx,[rbp+10]
       mov       edx,1
       call      qword ptr [7FF86CCA5CE0]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-18],eax
       mov       edx,[rbp-18]
       mov       [rbp+10],edx
       mov       edx,[rbp+10]
       add       edx,1
       jno       short M01_L01
       call      CORINFO_HELP_OVERFLOW
M01_L01:
       mov       ecx,[rbp+18]
       call      qword ptr [7FF86CCA5CE0]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-1C],eax
       mov       edx,[rbp-1C]
       mov       [rbp+18],edx
       mov       rdx,19313804AC8
       mov       rdx,[rdx]
       mov       [rbp-8],rdx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF86C64E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       mov       ecx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF86CA85BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rbp-20],eax
       mov       ecx,[rbp-20]
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
; Total bytes of code 226
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD469E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       call      qword ptr [7FF86CA56EF8]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD469D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FF86CCADF38]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD2BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD46A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA46F28]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD36C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,160A1AB0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,160A1AB9A90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,1200FC04AC0
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
       mov       rdx,1200FC04AC8
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       xor       edx,edx
       mov       [rbp-18],edx
       lea       rdx,[rbp-18]
       mov       rcx,[rbp-10]
       call      qword ptr [7FF86C63E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF86CA75BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rbp-4C],eax
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C86C450]; System.Text.StringBuilder.Append(Int32)
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
       call      qword ptr [7FF86CA46C70]; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
       mov       rcx,1200FC04AC0
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD1BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD36C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA37888]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD26C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8E4E90],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,24C5FCC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,24C5FCCF2E8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,24C5FCC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,24C5FCCF318
       mov       r9d,64
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,24C5FCC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,24C5FCCF348
       mov       r9d,32
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FF86CA37060]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
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
       mov       rdx,7FF86CC93270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF86CA37C48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86DA8]; DotNetTips.Spargine.Tester.PersonData.get_Country()
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
       mov       rdx,7FF86CC939A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FF86CC87300]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A20]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86D48]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A30]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86D78]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86DD8]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A50]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E08]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A60]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FF86CA36EF8]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E38]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A80]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E68]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA50A90]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       cmp       dword ptr [7FF86C8E4398],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD0BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD26C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA3C150]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+68]
       mov       ecx,9
       rep movsq
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       call      qword ptr [7FF86CD26C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
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
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-100],rcx
       lea       rcx,[rbp-100]
       mov       edx,2
       call      qword ptr [7FF86C6D4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-100]
       mov       [rsp+20],rcx
       mov       rcx,1E1FC110008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,1E1FC11F2E8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-104],eax
       mov       ecx,[rbp-104]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       rcx,1E1FC110008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,1E1FC11F318
       mov       r9d,64
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-108],eax
       mov       ecx,[rbp-108]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       rcx,1E1FC110008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,1E1FC11F348
       mov       r9d,32
       call      qword ptr [7FF86CA6D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-10C],eax
       mov       eax,[rbp-10C]
       mov       [rbp+28],eax
       call      qword ptr [7FF86CA37060]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       [rbp-118],rax
       mov       rcx,[rbp-118]
       mov       [rbp-18],rcx
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FF86C914510]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]..ctor()
       lea       rcx,[rbp-0B0]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86DA8]; DotNetTips.Spargine.Tester.PersonData.get_Country()
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       edx,[rbp+18]
       mov       r8d,[rbp+20]
       mov       r9d,[rbp+28]
       call      qword ptr [7FF86CCB4570]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-130],rax
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       call      qword ptr [7FF86C914720]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Addresses(System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       nop
       lea       rdx,[rbp-0B0]
       mov       [rbp-138],rdx
       lea       rdx,[rbp-148]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86D48]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-138]
       mov       [rbp-1C0],rcx
       vmovups   xmm0,[rbp-148]
       vmovups   [rbp-1B8],xmm0
       mov       rcx,[rbp-1C0]
       lea       rdx,[rbp-1B8]
       call      qword ptr [7FF86C9147C8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_BornOn(System.DateTimeOffset)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86D78]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-158],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-158]
       call      qword ptr [7FF86C914828]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_CellPhone(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-160],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86DD8]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-168],rax
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-168]
       call      qword ptr [7FF86C914888]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Email(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E08]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-178],rax
       mov       rcx,[rbp-170]
       mov       rdx,[rbp-178]
       call      qword ptr [7FF86C9148E8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_FirstName(System.String)
       nop
       lea       rax,[rbp-0B0]
       mov       [rbp-180],rax
       call      qword ptr [7FF86CA36EF8]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-188],rax
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-188]
       call      qword ptr [7FF86C914960]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Id(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E38]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-198],rax
       mov       rcx,[rbp-190]
       mov       rdx,[rbp-198]
       call      qword ptr [7FF86C9149C0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_LastName(System.String)
       nop
       lea       rcx,[rbp-0B0]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CC86E68]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A0]
       mov       rdx,[rbp-1A8]
       call      qword ptr [7FF86C914A20]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Phone(System.String)
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD26C40]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
       call      qword ptr [7FF86CA27000]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD169D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       ecx,[rbp+10]
       mov       rdx,2837BE60008
       mov       r8,2837BE74238
       call      qword ptr [7FF86CD16A00]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Tester.Data.CountryName, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.CountryName, System.String, System.String)
       mov       [rbp-14],eax
       mov       ecx,[rbp-14]
       mov       [rbp+10],ecx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA54B70]; DotNetTips.Spargine.Tester.Data.Countries.GetCountry(DotNetTips.Spargine.Tester.Data.CountryName)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA551B8]; DotNetTips.Spargine.Tester.Data.Country.get_PhoneNumberLength()
       mov       [rbp-4C],eax
       mov       ecx,[rbp-4C]
       call      qword ptr [7FF86CA26F28]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA55188]
       mov       [rbp-28],rax
       mov       rcx,2837BE60C30
       mov       [rbp-30],rcx
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CA551B8]; DotNetTips.Spargine.Tester.Data.Country.get_PhoneNumberLength()
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       call      qword ptr [7FF86CA26F28]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-40]
       call      qword ptr [7FF86C616B20]; System.String.Concat(System.String, System.String, System.String)
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CCFCD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD16B98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+128]
       mov       edx,0A
       mov       r8,1FD15154238
       call      qword ptr [7FF86CA57030]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD46C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rsp+20],rcx
       mov       rcx,1FD15140008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1FD15154270
       mov       r9d,100
       call      qword ptr [7FF86CA8D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+18],ecx
       mov       rcx,1FD151542A8
       mov       [rsp+20],rcx
       mov       rcx,[rbp+20]
       mov       edx,1
       mov       r8,1FD15154238
       mov       r9,1FD15140008
       call      qword ptr [7FF86CA8D8A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       lea       rcx,[rbp-38]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FF86C7656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-38]
       mov       [rbp-58],rcx
       mov       ecx,[rbp+18]
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FF86CA57168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       [rbp-60],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-60]
       call      qword ptr [7FF86C765830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-38]
       mov       edx,2E
       call      qword ptr [7FF86CD46C58]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF86C765830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-38]
       call      qword ptr [7FF86C765740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FF86C937648]; System.IO.Path.Combine(System.String, System.String)
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD2BDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD46C70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA27090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD169D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,2A28B804AC0
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
       call      qword ptr [7FF86CA27120]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C84C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF86CA26EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FF86C84C3D8]; System.Text.StringBuilder.Append(Char)
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
       mov       rcx,2A28B804AC0
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CCFBD60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD16A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA670A8]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD56C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C914DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,400
       call      qword ptr [7FF86C704780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,228264E0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,228264F4238
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA9D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       ecx,0A
       mov       rdx,228264F4268
       call      qword ptr [7FF86CA67018]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       mov       ecx,[rbp+10]
       call      qword ptr [7FF86CA67138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF86C9B6FA0]; System.IO.File.WriteAllText(System.String, System.String)
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD3C508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD57438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA470C0]; DotNetTips.Spargine.Tester.RandomData.GenerateUrl()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD36C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FF86CA470D8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       [rbp-10],rax
       call      qword ptr [7FF86CA47090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF86C636B08]; System.String.Concat(System.String, System.String)
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD1BEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD36C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA370D8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD269D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,25B240F4238
       mov       [rbp-10],rax
       call      qword ptr [7FF86CA370F0]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF86C626B08]; System.String.Concat(System.String, System.String)
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD0BCD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD26A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA670F0]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD56C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C914DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,249D2354238
       mov       [rbp-10],rcx
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FF86CA67180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-18],rax
       mov       rax,249D2340C48
       mov       [rbp-20],rax
       call      qword ptr [7FF86CA67108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       [rbp-28],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-20]
       mov       r9,[rbp-28]
       call      qword ptr [7FF86C656B38]; System.String.Concat(System.String, System.String, System.String, System.String)
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
       cmp       dword ptr [7FF86C9142F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C944A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD3BC70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD56C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA27108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD1C978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8D4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       call      qword ptr [7FF86CA26E50]; DotNetTips.Spargine.Tester.RandomData.GenerateDomainExtension()
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
       cmp       dword ptr [7FF86C8D42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C904A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CCFFF48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD1C9A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlPart()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF86CA37120]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD26C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FF86C8E4DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,25E8E336680
       mov       [rbp-10],rcx
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FF86CA37180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF86C626B08]; System.String.Concat(System.String, System.String)
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
       cmp       dword ptr [7FF86C8E42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C914A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD0BC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD26C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA57138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD469D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C904DF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       mov       edx,1
       call      qword ptr [7FF86C6F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       [rsp+20],rcx
       mov       rcx,1C68D740008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1C68D749A90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA8D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       [rbp+10],ecx
       mov       ecx,[rbp+10]
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF86CA57168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       cmp       dword ptr [7FF86C9042F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C934A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD2BBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD46A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86CA47198]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86CD36C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF86C8F4DF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,1A8F7B50008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,1A8F7B543B0
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,1A8F7B50008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r8,1A8F7B5FA90
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C6E4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-40]
       mov       [rsp+20],rcx
       mov       rcx,1A8F7B50008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,1
       mov       r8,1A8F7B5FAB8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF86CA7D6B0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,[rbp+10]
       call      qword ptr [7FF86C6EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       call      qword ptr [7FF86CA47150]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       [rbp-60],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C706D40]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       call      qword ptr [7FF86C6EE178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
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
       cmp       dword ptr [7FF86C8F42F8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C924A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF86CD1BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86CD36C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

