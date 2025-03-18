## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidGeneratorBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF98360C1E0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       call      qword ptr [7FF982F17360]; System.Guid.NewGuid()
       mov       r8,232A4400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,273363B3C70
       call      qword ptr [7FF982F17180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidGeneratorBenchmark.GenerateMultipleUlids()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,100
       call      qword ptr [7FF98371D968]; DotNetTips.Spargine.Core.Security.UlidGenerator.GenerateMultipleUlids(Int32)
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
; DotNetTips.Spargine.Core.Security.UlidGenerator.GenerateMultipleUlids(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       esi,ebx
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M01_L10
       test      esi,esi
       je        near ptr M01_L11
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L05
M01_L03:
       call      qword ptr [7FF98371D980]; DotNetTips.Spargine.Core.Security.UlidGenerator.GenerateUlid()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L12
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       add       ebp,1
       jo        short M01_L06
       cmp       ebp,ebx
       jl        short M01_L03
M01_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       movzx     ecx,byte ptr [rsp+20]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rsp+20]
       call      qword ptr [7FF982F247B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FF9833844B0]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FF9833842D0]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,212C62A4368
       mov       r8,rdi
       call      qword ptr [7FF982F2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF98306ED48]
       int       3
M01_L11:
       mov       rcx,1D234405C90
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FF982F2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L04
; Total bytes of code 396
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidGeneratorBenchmark.GenerateUlid()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,28D574061E0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.Security.UlidGenerator.GenerateUlid()
       mov       r9,7FF982D1D370
       call      qword ptr [7FF982E64258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,28D574061E0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FF9E27F3D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.Security.UlidGenerator.GenerateUlid()

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidGeneratorBenchmark.GuidNewGuid()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF982F07360]; System.Guid.NewGuid()
       vmovups   xmm0,[rsp+30]
       vmovups   [rsp+20],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9836FDBD8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Guid, System.Private.CoreLib]](System.Guid ByRef)
       nop
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 67
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-88]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       lea       rcx,[rbp-48]
       mov       rax,offset MD_Interop+Ole32.<CoCreateGuid>g____PInvoke|1_0(System.Guid*)
       mov       [rbp-78],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-88]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFA6D56EF80
       call      rax
M01_L00:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FF9E2D0A0DC],0
       je        short M01_L01
       call      qword ptr [7FF9E2CFA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-80]
       mov       [rsi+10],rcx
       mov       ebx,eax
       test      ebx,ebx
       jne       short M01_L02
       vmovups   xmm0,[rbp-48]
       mov       rbx,[rbp+10]
       vmovups   [rbx],xmm0
       mov       rax,rbx
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF982E5CC30]
       mov       [rsi+74],ebx
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 224
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Guid, System.Private.CoreLib]](System.Guid ByRef)
       ret
; Total bytes of code 1
```

