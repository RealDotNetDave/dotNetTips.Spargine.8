## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE384F4708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FFE3839FDD0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FFE380F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,294E3990008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,294E399DFD8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE38557870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,294E3990008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,294E399E008
       mov       r9d,64
       call      qword ptr [7FFE38557870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,294E3990008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,294E399E038
       mov       r9d,32
       call      qword ptr [7FFE38557870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FFE384BFAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
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
       mov       rdx,7FFE38735AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE384F4AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746CE8]; DotNetTips.Spargine.Tester.PersonData.get_Country()
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
       mov       rdx,7FFE387361E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FFE38747240]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D50B0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746C88]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D50C0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746CB8]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D50D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746D18]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D50E0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746D48]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D50F0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FFE384BF978]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D5100]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746D78]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D5110]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38746DA8]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D5120]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE387AE448
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387E6C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE38504708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FEC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FFE38104780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,218E3420008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,218E342E028
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE38567870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,218E3420008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,218E342E058
       mov       r9d,64
       call      qword ptr [7FFE38567870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,218E3420008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,218E342E088
       mov       r9d,32
       call      qword ptr [7FFE38567870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FFE384CFAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
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
       mov       rdx,7FFE3874EEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE38504AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EF40]; DotNetTips.Spargine.Tester.PersonData.get_Country()
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
       mov       rdx,7FFE3874F610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FFE3875F498]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E50B0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EEE0]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E50C0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EF10]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E50D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EF70]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E50E0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EFA0]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E50F0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FFE384CF978]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E5100]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875EFD0]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E5110]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3875F000]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E5120]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388078D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FEC58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFE384CF9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387F5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
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
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,2
       call      qword ptr [7FFE38104780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,2A20FDB0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       xor       edx,edx
       mov       r8,2A20FDBDFD8
       mov       r9d,64
       call      qword ptr [7FFE38567870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       r9d,[rbp-24]
       mov       [rbp+10],r9d
       mov       r9d,[rbp+20]
       mov       edx,[rbp+10]
       mov       r8d,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       call      qword ptr [7FFE38504708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE385040F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 223
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE387BDA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387F5F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE38514708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,19AC78D0008
       mov       r8d,3A
       mov       r9,19AC78D8DF0
       call      qword ptr [7FFE3851CF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFE38805ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
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
       cmp       dword ptr [7FFE383BFDD0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FFE38114780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,19AC78D0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,19AC78DDFD8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE38577870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,19AC78D0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,19AC78DE008
       mov       r9d,64
       call      qword ptr [7FFE38577870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,19AC78D0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,19AC78DE038
       mov       r9d,32
       call      qword ptr [7FFE38577870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FFE384DFAE0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
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
       mov       rdx,7FFE38754FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE38514AC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38766598]; DotNetTips.Spargine.Tester.PersonData.get_Country()
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
       mov       rdx,7FFE38755700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FFE38766AF0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F50B0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38766538]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F50C0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38766568]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F50D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387665C8]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F50E0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387665F8]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F50F0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FFE384DF978]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F5100]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38766628]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F5110]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38766658]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F5120]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384F2150],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FFE38805F08]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M02_L02
       nop
       mov       rdx,19AC78D0008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M02_L07
M02_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,19AC78E2EE0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,19AC78D0008
       call      qword ptr [7FFE38577C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FFE37FB4ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FFE380661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M02_L03
       nop
       mov       r8,19AC78D5FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M02_L04
M02_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M02_L04
       nop
       mov       r8,19AC78D0008
       mov       [rbp-10],r8
       nop
M02_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFE3851CF78]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38801F20
       call      qword ptr [7FFE38064210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFE38805F98]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE380662F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M02_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380669E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38066EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M02_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M02_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FFE383BF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3887D058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38887AF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFE384BF9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       rcx,rax
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,288A2CC0008
       mov       r8d,3A
       mov       r9,288A2CC8DF0
       call      qword ptr [7FFE384FCF90]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFE387E5F80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
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
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE3839FDD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-20],rcx
       lea       rcx,[rbp-20]
       mov       edx,2
       call      qword ptr [7FFE380F4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,288A2CC0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+10]
       xor       edx,edx
       mov       r8,288A2CCDFD8
       mov       r9d,64
       call      qword ptr [7FFE38557870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       r9d,[rbp-24]
       mov       [rbp+10],r9d
       mov       r9d,[rbp+20]
       mov       edx,[rbp+10]
       mov       r8d,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       call      qword ptr [7FFE384F4708]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE384F40F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 223
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384D2150],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FFE387E5FB0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M02_L02
       nop
       mov       rdx,288A2CC0008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M02_L07
M02_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,288A2CD2EE0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,288A2CC0008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FFE37F94ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FFE380461D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M02_L03
       nop
       mov       r8,288A2CC5FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M02_L04
M02_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M02_L04
       nop
       mov       r8,288A2CC0008
       mov       [rbp-10],r8
       nop
M02_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFE384FCF78]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FFE387E1FC8
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFE387E6040]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE380462F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M02_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380469E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38046EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M02_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M02_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3885D2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38867AF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

