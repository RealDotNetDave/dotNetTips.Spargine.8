## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [7FFE71259AD8]
       call      qword ptr [7FFE70E87B10]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       vmovaps   [rsp+0C0],xmm6
       lea       rbp,[rsp+110]
       xor       ecx,ecx
       mov       [rbp-88],rcx
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-0F0],rsp
       vmovaps   xmm6,xmm0
       lea       rcx,[rbp-0D8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rax,rsp
       mov       [rbp-0B8],rax
       mov       rax,rbp
       mov       [rbp-0A8],rax
       mov       rax,22098C00428
       mov       rsi,[rax]
       call      qword ptr [7FFE70EB66E8]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rdi,rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,22098C04AD8
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,2612AC84238
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       qword ptr [r14+8],1
       mov       [rbp-60],r14
       lea       rcx,[rbp-60]
       mov       [rbp-78],rcx
       mov       dword ptr [rbp-70],1
       mov       rcx,rsi
       lea       r8,[rbp-78]
       call      qword ptr [7FFE70A66C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       xor       edx,edx
       vucomisd  xmm6,qword ptr [7FFE71259E50]
       setae     dl
       test      edx,edx
       je        near ptr M01_L12
M01_L00:
       mov       rdx,22098C04AC8
       mov       rax,[rdx]
       mov       [rbp-98],rax
       xor       edx,edx
       mov       [rbp-58],edx
       cmp       byte ptr [rbp-58],0
       jne       near ptr M01_L07
       lea       rdx,[rbp-58]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],2
       jl        near ptr M01_L06
       mov       rax,[rax+198]
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M01_L06
       mov       rax,[rax]
       add       rax,10
M01_L01:
       mov       rsi,[rax]
       vmulsd    xmm0,xmm6,qword ptr [7FFE71259E58]
       vmovsd    qword ptr [rbp-90],xmm0
       call      qword ptr [7FFE70CBF360]; System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rdi,offset MT_System.Byte[]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
       mov       rcx,offset MT_System.Security.Cryptography.RandomNumberGeneratorImplementation
       cmp       [rsi],rcx
       jne       near ptr M01_L08
       test      r8d,r8d
       jle       short M01_L04
       mov       [rbp-68],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0C8],rax
       lea       rax,[M01_L02]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFF033333A0
       call      rax
M01_L02:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFED091505C],0
       je        short M01_L03
       call      qword ptr [7FFED0905398]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-0D0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       short M01_L05
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L04:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       jmp       short M01_L09
M01_L05:
       mov       ecx,eax
       call      qword ptr [7FFE7109F138]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE70A6E040]
       int       3
M01_L08:
       mov       rcx,rsi
       mov       [rbp-88],rdx
       mov       [rbp-80],r8d
       lea       rdx,[rbp-88]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       nop
M01_L09:
       cmp       byte ptr [rbp-58],0
       je        short M01_L10
       mov       rcx,[rbp-98]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L10:
       vmovsd    xmm0,qword ptr [rbp-90]
       call      qword ptr [7FFE70CBF360]; System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rbx,[rax+10]
       mov       esi,[rax+8]
       test      esi,esi
       je        short M01_L13
       movsxd    rdx,esi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       mov       rdx,rbx
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
M01_L11:
       vmovaps   xmm6,[rsp+0C0]
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       vxorps    xmm6,xmm6,xmm6
       jmp       near ptr M01_L00
M01_L13:
       mov       rax,2612AC771D8
       jmp       short M01_L11
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+110]
       cmp       byte ptr [rbp-58],0
       je        short M01_L14
       mov       rcx,[rbp-98]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L14:
       nop
       vmovaps   xmm6,[rsp+30]
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
; Total bytes of code 841
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FFE70E66EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+18]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,1B351404AC8
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE70A5E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE70E95BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
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
       call      qword ptr [7FFE70E971C8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+38]
       mov       [rsp+28],ecx
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE71186A18]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       nop
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE70E96EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       esi,eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE70E96EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edi,eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE70E96EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbx],esi
       mov       [rbx+4],edi
       mov       [rbx+8],eax
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
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
       lea       rcx,[rsp+50]
       mov       r9d,2
       call      qword ptr [7FFE70E86E38]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovups   xmm0,[rsp+50]
       vmovups   [rsp+40],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE71177180]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,60
       pop       rbx
       ret
; Total bytes of code 115
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       vzeroupper
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       byte ptr [rsp+0B0],1
       xor       ecx,ecx
       mov       [rsp+0B4],ecx
       mov       ecx,r9d
       not       ecx
       shr       ecx,1F
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L04
M01_L00:
       test      eax,eax
       je        near ptr M01_L05
M01_L01:
       test      r9d,r9d
       jl        near ptr M01_L06
       xor       ebp,ebp
M01_L02:
       mov       ecx,r9d
       mov       [rsp+0A0],ebp
       xor       edx,edx
       mov       [rsp+0A4],edx
       mov       [rsp+0A8],rcx
       mov       [rsp+90],edx
       mov       [rsp+94],edx
       mov       qword ptr [rsp+98],0A
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+90]
       call      qword ptr [7FFE71176F58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ebp,[rsp+0A0]
       mov       r14d,[rsp+0A4]
       mov       r15,[rsp+0A8]
       vmovups   xmm0,[rbx]
       vmovups   [rsp+80],xmm0
       mov       [rsp+70],ebp
       mov       [rsp+74],r14d
       mov       [rsp+78],r15
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+70]
       call      qword ptr [7FFE71176F58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+80]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE70B94738]; System.Decimal.ToInt32(System.Decimal)
       mov       ebx,eax
       vmovups   xmm0,[rsi]
       vmovups   [rsp+60],xmm0
       mov       [rsp+50],ebp
       mov       [rsp+54],r14d
       mov       [rsp+58],r15
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       call      qword ptr [7FFE71176F58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+60]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE70B94738]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,eax
       mov       ecx,ebx
       call      qword ptr [7FFE70E86EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jl        near ptr M01_L07
       xor       ebx,ebx
M01_L03:
       mov       ecx,eax
       mov       [rsp+40],ebx
       xor       edx,edx
       mov       [rsp+44],edx
       mov       [rsp+48],rcx
       mov       [rsp+30],ebp
       mov       [rsp+34],r14d
       mov       [rsp+38],r15
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE71176FE8]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+40]
       vmovups   [rdi],xmm0
       mov       rax,rdi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       cmp       byte ptr [rsp+0B0],0
       je        near ptr M01_L00
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFE70B247B0]
       mov       r9d,eax
       jmp       near ptr M01_L01
M01_L05:
       call      qword ptr [7FFE70EBDF68]
       mov       rbx,rax
       mov       rcx,22FD06242C0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ebp,80000000
       neg       r9d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebx,80000000
       neg       eax
       jmp       near ptr M01_L03
; Total bytes of code 562
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,20803004AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFE70E66EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      qword ptr [7FFE70DF6E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,20803004AC8
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE70A5E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE70E95BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
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
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
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
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
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
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
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
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
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
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
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
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1578
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E76E68]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,1208B801DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE70D214A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       rbx,[rax+10]
       mov       esi,[rax+8]
M01_L00:
       mov       [rsp+38],rbx
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E77180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L09
       test      rdi,rdi
       je        near ptr M01_L09
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L09
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L01:
       mov       ecx,[rsp+30]
       mov       edx,[rsp+40]
       cmp       ecx,edx
       ja        near ptr M01_L14
       mov       r8,[rsp+38]
       mov       r9d,ecx
       lea       r8,[r8+r9*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L10
       mov       rcx,1611D76FA2C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       mov       ecx,[rsp+30]
       inc       ecx
       mov       [rsp+30],ecx
M01_L02:
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E77180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbp,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L11
       test      rbp,rbp
       je        near ptr M01_L11
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M01_L11
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+30]
       add       edx,[rbp+8]
       mov       [rsp+30],edx
M01_L03:
       mov       edx,[rsp+30]
       mov       ecx,[rsp+40]
       cmp       edx,ecx
       ja        near ptr M01_L14
       mov       rax,[rsp+38]
       mov       r8d,edx
       lea       rax,[rax+r8*2]
       sub       ecx,edx
       cmp       ecx,1
       jb        near ptr M01_L12
       mov       rdx,1611D760C54
       movzx     ecx,word ptr [rdx]
       mov       [rax],cx
       mov       edx,[rsp+30]
       inc       edx
       mov       [rsp+30],edx
M01_L04:
       mov       rdx,1208B804AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L13
       mov       r14,[rcx+18]
M01_L05:
       mov       edx,[r14+8]
       sub       edx,1
       jo        near ptr M01_L07
       xor       ecx,ecx
       call      qword ptr [7FFE70E76EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M01_L16
       mov       r8d,eax
       mov       r15,[r14+r8*8+10]
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L15
       test      r15,r15
       je        near ptr M01_L15
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L15
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[r15+8]
       mov       [rsp+30],ecx
M01_L06:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE70B85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M01_L00
M01_L09:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFE70B85848]
       jmp       near ptr M01_L01
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,1611D76FA20
       call      qword ptr [7FFE70B858F0]
       jmp       near ptr M01_L02
M01_L11:
       lea       rcx,[rsp+20]
       mov       rdx,rbp
       call      qword ptr [7FFE70B85848]
       jmp       near ptr M01_L03
M01_L12:
       lea       rcx,[rsp+20]
       mov       rdx,1611D760C48
       call      qword ptr [7FFE70B858F0]
       jmp       near ptr M01_L04
M01_L13:
       call      qword ptr [7FFE70E06E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M01_L15:
       lea       rcx,[rsp+20]
       mov       rdx,r15
       call      qword ptr [7FFE70B85848]
       jmp       near ptr M01_L06
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 813
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+118]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L05
       mov       rbp,2CDA28C421C
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE70D67948]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,2CDA28B8854
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE70A76B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE70A76B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFE70E86E80]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,1B46F
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C366E8]
       int       3
M00_L05:
       mov       rcx,2CDA28C4210
       jmp       short M00_L03
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CDA28B0008
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
       call      qword ptr [7FFE70C0E9B8]
       int       3
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M03_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M03_L01
       jmp       short M03_L01
M03_L00:
       xor       edx,edx
M03_L01:
       test      edx,edx
       je        short M03_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       edx,esi
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      edx,edx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L05
M03_L02:
       test      eax,eax
       je        near ptr M03_L06
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FFE70E86D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FFE70EBE0A0]
       mov       rbx,rax
       mov       ecx,3E3
       mov       rdx,7FFE70D34AA8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35700
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35700
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70EBD8A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDC98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L05:
       cmp       byte ptr [rsp+28],0
       je        near ptr M03_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B247B0]
       mov       edx,eax
       jmp       near ptr M03_L03
M03_L06:
       call      qword ptr [7FFE70EBDF68]
       mov       rbx,rax
       mov       rcx,2CDA28C4268
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 402
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FFE70E66EB0]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,108
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+0F0],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rbx+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rbx+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L30
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       near ptr M01_L20
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L31
M01_L03:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L62
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L21
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L31
M01_L04:
       mov       byte ptr [rsp+100],1
       mov       dword ptr [rsp+104],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L32
M01_L05:
       test      eax,eax
       je        near ptr M01_L33
M01_L06:
       mov       byte ptr [rsp+0F8],1
       mov       dword ptr [rsp+0FC],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L34
M01_L07:
       test      edx,edx
       je        near ptr M01_L35
M01_L08:
       test      rbx,rbx
       je        near ptr M01_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L36
       mov       rcx,rbx
       call      qword ptr [7FFE70D47888]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFE70DBD6C8]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],0FFFFFFFF
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rbx
       xor       ecx,ecx
       mov       [r14+18],rcx
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+54],1
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      esi,esi
       jl        near ptr M01_L37
       test      esi,esi
       je        near ptr M01_L38
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L09:
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L19
M01_L10:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   xmmword ptr [rsp+0E8],xmm0
       mov       r15d,0A
       mov       r13,22B8AD84240
       xor       ecx,ecx
       mov       [rsp+0D0],rcx
       mov       rcx,1EAF9001DD8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFE70D114A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0D8],rax
       test      rax,rax
       je        near ptr M01_L39
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L11:
       mov       [rsp+0E8],r10
       mov       [rsp+0F0],eax
       xor       ecx,ecx
       mov       [rsp+0E0],ecx
       mov       byte ptr [rsp+0E4],0
       mov       ecx,r15d
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE70E67168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+0E4],0
       jne       near ptr M01_L40
       test      rdx,rdx
       je        near ptr M01_L40
       mov       r8d,[rsp+0E0]
       cmp       r8d,[rsp+0F0]
       ja        near ptr M01_L26
       mov       rcx,[rsp+0E8]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+0F0]
       sub       eax,r8d
       mov       r15d,[rdx+8]
       cmp       r15d,eax
       ja        near ptr M01_L40
       add       rdx,0C
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rsp+0E0]
       mov       [rsp+0E0],r15d
M01_L12:
       lea       rcx,[rsp+0D0]
       mov       edx,2E
       call      qword ptr [7FFE71156C58]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+0E4],0
       jne       near ptr M01_L41
       test      r13,r13
       je        near ptr M01_L41
       mov       r8d,[rsp+0E0]
       cmp       r8d,[rsp+0F0]
       ja        near ptr M01_L26
       mov       rcx,[rsp+0E8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+0F0]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L41
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0E0]
       add       ecx,[r13+8]
       mov       [rsp+0E0],ecx
M01_L13:
       mov       ecx,[rsp+0E0]
       cmp       ecx,[rsp+0F0]
       ja        near ptr M01_L26
       mov       rax,[rsp+0E8]
       mov       [rsp+70],rax
       mov       [rsp+78],ecx
       lea       rcx,[rsp+70]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13,[rsp+0D8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   xmmword ptr [rsp+0E8],xmm0
       test      r13,r13
       je        near ptr M01_L16
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+0CC],eax
       mov       rcx,7FFE70995120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L42
M01_L14:
       xor       eax,eax
       mov       dword ptr [rsp+0C4],1
       mov       r10d,[rsp+0CC]
       cmp       [rcx+8],r10d
       jbe       short M01_L15
       mov       dword ptr [rsp+0C8],1
       mov       edx,10
       shlx      edx,edx,r10d
       cmp       [r13+8],edx
       jne       near ptr M01_L27
       mov       [rsp+0CC],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rsp+48],r9
       mov       r11,[r9]
       mov       [rsp+40],r11
       mov       rcx,r9
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       r9,[rsp+48]
       mov       [r9+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+0C8]
       mov       r10d,[rsp+0CC]
       jne       near ptr M01_L43
M01_L15:
       mov       rcx,1EAF90005D0
       mov       rdx,[rcx]
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M01_L56
M01_L16:
       test      r15,r15
       je        near ptr M01_L28
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L61
       mov       r12d,[r15+8]
       test      r12d,r12d
       jne       near ptr M01_L22
       mov       r13,rbx
M01_L17:
       mov       rcx,r13
       mov       edx,edi
       call      qword ptr [7FFE70E66D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L25
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L62
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       add       r14d,1
       jo        near ptr M01_L29
       cmp       r14d,esi
       jl        near ptr M01_L10
M01_L19:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFE70E95380]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,108
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L20:
       call      qword ptr [7FFE7115C240]
       test      eax,eax
       jne       near ptr M01_L31
       jmp       near ptr M01_L03
M01_L21:
       call      qword ptr [7FFE7115C240]
       test      eax,eax
       jne       near ptr M01_L31
       jmp       near ptr M01_L04
M01_L22:
       lea       r13,[r15+0C]
       mov       ecx,r12d
       test      r12d,r12d
       jle       short M01_L23
       test      ecx,ecx
       je        near ptr M01_L62
       movzx     ecx,word ptr [r13]
       call      qword ptr [7FFE70DB6A60]; System.IO.PathInternal.IsDirectorySeparator(Char)
       test      eax,eax
       jne       near ptr M01_L61
M01_L23:
       cmp       r12d,2
       jl        short M01_L24
       test      r12d,r12d
       je        near ptr M01_L62
       movzx     ecx,word ptr [r13]
       call      qword ptr [7FFE70DB6988]; System.IO.PathInternal.IsValidDriveChar(Char)
       test      eax,eax
       je        short M01_L24
       cmp       r12d,1
       jbe       near ptr M01_L62
       cmp       word ptr [r13+2],3A
       je        near ptr M01_L61
M01_L24:
       lea       rcx,[rsp+90]
       mov       rdx,rbx
       call      qword ptr [7FFE70DBC048]; System.MemoryExtensions.AsSpan(System.String)
       lea       rcx,[rsp+80]
       mov       rdx,r15
       call      qword ptr [7FFE70DBC048]; System.MemoryExtensions.AsSpan(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+60]
       call      qword ptr [7FFE70D47738]; System.IO.Path.JoinInternal(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       jmp       near ptr M01_L17
M01_L25:
       mov       rcx,rbp
       mov       rdx,r13
       call      qword ptr [7FFE70B0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L18
M01_L26:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE70F26AC0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70A5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       ecx,1B47B
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C166E8]
       int       3
M01_L29:
       call      CORINFO_HELP_OVERFLOW
M01_L30:
       call      qword ptr [7FFE70E9E0A0]
       mov       rbx,rax
       mov       ecx,447
       mov       rdx,7FFE70D14AA8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15700
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15700
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70E9D8A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE70E9DC98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E9E220]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbp
       call      qword ptr [7FFE70C16670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L31:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L32:
       cmp       byte ptr [rsp+100],0
       je        near ptr M01_L05
       lea       rcx,[rsp+100]
       call      qword ptr [7FFE70B047B0]
       mov       esi,eax
       jmp       near ptr M01_L06
M01_L33:
       call      qword ptr [7FFE70E9DF68]
       mov       rbx,rax
       mov       rcx,22B8AD743B0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E9DCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E9E220]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rdi
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L34:
       cmp       byte ptr [rsp+0F8],0
       je        near ptr M01_L07
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFE70B047B0]
       mov       edi,eax
       jmp       near ptr M01_L08
M01_L35:
       call      qword ptr [7FFE70E9DF68]
       mov       rbx,rax
       mov       rcx,22B8AD84210
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE70E9DCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E9E220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      qword ptr [7FFE70B0D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L36:
       mov       ecx,19C01
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70A5F810]
       int       3
M01_L37:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE70BEED18]
       int       3
M01_L38:
       mov       rcx,22B8AD73458
       mov       [rbp+8],rcx
       jmp       near ptr M01_L09
M01_L39:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L40:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE70B75848]
       jmp       near ptr M01_L12
M01_L41:
       lea       rcx,[rsp+0D0]
       mov       rdx,r13
       call      qword ptr [7FFE70B75848]
       jmp       near ptr M01_L13
M01_L42:
       mov       rcx,r12
       call      qword ptr [7FFE70D0E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L14
M01_L43:
       mov       rcx,[r12+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L62
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rsp+0C8],eax
       jne       short M01_L45
       mov       rcx,r12
       mov       [rsp+0CC],r10d
       mov       edx,r10d
       call      qword ptr [7FFE70D0E898]
       mov       r9,rax
M01_L44:
       mov       rdx,[r9+8]
       mov       [rsp+38],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+0A8],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+0A8]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L46
       call      qword ptr [7FFE71157180]
       mov       edx,eax
       mov       [rsp+0AC],edx
       jmp       short M01_L47
M01_L45:
       mov       [rsp+0CC],r10d
       jmp       short M01_L44
M01_L46:
       mov       edx,ecx
       sar       edx,10
       mov       [rsp+0AC],edx
M01_L47:
       mov       rcx,7FFE70995120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+0AC]
       xor       edx,edx
       div       dword ptr [7FFE70995C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L54
M01_L48:
       cmp       eax,[r8+8]
       jae       near ptr M01_L62
       mov       [rsp+0B4],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+0A4],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+0A0],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L50
       test      r10d,r10d
       jne       short M01_L51
       xor       edx,edx
       mov       [rax+14],edx
M01_L49:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+0A0]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+0A4],1
M01_L50:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+0A4]
       test      ecx,ecx
       je        short M01_L52
       mov       r8d,1
       jmp       short M01_L55
M01_L51:
       jmp       short M01_L49
M01_L52:
       mov       eax,[rsp+0B4]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M01_L53
       xor       r8d,r8d
M01_L53:
       mov       edx,[rsp+0B0]
       inc       edx
       mov       eax,r8d
M01_L54:
       mov       r8,[rsp+38]
       mov       [rsp+0B0],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L48
       xor       r8d,r8d
M01_L55:
       mov       eax,r8d
       mov       [rsp+0C4],eax
       mov       eax,[rsp+0C8]
       mov       r10d,[rsp+0CC]
       jmp       near ptr M01_L15
M01_L56:
       mov       r8d,eax
       mov       rcx,rdx
       mov       edx,r10d
       mov       r10,rcx
       mov       eax,[rsp+0C4]
       cmp       dword ptr [r13+8],0
       mov       [rsp+0CC],edx
       mov       [rsp+0C8],r8d
       mov       [rsp+58],r10
       mov       [rsp+0C4],eax
       je        near ptr M01_L16
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0C0],eax
       mov       edx,[r13+8]
       mov       [rsp+0BC],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0BC]
       mov       edx,3
       call      qword ptr [7FFE70B07678]
       mov       eax,[rsp+0C8]
       test      [rsp+0C4],eax
       mov       [rsp+0C8],eax
       jne       near ptr M01_L16
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+0B8],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+0C8]
       test      r12d,r12d
       jne       short M01_L57
       mov       rcx,[rsp+50]
       mov       edx,[rsp+0B8]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L58
M01_L57:
       mov       rcx,[rsp+50]
       mov       edx,[rsp+0B8]
       mov       r8d,[rsp+0CC]
M01_L58:
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L59
       mov       eax,1
       jmp       short M01_L60
M01_L59:
       xor       eax,eax
M01_L60:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r13d
       call      qword ptr [7FFE70D0F360]
       jmp       near ptr M01_L16
M01_L61:
       mov       r13,r15
       jmp       near ptr M01_L17
M01_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3053
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE70E86EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,28C89404AC8
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE70A7E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE70EB5BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE710DE040]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B27360]; System.Guid.NewGuid()
       mov       r8,2615B800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,2A1E977FAD0
       call      qword ptr [7FFE70B27180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE70E76F28]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M01_L00
       mov       [rbp-40],rdx
       mov       [rbp-108],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0F8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0D8],rcx
       mov       rcx,rbp
       mov       [rbp-0C8],rcx
       mov       byte ptr [rbp-48],1
       mov       dword ptr [rbp-44],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L52
M01_L01:
       test      eax,eax
       je        near ptr M01_L53
M01_L02:
       mov       rcx,209B5004AC0
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L54
       lea       rcx,[rdi+20]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-50]
       jne       near ptr M01_L54
M01_L03:
       mov       r14,[rbp-50]
M01_L04:
       xor       edx,edx
       mov       [rbp-50],rdx
       mov       [rbp-0A0],r14
       mov       rdx,209B5004AC8
       mov       rax,[rdx]
       mov       [rbp-0A8],rax
       xor       edx,edx
       mov       [rbp-40],edx
       cmp       byte ptr [rbp-40],0
       jne       short M01_L05
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       xor       r15d,r15d
       jmp       near ptr M01_L18
M01_L05:
       mov       r14,[rbp-0A0]
       call      qword ptr [7FFE70A6E040]
       int       3
M01_L06:
       xor       edx,edx
       mov       [rbp-54],edx
       lea       rdi,[rbp-54]
       mov       [rbp-0B8],rdi
M01_L07:
       mov       rdx,rdi
       mov       [rbp-60],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0E8],rax
       lea       rax,[M01_L08]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFF033333A0
       call      rax
M01_L08:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFED091505C],0
       je        short M01_L09
       call      qword ptr [7FFED0905398]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-0F0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L23
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-60],rax
       mov       eax,[rbp-54]
       and       eax,0F
       cmp       eax,8
       mov       rdi,[rbp-0B8]
       ja        near ptr M01_L07
       mov       [rbp-64],eax
       lea       rax,[rbp-64]
       mov       r14,[rbp-0A0]
       mov       rcx,[r14+8]
       mov       rdx,rcx
       mov       r8d,[r14+18]
       mov       r10d,r8d
       mov       edi,[rcx+8]
       sub       edi,r8d
       mov       ecx,r10d
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M01_L24
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M01_L19
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M01_L14
       mov       [rbp-70],eax
       mov       [rbp-78],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M01_L12
       cmp       eax,64
       jb        short M01_L11
       mov       rdx,209B5000290
       mov       rdx,[rdx]
M01_L10:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,eax
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       eax,r10d
       mov       r10,rdx
       shl       eax,2
       mov       eax,[r10+rax+10]
       mov       [rcx],eax
       cmp       r8d,64
       mov       eax,r8d
       jae       short M01_L10
M01_L11:
       cmp       eax,0A
       jb        short M01_L12
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,209B5000290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L13
M01_L12:
       add       eax,30
       mov       [rcx-2],ax
M01_L13:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       xor       eax,eax
       mov       [rbp-70],eax
M01_L15:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       test      eax,eax
       je        near ptr M01_L22
M01_L16:
       mov       ecx,[rbp-70]
       add       [r14+18],ecx
M01_L17:
       add       r15d,1
       jo        near ptr M01_L25
M01_L18:
       cmp       r15d,ebx
       jl        near ptr M01_L06
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L28
M01_L19:
       call      qword ptr [7FFE70B8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L20
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L21
M01_L20:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L21:
       mov       ecx,r12d
       mov       [rbp-88],r8
       mov       [rbp-80],r9d
       mov       [rbp-98],r13
       mov       [rbp-90],edi
       lea       r8,[rbp-70]
       mov       [rsp+20],r8
       lea       r8,[rbp-88]
       lea       r9,[rbp-98]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE711B6010]
       test      eax,eax
       jne       near ptr M01_L16
M01_L22:
       mov       ecx,[rbp-64]
       call      qword ptr [7FFE70BAFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE70C9C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L17
M01_L23:
       mov       ecx,eax
       call      qword ptr [7FFE710C6970]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L24:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M01_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L26:
       mov       r15,rsi
       jmp       near ptr M01_L42
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L28:
       cmp       byte ptr [rbp-40],0
       je        short M01_L29
       mov       rcx,[rbp-0A8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L29:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L26
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+10],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+10]
       inc       ecx
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       ecx,eax
       jge       short M01_L30
       mov       [rbx+10],ecx
       mov       eax,[rsi+8]
       mov       r15d,[rsi+8]
       dec       r15d
       js        short M01_L37
       jmp       short M01_L31
M01_L30:
       mov       [rbx+10],eax
       jmp       short M01_L26
M01_L31:
       cmp       [rsi+8],r15d
       jle       short M01_L35
M01_L32:
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L34
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L37
M01_L33:
       dec       r15d
       jns       short M01_L32
       jmp       short M01_L37
M01_L34:
       call      qword ptr [7FFE711EEB38]
       test      eax,eax
       je        short M01_L37
       jmp       short M01_L33
M01_L35:
       cmp       r15d,[rsi+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L47
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L37
M01_L36:
       dec       r15d
       jns       short M01_L35
M01_L37:
       inc       r15d
       cmp       [rsi+8],r15d
       jne       short M01_L40
       mov       rbx,rsi
M01_L38:
       mov       esi,[rbx+8]
       dec       esi
       xor       edi,edi
       cmp       dword ptr [rbx+8],0
       jle       short M01_L43
M01_L39:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L44
       cmp       ecx,100
       jae       near ptr M01_L27
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L43
       jmp       short M01_L45
M01_L40:
       test      r15d,r15d
       je        near ptr M01_L48
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,r15d
       cmp       [rbx],bl
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L38
M01_L41:
       mov       r15,rbx
M01_L42:
       mov       [rbp-0B0],r15
       jmp       short M01_L49
M01_L43:
       sub       esi,edi
       inc       esi
       cmp       [rbx+8],esi
       je        short M01_L41
       test      esi,esi
       je        short M01_L46
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       mov       r8d,esi
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       edx,edi
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L42
M01_L44:
       call      qword ptr [7FFE711EEB38]
       test      eax,eax
       je        short M01_L43
M01_L45:
       inc       edi
       cmp       [rbx+8],edi
       jg        near ptr M01_L39
       jmp       short M01_L43
M01_L46:
       mov       r15,24A470B0008
       jmp       short M01_L42
M01_L47:
       call      qword ptr [7FFE711EEB38]
       test      eax,eax
       je        near ptr M01_L37
       jmp       near ptr M01_L36
M01_L48:
       mov       rbx,24A470B0008
       jmp       near ptr M01_L38
M01_L49:
       mov       rcx,rsp
       call      M01_L57
       jmp       short M01_L51
M01_L50:
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L51:
       mov       r15,[rbp-0B0]
       mov       rax,r15
       jmp       short M01_L50
M01_L52:
       cmp       byte ptr [rbp-48],0
       je        near ptr M01_L01
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE70B147B0]
       mov       ebx,eax
       jmp       near ptr M01_L02
M01_L53:
       call      qword ptr [7FFE70EADF68]
       mov       rsi,rax
       mov       rcx,24A470B9A90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A67318]; System.String.Trim()
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE70EADCB0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70EAE220]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C55A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L55
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L03
M01_L55:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L04
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+130]
       cmp       byte ptr [rbp-40],0
       je        short M01_L56
       mov       rcx,[rbp-0A8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L56:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L57:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+130]
       mov       rcx,209B5004AC0
       mov       rsi,[rcx]
       mov       r14,[rsi+10]
       mov       rcx,7FFE710C1B60
       cmp       [r14+18],rcx
       jne       short M01_L58
       mov       rcx,[rbp-0A0]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r14+8]
       cmp       edx,[rax+0C]
       jg        short M01_L62
       xor       edx,edx
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L59
M01_L58:
       mov       rdx,[rbp-0A0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M01_L62
M01_L59:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L60
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-0A0]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L62
M01_L60:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L61
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C5578]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L62
M01_L61:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L62:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1911
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE70E87888]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       mov       [rsp+50],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,esi
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L10
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L11
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       edi,5
       jl        near ptr M01_L12
       xor       r14d,r14d
       cmp       edi,64
       setle     r14b
       mov       eax,r14d
       test      r14d,r14d
       je        near ptr M01_L13
M01_L02:
       test      eax,eax
       je        near ptr M01_L14
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       ebp,5
       jl        near ptr M01_L15
       xor       r15d,r15d
       cmp       ebp,32
       setle     r15b
       mov       eax,r15d
       test      r15d,r15d
       je        near ptr M01_L16
M01_L04:
       test      eax,eax
       je        near ptr M01_L17
M01_L05:
       call      qword ptr [7FFE70E87060]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE70E87C48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE710D7300]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A20]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE70EA0A30]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A50]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A60]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFE710DE040]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A80]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFE70EA0A90]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FFE710E1630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFE710E1D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE70B247B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFE70EBDF68]
       mov       rbx,rax
       mov       rcx,1BEFC31F2C0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       xor       r14d,r14d
       mov       eax,r14d
       test      r14d,r14d
       jne       near ptr M01_L02
M01_L13:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE70B247B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FFE70EBDF68]
       mov       rbx,rax
       mov       rcx,1BEFC31F2F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       xor       r15d,r15d
       mov       eax,r15d
       test      r15d,r15d
       jne       near ptr M01_L04
M01_L16:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE70B247B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FFE70EBDF68]
       mov       rbx,rax
       mov       rcx,1BEFC31F320
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70EBDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70EBE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
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
       call      qword ptr [7FFE70E9C150]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+68]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE71186C70]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 135
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       r14,rcx
       mov       ebx,edx
       mov       ebp,r8d
       mov       r15d,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,ebx
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L06
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L07
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       ebp,5
       jl        near ptr M01_L08
       xor       r13d,r13d
       cmp       ebp,64
       setle     r13b
       mov       eax,r13d
       test      r13d,r13d
       je        near ptr M01_L09
M01_L02:
       test      eax,eax
       je        near ptr M01_L10
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       r15d,5
       jl        near ptr M01_L11
       xor       r12d,r12d
       cmp       r15d,32
       setle     r12b
       mov       eax,r12d
       test      r12d,r12d
       je        near ptr M01_L12
M01_L04:
       test      eax,eax
       je        near ptr M01_L13
M01_L05:
       call      qword ptr [7FFE70E97060]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,240FD563BD0
       mov       [rax+8],rcx
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+50],rdi
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       [rsp+60],rcx
       mov       [rsp+68],rcx
       mov       [rsp+70],rcx
       mov       [rsp+78],rcx
       mov       [rsp+80],rcx
       mov       rcx,[rsi+10]
       mov       edx,ebx
       mov       r8d,ebp
       mov       r9d,r15d
       call      qword ptr [7FFE71124C78]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D74720]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Addresses(System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       vmovups   xmm0,[rsi+38]
       vmovups   [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D747C8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[rsi+8]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D74828]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_CellPhone(System.String)
       mov       rdx,[rsi+18]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D74888]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Email(System.String)
       mov       rdx,[rsi+20]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D748E8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_FirstName(System.String)
       call      qword ptr [7FFE710EDE30]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D74960]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Id(System.String)
       mov       rdx,[rsi+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D749C0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_LastName(System.String)
       mov       rdx,[rsi+30]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE70D74A20]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Phone(System.String)
       mov       rdi,r14
       lea       rsi,[rsp+50]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,r14
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE70B347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE70ECDF68]
       mov       r13,rax
       mov       rcx,240FD55F2C0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE70B3D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L08:
       xor       r13d,r13d
       mov       eax,r13d
       test      r13d,r13d
       jne       near ptr M01_L02
M01_L09:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE70B347B0]
       mov       ebp,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE70ECDF68]
       mov       r12,rax
       mov       rcx,240FD55F2F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFE70B3D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L11:
       xor       r12d,r12d
       mov       eax,r12d
       test      r12d,r12d
       jne       near ptr M01_L04
M01_L12:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE70B347B0]
       mov       r15d,eax
       jmp       near ptr M01_L05
M01_L13:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,240FD55F320
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 937
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0EB
       xor       edx,edx
       call      qword ptr [7FFE70E45DB8]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,168084E4240
       cmp       [rcx],ecx
       call      qword ptr [7FFE7098A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Countries+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],ebx
       mov       ecx,[rdi+8]
       mov       [rdi+8],ecx
       mov       rbx,12776404AF8
       cmp       qword ptr [rbx],0
       je        near ptr M01_L03
M01_L00:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx]
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Tester.Data.Countries+<>c__DisplayClass4_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Country)
       mov       [rbp+18],r9
       lea       r9,[rsp+20]
       mov       rdx,rbx
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>, System.Func`2<DotNetTips.Spargine.Tester.Data.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFE710E7750]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      sil,sil
       jne       short M01_L01
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFE70E45CE0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rbx,[rax+70]
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFE70E45CE0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,168084D0C30
       call      qword ptr [7FFE70A46B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFE70E8D110]
       mov       rsi,rax
       mov       rcx,168084E4210
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE70E8D008]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70E8D578]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       call      qword ptr [7FFE70E4F978]; DotNetTips.Spargine.Tester.Data.Countries.DeserializeCountires()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
; Total bytes of code 373
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,0A
       mov       r8,1F574134210
       call      qword ptr [7FFE70E97030]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       xor       ecx,ecx
       mov       [rsp+28],rcx
       test      esi,esi
       jle       near ptr M01_L06
       xor       ebp,ebp
       cmp       esi,100
       setle     bpl
       mov       eax,ebp
       test      ebp,ebp
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L09
       mov       eax,[rcx+8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L09
M01_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,1B4E2001DB8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE70D25470]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M01_L10
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L03:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE70E97168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L11
       test      rdx,rdx
       je        near ptr M01_L11
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L12
       mov       rcx,[rsp+48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,r8d
       mov       ebp,[rdx+8]
       cmp       ebp,eax
       ja        near ptr M01_L11
       add       rdx,0C
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+40]
       mov       [rsp+40],ebp
M01_L04:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFE71186A00]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L13
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L12
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       ja        near ptr M01_L13
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+40]
       mov       [rsp+40],r14d
M01_L05:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE70BA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70D775B8]; System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       xor       ebp,ebp
       mov       eax,ebp
       test      ebp,ebp
       jne       near ptr M01_L00
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B347B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE70ECDF68]
       mov       r15,rax
       mov       rcx,1F574134248
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,1F574134210
       jmp       near ptr M01_L02
M01_L10:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L03
M01_L11:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE70BA5848]
       jmp       near ptr M01_L04
M01_L12:
       call      qword ptr [7FFE70C1E9A0]
       int       3
M01_L13:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE70BA5848]
       jmp       near ptr M01_L05
; Total bytes of code 655
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E57090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rcx,20004004AC0
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L18
       lea       rcx,[rbx+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L18
M01_L00:
       mov       rbx,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       xor       r14d,r14d
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       near ptr M01_L08
M01_L02:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L16
       test      eax,eax
       je        near ptr M01_L13
M01_L03:
       mov       ecx,1
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE70E57168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L11
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M01_L11
       lea       ecx,[rsi+1]
       test      ecx,ecx
       jl        near ptr M01_L14
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,1FF82F4668C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       mov       r8,[rbp-48]
       cmp       [r8],r8b
       test      r13,r13
       je        short M01_L07
       lea       rdx,[r13+0C]
       mov       r15d,[r13+8]
       test      r15d,r15d
       je        short M01_L07
       mov       r8,[rbp-48]
       mov       r8,[r8+8]
       mov       rcx,[rbp-48]
       mov       ebx,[rcx+18]
       lea       ecx,[rbx+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L12
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M01_L06
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       add       r15d,ebx
       mov       rcx,[rbp-48]
       mov       [rcx+18],r15d
       jmp       short M01_L07
M01_L06:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L05
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L05
M01_L07:
       add       r14d,1
       jo        short M01_L10
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jg        near ptr M01_L02
M01_L08:
       mov       rcx,[rbp-48]
       mov       ecx,[rcx+18]
       mov       eax,ecx
       mov       rdx,[rbp-48]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],eax
       jbe       near ptr M01_L15
       mov       word ptr [rdx+rax*2+10],2F
       inc       ecx
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,[rbp-48]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       near ptr M01_L17
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       r13,1FF82F46680
       jmp       near ptr M01_L04
M01_L12:
       mov       rcx,[rbp-48]
       mov       r8d,r15d
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L07
M01_L13:
       call      qword ptr [7FFE70E8DF68]
       mov       r12,rax
       mov       rcx,1FF82F4FA90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E8DCB0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE70E8E220]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       call      qword ptr [7FFE70BDEF10]
       int       3
M01_L15:
       mov       rcx,[rbp-48]
       mov       edx,2F
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L09
M01_L16:
       mov       edx,1
       jmp       near ptr M01_L03
M01_L17:
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rax,[rbp-50]
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
M01_L18:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A5AA0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
M01_L19:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L01
M01_L21:
       cmp       qword ptr [rdi+10],0
       jne       short M01_L22
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L20
M01_L22:
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       call      qword ptr [7FFE710A55C0]
       test      eax,eax
       je        short M01_L20
       jmp       short M01_L19
M01_L23:
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
       mov       rcx,20004004AC0
       mov       r15,[rcx]
       mov       r13,[r15+10]
       mov       rcx,7FFE710A1B60
       cmp       [r13+18],rcx
       jne       short M01_L24
       mov       rcx,[rbp-48]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-48]
       add       ecx,[rdx+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L28
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [r15+20],0
       jne       short M01_L26
       lea       rcx,[r15+20]
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L27
       mov       r12,[r15+18]
       mov       rcx,[r12+10]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A5AD0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L28
       mov       rcx,r12
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE710A5590]
       jmp       short M01_L28
M01_L27:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L28:
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
; Total bytes of code 1026
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFE70E570A8]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,ecx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],400
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M01_L02
M01_L00:
       test      eax,eax
       je        short M01_L03
M01_L01:
       mov       ecx,0A
       mov       rdx,250BCD94240
       call      qword ptr [7FFE70E57018]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       rsi,rax
       mov       ecx,ebx
       call      qword ptr [7FFE70E57138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rbx,rax
       call      qword ptr [7FFE70DA6AA8]; System.IO.File.get_UTF8NoBOM()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE70DA7420]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rsi
       mov       r9,rdi
       mov       r8,rbx
       mov       edx,2
       call      qword ptr [7FFE70DA7450]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70AF47B0]
       mov       ebx,eax
       jmp       short M01_L01
M01_L03:
       call      qword ptr [7FFE70E8DF68]
       mov       rbx,rax
       mov       rcx,250BCD94210
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E8DCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E8E220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 238
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E57108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,301B4314210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       call      qword ptr [7FFE70E57090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
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
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E57180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,2C122404AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,301B4314238
       mov       r8,301B4300C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70A46B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE70DE6E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70BDEF10]
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
       mov       rax,301B4300008
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
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rcx,2C122404AC0
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M03_L18
       lea       rcx,[rbx+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M03_L18
M03_L00:
       mov       rbx,[rbp-40]
M03_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       xor       r14d,r14d
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       near ptr M03_L08
M03_L02:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L13
       test      eax,eax
       je        near ptr M03_L15
M03_L03:
       mov       ecx,1
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE70E57168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L12
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M03_L12
       lea       ecx,[rsi+1]
       test      ecx,ecx
       jl        near ptr M03_L16
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,301B430668C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L04:
       mov       r8,[rbp-48]
       cmp       [r8],r8b
       test      r13,r13
       je        short M03_L07
       lea       rdx,[r13+0C]
       mov       r15d,[r13+8]
       test      r15d,r15d
       je        short M03_L07
       mov       r8,[rbp-48]
       mov       r8,[r8+8]
       mov       rcx,[rbp-48]
       mov       ebx,[rcx+18]
       lea       ecx,[rbx+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M03_L14
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M03_L06
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L05:
       add       r15d,ebx
       mov       rcx,[rbp-48]
       mov       [rcx+18],r15d
       jmp       short M03_L07
M03_L06:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M03_L05
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M03_L05
M03_L07:
       add       r14d,1
       jo        short M03_L10
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jg        near ptr M03_L02
M03_L08:
       mov       rcx,[rbp-48]
       mov       ecx,[rcx+18]
       mov       eax,ecx
       mov       rdx,[rbp-48]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],eax
       jbe       short M03_L11
       mov       word ptr [rdx+rax*2+10],2F
       inc       ecx
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
M03_L09:
       mov       rcx,[rbp-48]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       near ptr M03_L17
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,[rbp-48]
       mov       edx,2F
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L09
M03_L12:
       mov       r13,301B4306680
       jmp       near ptr M03_L04
M03_L13:
       mov       edx,1
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp-48]
       mov       r8d,r15d
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L07
M03_L15:
       call      qword ptr [7FFE70E8DF68]
       mov       r12,rax
       mov       rcx,301B430FA90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E8DCB0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE70E8E220]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L16:
       call      qword ptr [7FFE70BDEF10]
       int       3
M03_L17:
       mov       rcx,rsp
       call      M03_L23
       nop
       mov       rax,[rbp-50]
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
M03_L18:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A5AA0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L21
M03_L19:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M03_L00
M03_L20:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M03_L01
M03_L21:
       cmp       qword ptr [rdi+10],0
       jne       short M03_L22
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M03_L20
M03_L22:
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       call      qword ptr [7FFE710A55C0]
       test      eax,eax
       je        short M03_L20
       jmp       short M03_L19
M03_L23:
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
       mov       rcx,2C122404AC0
       mov       r15,[rcx]
       mov       r13,[r15+10]
       mov       rcx,7FFE710A1B60
       cmp       [r13+18],rcx
       jne       short M03_L24
       mov       rcx,[rbp-48]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-48]
       add       ecx,[rdx+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M03_L28
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        short M03_L28
M03_L25:
       cmp       qword ptr [r15+20],0
       jne       short M03_L26
       lea       rcx,[r15+20]
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L28
M03_L26:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M03_L27
       mov       r12,[r15+18]
       mov       rcx,[r12+10]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A5AD0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M03_L28
       mov       rcx,r12
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE710A5590]
       jmp       short M03_L28
M03_L27:
       add       r15,2C
       lock dec  dword ptr [r15]
M03_L28:
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
; Total bytes of code 1019
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlFragment()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E570D8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       sub       rsp,28
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E57180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,22B3BCA6680
       add       rsp,28
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 55
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E57108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,2280BC44210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E57180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,1E779C04AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE70E56EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,2280BC44238
       mov       r8,2280BC30C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70A46B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE70DE6E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70BDEF10]
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
       mov       rax,2280BC30008
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE70E67108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE70E67180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,24456404AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE70E66EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,284E82B4210
       mov       r8,284E82A0C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70A56B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE70DF6E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,20272004AA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFE70E66EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      qword ptr [7FFE70DF6E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,20272004AC8
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE70A5E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE70E95BC0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
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
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
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
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
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
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
       lea       rax,[7FFED0411C80]
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
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       lea       rdx,[7FFED0293058]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
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
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       call      qword ptr [7FFED0411C48]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       call      qword ptr [7FFED0411C50]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
       call      qword ptr [7FFED04090A0]
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
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       call      qword ptr [7FFED0411C40]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       call      qword ptr [7FFED03F4908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
       call      qword ptr [7FFED0417588]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       call      qword ptr [7FFED0411C58]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       call      qword ptr [7FFED0411C68]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1578
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE70E67138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       edx,edx
       test      ecx,ecx
       setg      dl
       mov       eax,edx
       test      edx,edx
       je        short M01_L02
M01_L00:
       test      eax,eax
       je        short M01_L03
M01_L01:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE70E67168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B047B0]
       mov       ecx,eax
       jmp       short M01_L01
M01_L03:
       call      qword ptr [7FFE70E9DF68]
       mov       rbx,rax
       mov       rcx,329514D9A90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E9DCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E9E220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 175
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      qword ptr [7FFE70E97198]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L23
M01_L00:
       test      eax,eax
       je        near ptr M01_L24
M01_L01:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L25
M01_L02:
       test      edx,edx
       je        near ptr M01_L26
M01_L03:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M01_L27
M01_L04:
       test      r8d,r8d
       je        near ptr M01_L28
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      esi,esi
       jl        near ptr M01_L29
       test      esi,esi
       je        near ptr M01_L30
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L17
M01_L07:
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M01_L31
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L32
M01_L08:
       test      r8d,r8d
       je        near ptr M01_L18
M01_L09:
       mov       edx,ebx
       test      ebx,ebx
       jle       near ptr M01_L33
       mov       r10d,1
       mov       r9d,r10d
       test      r10d,r10d
       je        near ptr M01_L34
M01_L10:
       test      r9d,r9d
       je        near ptr M01_L19
M01_L11:
       test      ecx,ecx
       jle       near ptr M01_L35
       mov       r11d,1
       mov       eax,r11d
       test      r11d,r11d
       je        near ptr M01_L36
M01_L12:
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       test      edx,edx
       jle       near ptr M01_L37
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L38
M01_L14:
       test      r8d,r8d
       je        near ptr M01_L21
M01_L15:
       call      qword ptr [7FFE70E96EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE70E97168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L39
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L16:
       add       r14d,1
       jo        near ptr M01_L22
       cmp       r14d,esi
       jl        near ptr M01_L07
M01_L17:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L18:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,2E6ADC0FA68
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,2E6ADC0FA90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,2E6ADC0FA68
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,2E6ADC0FA90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE70B347B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L24:
       call      qword ptr [7FFE70ECDF68]
       mov       rbx,rax
       mov       rcx,2E6ADC043B0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L25:
       cmp       byte ptr [rsp+30],0
       je        near ptr M01_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE70B347B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L26:
       call      qword ptr [7FFE70ECDF68]
       mov       rsi,rax
       mov       rcx,2E6ADC0FA68
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFE70B3D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L27:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L04
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B347B0]
       mov       ebx,eax
       jmp       near ptr M01_L05
M01_L28:
       call      qword ptr [7FFE70ECDF68]
       mov       rsi,rax
       mov       rcx,2E6ADC0FA90
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE70ECDCB0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70ECE220]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE70C1ED18]
       int       3
M01_L30:
       mov       rcx,2E6ADC03458
       mov       [rbp+8],rcx
       jmp       near ptr M01_L06
M01_L31:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L08
M01_L32:
       mov       ecx,1
       jmp       near ptr M01_L09
M01_L33:
       xor       r10d,r10d
       mov       r9d,r10d
       test      r10d,r10d
       jne       near ptr M01_L10
M01_L34:
       mov       edx,1
       jmp       near ptr M01_L11
M01_L35:
       xor       r11d,r11d
       mov       eax,r11d
       test      r11d,r11d
       jne       near ptr M01_L12
M01_L36:
       mov       ecx,1
       jmp       near ptr M01_L13
M01_L37:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L14
M01_L38:
       mov       edx,1
       jmp       near ptr M01_L15
M01_L39:
       mov       rcx,rbp
       mov       rdx,rax
       call      qword ptr [7FFE70B3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L16
; Total bytes of code 1344
```

