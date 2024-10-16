## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C344708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
       call      qword ptr [7FF80C30FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80C344AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF80C59ECB8]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3250A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FF80C3250B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FF80C3250C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FF80C3250D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FF80C3250E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FF80C5D66E8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3250F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FF80C325108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FF80C325118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FF80C58CEA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FF80C58D5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FF80BF447B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,1ABA78CE000
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
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
       call      qword ptr [7FF80BF447B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,1ABA78CE030
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
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
       call      qword ptr [7FF80BF447B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,1ABA78CE060
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C344708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
       call      qword ptr [7FF80C30FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80C344AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF80C586AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3250A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FF80C3250B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FF80C3250C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FF80C3250D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FF80C3250E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FF80C58E5F8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3250F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FF80C325108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FF80C325118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FF80C5933B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FF80C593AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FF80BF447B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,199E46BDFB0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
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
       call      qword ptr [7FF80BF447B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,199E46BDFE0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
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
       call      qword ptr [7FF80BF447B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FF80C3AC330]
       mov       rbx,rax
       mov       rcx,199E46BE010
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C31F9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
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
       call      qword ptr [7FF80C354708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FF80C3540F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
       call      qword ptr [7FF80BF547B0]
       mov       ecx,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FF80C3BC330]
       mov       rbx,rax
       mov       rcx,22108AADFB0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 210
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C374708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,30D4FB40008
       mov       r8d,3A
       mov       r9,30D4FB48DF0
       call      qword ptr [7FF80C37CFA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       call      qword ptr [7FF80C33FAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80C374AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF80C5B6AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3550A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FF80C3550B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FF80C3550C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FF80C3550D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FF80C3550E8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FF80C5BE5F8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C3550F8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FF80C355108]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FF80C355118]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       mov       rdx,7FF80C5C33B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FF80C5C3AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FF80BF747B0]
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF80C3DC330]
       mov       rbx,rax
       mov       rcx,30D4FB4DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FF80BF7D470]
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
       call      qword ptr [7FF80BF747B0]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L14:
       call      qword ptr [7FF80C3DC330]
       mov       rbx,rax
       mov       rcx,30D4FB4DFE0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF7D470]
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
       call      qword ptr [7FF80BF747B0]
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L17:
       call      qword ptr [7FF80C3DC330]
       mov       rbx,rax
       mov       rcx,30D4FB4E010
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF7D470]
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
       je        near ptr M02_L11
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BE16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,30D4FB52EC8
       xor       edx,edx
       call      qword ptr [7FF80BE16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M02_L18
       test      rdi,rdi
       jne       near ptr M02_L02
M02_L00:
       mov       rdx,30D4FB40008
       cmp       byte ptr [rsp+0B8],0
       cmove     rdi,rdx
M02_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C37CF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80C665DE8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r14+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       rbx,rdi
       je        near ptr M02_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L06
       jmp       short M02_L03
M02_L02:
       test      rdx,rdx
       je        near ptr M02_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M02_L17
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M02_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L19
       mov       rax,[rcx]
       add       rax,10
M02_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L05
       mov       rcx,2CCBDC00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L05
       mov       rcx,2CCBDC00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L20
M02_L05:
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
       call      qword ptr [7FF80C2F5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M02_L21
M02_L06:
       mov       rcx,[r14+8]
       mov       esi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,30D4FB443D0
       call      qword ptr [7FF80C2FFF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,esi
       mov       rdx,30D4FB443B0
       call      qword ptr [7FF80C2FFF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebp,[rbx+8]
       mov       r15d,esi
       cmp       r15d,ebp
       jl        short M02_L07
       cmp       esi,ebp
       jg        short M02_L09
M02_L07:
       test      esi,esi
       je        near ptr M02_L22
       sub       ebp,esi
       je        short M02_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
M02_L08:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r15d
       call      qword ptr [7FF80C8B6B68]
       int       3
M02_L10:
       mov       rax,30D4FB40008
       jmp       short M02_L08
M02_L11:
       mov       rax,30D4FB40008
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       call      qword ptr [7FF80C3DC348]
       mov       rcx,30D4FB52E90
       mov       rdx,30D4FB40210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30D4FB40008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L14
M02_L13:
       mov       ecx,1
M02_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L15
       call      qword ptr [7FF80C3DC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80C126670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FF80C126670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1266E8]
       int       3
M02_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M02_L00
M02_L18:
       mov       rdi,30D4FB45FA0
       jmp       near ptr M02_L01
M02_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L04
M02_L20:
       call      qword ptr [7FF80C0A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L21:
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
M02_L22:
       mov       rax,rbx
       jmp       near ptr M02_L08
; Total bytes of code 1161
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C32F9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,214DE930008
       mov       r8d,3A
       mov       r9,214DE938DF0
       call      qword ptr [7FF80C36CFA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       call      qword ptr [7FF80C364708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FF80C3640F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
       call      qword ptr [7FF80BF647B0]
       mov       ecx,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FF80C3CC330]
       mov       rbx,rax
       mov       rcx,214DE93DFB0
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3CC078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 210
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
       je        near ptr M02_L11
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,214DE942EF0
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M02_L18
       test      rdi,rdi
       jne       near ptr M02_L02
M02_L00:
       mov       rdx,214DE930008
       cmp       byte ptr [rsp+0B8],0
       cmove     rdi,rdx
M02_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C36CF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80C655F98]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r14+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       rbx,rdi
       je        near ptr M02_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L06
       jmp       short M02_L03
M02_L02:
       test      rdx,rdx
       je        near ptr M02_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M02_L17
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M02_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L19
       mov       rax,[rcx]
       add       rax,10
M02_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L05
       mov       rcx,1D44C800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L05
       mov       rcx,1D44C800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L20
M02_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       rsi,rdx
       mov       edx,[rbx+8]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rsp+40],rsi
       mov       [rsp+48],edx
       mov       [rsp+30],r8
       mov       [rsp+38],r9d
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       xor       r9d,r9d
       call      qword ptr [7FF80C2E5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M02_L21
M02_L06:
       mov       rcx,[r14+8]
       mov       esi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,214DE9343D0
       call      qword ptr [7FF80C2EFF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,esi
       mov       rdx,214DE9343B0
       call      qword ptr [7FF80C2EFF18]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebp,[rbx+8]
       mov       r15d,esi
       cmp       r15d,ebp
       jl        short M02_L07
       cmp       esi,ebp
       jg        short M02_L09
M02_L07:
       test      esi,esi
       je        near ptr M02_L22
       sub       ebp,esi
       je        short M02_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       add       rbx,0C
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
M02_L08:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r15d
       call      qword ptr [7FF80C8A6FA0]
       int       3
M02_L10:
       mov       rax,214DE930008
       jmp       short M02_L08
M02_L11:
       mov       rax,214DE930008
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       call      qword ptr [7FF80C3CC348]
       mov       rcx,214DE942EB8
       mov       rdx,214DE930210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,214DE930008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L14
M02_L13:
       mov       ecx,1
M02_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L15
       call      qword ptr [7FF80C3CC468]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF80C116670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3CC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
       int       3
M02_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M02_L00
M02_L18:
       mov       rdi,214DE935FA0
       jmp       near ptr M02_L01
M02_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L04
M02_L20:
       call      qword ptr [7FF80C094030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L21:
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
M02_L22:
       mov       rax,rbx
       jmp       near ptr M02_L08
; Total bytes of code 1166
```

