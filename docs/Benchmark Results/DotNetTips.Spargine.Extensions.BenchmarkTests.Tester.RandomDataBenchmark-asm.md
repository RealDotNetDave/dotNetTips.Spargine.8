## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF829A4708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
       call      qword ptr [7FFF8296FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF829A4AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFF82BF7DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829850A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFF829850B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFF829850C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFF829850D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFF829850E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFF82BFECE8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829850F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFF82985108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFF82985118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FFF82BE5000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFF82BE5730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF825A47B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFF82A0C330]
       mov       rbx,rax
       mov       rcx,22F651CDFB0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFF825AD470]
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
       call      qword ptr [7FFF825A47B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FFF82A0C330]
       mov       rbx,rax
       mov       rcx,22F651CDFE0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF825AD470]
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
       call      qword ptr [7FFF825A47B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FFF82A0C330]
       mov       rbx,rax
       mov       rcx,22F651CE010
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF825AD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF829B4708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
       call      qword ptr [7FFF8297FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF829B4AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFF82BF6AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829950A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFF829950B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFF829950C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFF829950D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFF829950E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFF82BFD830]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829950F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFF82995108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFF82995118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FFF82C03340
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFF82C03A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF825B47B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFF82A1C330]
       mov       rbx,rax
       mov       rcx,31DA921DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A1C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A1C5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFF825BD470]
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
       call      qword ptr [7FFF825B47B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FFF82A1C330]
       mov       rbx,rax
       mov       rcx,31DA921DFE0
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A1C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A1C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF825BD470]
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
       call      qword ptr [7FFF825B47B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FFF82A1C330]
       mov       rbx,rax
       mov       rcx,31DA921E010
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A1C078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A1C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF825BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF8293F9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,edx
       mov       esi,r8d
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],2
       test      ecx,ecx
       jl        short M01_L02
       xor       edi,edi
       cmp       ecx,64
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        short M01_L03
M01_L00:
       test      eax,eax
       je        short M01_L04
M01_L01:
       mov       r9d,esi
       mov       edx,ecx
       mov       r8d,ebx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       call      qword ptr [7FFF82974708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FFF829740F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       short M01_L00
M01_L03:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF825747B0]
       mov       ecx,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFF829DC330]
       mov       rbx,rax
       mov       rcx,2DBEC12DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8257D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 210
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFF82984708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,18AD0000008
       mov       r8d,3A
       mov       r9,18AD0008DF0
       call      qword ptr [7FFF8298CF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 134
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
       call      qword ptr [7FFF8294FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF82984AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFF82BC6AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829650A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFF829650B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFF829650C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFF829650D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFF829650E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFF82BCD830]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829650F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFF82965108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFF82965118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FFF82BD33B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFF82BD3AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF825847B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFF829EC330]
       mov       rbx,rax
       mov       rcx,18AD000DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFF8258D470]
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
       call      qword ptr [7FFF825847B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FFF829EC330]
       mov       rbx,rax
       mov       rcx,18AD000DFE0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8258D470]
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
       call      qword ptr [7FFF825847B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FFF829EC330]
       mov       rbx,rax
       mov       rcx,18AD000E010
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8258D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       test      rbx,rbx
       je        near ptr M02_L09
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M02_L10
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF82426DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,18AD0012EF0
       xor       edx,edx
       call      qword ptr [7FFF82426DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M02_L14
       test      rdi,rdi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M02_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L14
M02_L00:
       mov       r8,18AD0000008
       cmp       byte ptr [rsp+0B8],0
       cmove     rdi,r8
M02_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF8298CF78]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82C76040]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r14+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M02_L15
       cmp       rbx,rdi
       je        near ptr M02_L04
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L04
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M02_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L16
       mov       rax,[rcx]
       add       rax,10
M02_L02:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L03
       mov       rcx,14A3E000438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L03
       mov       rcx,14A3E000418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L17
M02_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rsp+40],rdx
       mov       [rsp+48],r8d
       mov       [rsp+30],r9
       mov       [rsp+38],eax
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       xor       r9d,r9d
       call      qword ptr [7FFF82905200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M02_L18
M02_L04:
       mov       rcx,[r14+8]
       mov       esi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,18AD00043D0
       call      qword ptr [7FFF8290FF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,esi
       mov       rdx,18AD00043B0
       call      qword ptr [7FFF8290FF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebp,[rbx+8]
       mov       r15d,esi
       cmp       r15d,ebp
       jl        short M02_L05
       cmp       esi,ebp
       jg        short M02_L07
M02_L05:
       test      esi,esi
       je        near ptr M02_L19
       sub       ebp,esi
       je        short M02_L08
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
M02_L06:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       ecx,1C7
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r15d
       call      qword ptr [7FFF82EC6C40]
       int       3
M02_L08:
       mov       rax,18AD0000008
       jmp       short M02_L06
M02_L09:
       mov       rax,18AD0000008
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L10:
       call      qword ptr [7FFF829EC348]
       mov       rcx,18AD0012EB8
       mov       rdx,18AD0000210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18AD0000008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L11
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L12
M02_L11:
       mov       ecx,1
M02_L12:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L13
       call      qword ptr [7FFF829EC468]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829E7A68]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829EC060]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFF82736670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L13:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L14:
       mov       rdi,18AD0005FA0
       jmp       near ptr M02_L01
M02_L15:
       mov       ecx,2E5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M02_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L02
M02_L17:
       call      qword ptr [7FFF826B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L03
M02_L18:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L19:
       mov       rax,rbx
       jmp       near ptr M02_L06
; Total bytes of code 1142
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFF8295F9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,1BC70730008
       mov       r8d,3A
       mov       r9,1BC70738DF0
       call      qword ptr [7FFF8299CF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 123
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,edx
       mov       esi,r8d
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],2
       test      ecx,ecx
       jl        short M01_L02
       xor       edi,edi
       cmp       ecx,64
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        short M01_L03
M01_L00:
       test      eax,eax
       je        short M01_L04
M01_L01:
       mov       r9d,esi
       mov       edx,ecx
       mov       r8d,ebx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       call      qword ptr [7FFF82994708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FFF829940F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       short M01_L00
M01_L03:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF825947B0]
       mov       ecx,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFF829FC330]
       mov       rbx,rax
       mov       rcx,1BC7073DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829FC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829FC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8259D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 210
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       test      rbx,rbx
       je        near ptr M02_L09
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M02_L10
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,1BC70742EF0
       xor       edx,edx
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M02_L14
       test      rdi,rdi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M02_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82595068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L14
M02_L00:
       mov       r8,1BC70730008
       cmp       byte ptr [rsp+0A8],0
       cmove     rdi,r8
M02_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF8299CF78]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82C86040]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rbx,[r14+8]
       cmp       [rsi],sil
       test      rbx,rbx
       je        near ptr M02_L15
       cmp       rsi,rbx
       je        near ptr M02_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L04
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M02_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L16
       mov       rax,[rcx]
       add       rax,10
M02_L02:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L03
       mov       rcx,17BDE800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L03
       mov       rcx,17BDE800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L17
M02_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdi,[rsi+0C]
       mov       edx,[rsi+8]
       lea       r8,[rbx+0C]
       mov       r9d,[rbx+8]
       mov       [rsp+38],rdi
       mov       [rsp+40],edx
       mov       [rsp+28],r8
       mov       [rsp+30],r9d
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF82915200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M02_L18
M02_L04:
       mov       rcx,[r14+8]
       mov       r14d,[rcx+8]
       xor       ecx,ecx
       mov       rdx,1BC707343D0
       call      qword ptr [7FFF8291FF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,r14d
       mov       rdx,1BC707343B0
       call      qword ptr [7FFF8291FF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edi,[rsi+8]
       mov       ebp,r14d
       cmp       ebp,edi
       jl        short M02_L05
       cmp       r14d,edi
       jg        short M02_L07
M02_L05:
       test      r14d,r14d
       je        near ptr M02_L19
       sub       edi,r14d
       je        short M02_L08
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       add       rsi,0C
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+0C]
       movsxd    r8,r14d
       lea       rdx,[rsi+r8*2]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
M02_L06:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       ecx,1C7
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82ED6B68]
       int       3
M02_L08:
       mov       rax,1BC70730008
       jmp       short M02_L06
M02_L09:
       mov       rax,1BC70730008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L10:
       call      qword ptr [7FFF829FC348]
       mov       rcx,1BC70742EB8
       mov       rdx,1BC70730210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1BC70730008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L11
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L12
M02_L11:
       mov       ecx,1
M02_L12:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L13
       call      qword ptr [7FFF829FC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829F7A68]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829FC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829FC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L13:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829FC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L14:
       mov       rdi,1BC70735FA0
       jmp       near ptr M02_L01
M02_L15:
       mov       ecx,2E5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M02_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L02
M02_L17:
       call      qword ptr [7FFF826C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L03
M02_L18:
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       mov       rax,rsi
       jmp       near ptr M02_L06
; Total bytes of code 1145
```

