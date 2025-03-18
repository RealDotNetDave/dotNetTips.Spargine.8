## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountryByCountryId()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0E9
       call      qword ptr [7FF9832F4828]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountry(Int64)
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
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountry(Int64)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rbx,rcx
       call      qword ptr [7FF9832F47F8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rsi,rax
       mov       rcx,[rsi+8]
       mov       r11,7FF982D10A10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L16
       mov       rcx,[rsi+8]
       mov       r11,7FF982D10A18
       call      qword ptr [r11]
       mov       rsi,rax
M01_L00:
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M01_L10
       mov       rdi,[rsi]
       mov       r14,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       rdi,r14
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L01:
       mov       r8,rsi
       mov       r10d,[r8+8]
       cmp       r10d,[r8+0C]
       jae       near ptr M01_L13
       mov       r15,[r8+10]
       cmp       r10d,[r15+8]
       jae       short M01_L04
       mov       eax,r10d
       mov       r13,[r15+rax*8+10]
M01_L02:
       cmp       [r13+0B0],rbx
       je        near ptr M01_L14
M01_L03:
       cmp       rdi,r14
       jne       short M01_L07
       mov       rax,rsi
       mov       edx,[rax+8]
       inc       edx
       mov       ecx,[rax+0C]
       cmp       edx,ecx
       jae       short M01_L05
       mov       [rax+8],edx
       jmp       short M01_L01
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       [rax+8],ecx
       jmp       near ptr M01_L17
M01_L06:
       mov       rcx,rsi
       mov       r11,7FF982D10A00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M01_L02
M01_L07:
       mov       rcx,rsi
       mov       r11,7FF982D109F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       jmp       near ptr M01_L17
M01_L08:
       mov       r8,rsi
       mov       r10d,[r8+8]
       cmp       r10d,[r8+0C]
       jae       short M01_L13
       mov       r15,[r8+10]
       cmp       r10d,[r15+8]
       jae       short M01_L04
       mov       eax,r10d
       mov       r13,[r15+rax*8+10]
M01_L09:
       cmp       [r13+0B0],rbx
       je        short M01_L14
M01_L10:
       mov       rdi,[rsi]
       mov       r14,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       rdi,r14
       jne       short M01_L12
       mov       rax,rsi
       mov       edx,[rax+8]
       inc       edx
       mov       ecx,[rax+0C]
       cmp       edx,ecx
       jae       short M01_L11
       mov       [rax+8],edx
       jmp       short M01_L08
M01_L11:
       mov       [rax+8],ecx
       jmp       short M01_L17
M01_L12:
       mov       rcx,rsi
       mov       r11,7FF982D109F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
       mov       rcx,rsi
       mov       r11,7FF982D10A00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M01_L09
M01_L13:
       mov       ecx,[r8+8]
       call      qword ptr [7FF98304EFD0]
       int       3
M01_L14:
       cmp       rdi,r14
       jne       short M01_L18
M01_L15:
       mov       rax,r13
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rcx,7FF982D95120
       mov       edx,4F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,277BE005E68
       mov       rsi,[rcx]
       jmp       near ptr M01_L00
M01_L17:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       r11,7FF982D10A08
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L19:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M01_L21
       mov       rsi,[rbp-38]
       mov       rdi,[rsi]
       mov       r14,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       rdi,r14
       je        short M01_L21
       mov       rcx,rsi
       mov       r11,7FF982D10A08
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 578
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountryByCountryName()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       ecx,[rsi+8]
       mov       [rsi+8],ecx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9832F47F8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF9836F9968
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FF9836B4318]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 172
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,228E2DDAD48
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1E851006BE8
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,228E2DDAD48
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9832F47E0]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp-10]
       mov       rcx,228E2DDAD48
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M02_L35
       test      rsi,rsi
       je        near ptr M02_L36
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M02_L33
M02_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-60],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FF9836F9968
       cmp       r14,rcx
       jne       near ptr M02_L26
       jmp       near ptr M02_L15
M02_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L13
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r14,[r15+68]
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,1E851006CA0
       mov       r13,[rcx]
       mov       rcx,1E851006AF0
       mov       r8,[rcx]
       test      r13,r13
       je        near ptr M02_L05
M02_L03:
       test      r13,r13
       je        near ptr M02_L12
       mov       r10,[r8+8]
       mov       [rbp-78],r10
       mov       rcx,[r10+8]
       mov       [rbp-70],r8
       cmp       byte ptr [r8+15],0
       jne       near ptr M02_L17
       mov       rdx,r12
       mov       r11,7FF982D10A28
       call      qword ptr [r11]
       jmp       near ptr M02_L18
M02_L04:
       mov       eax,[rbp-44]
       mov       r8,[rbp-70]
       mov       [rbp-88],r8
       mov       r9,[rbp-78]
       mov       [rbp-80],r9
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832750C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L14
M02_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1E851006C88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9836F9A58
       mov       [r13+18],rcx
       mov       rcx,1E851006CA0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       jmp       near ptr M02_L03
M02_L06:
       mov       eax,[rbp-44]
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rdx,[rbp-78]
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832750C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L24
M02_L07:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M02_L25
M02_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1E851006C88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9836F9A58
       mov       [r13+18],rcx
       mov       rcx,1E851006CA0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M02_L22
M02_L09:
       mov       ecx,2BD
       mov       rdx,7FF982D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830766E8]
       int       3
M02_L10:
       call      qword ptr [7FF983364378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FF9833642D0]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,228E2E08180
       mov       r8,rbx
       call      qword ptr [7FF982F0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       ecx,0BB4
       mov       rdx,7FF983280B68
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9834B6190]
       int       3
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF983770908
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L14:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FF982E561D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M02_L31
M02_L15:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L19
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M02_L16
       mov       [rax+8],r8d
       jmp       near ptr M02_L01
M02_L16:
       mov       [rax+8],r14d
       jmp       near ptr M02_L34
M02_L17:
       mov       rcx,r12
       mov       rax,[7FF9836EEA68]
       call      qword ptr [rax+18]
M02_L18:
       mov       r10d,eax
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],r10d
       mov       r9d,r10d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983274FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L04
       jmp       near ptr M02_L14
M02_L19:
       mov       rcx,rdi
       mov       r11,7FF982D10A18
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L34
       jmp       near ptr M02_L01
M02_L20:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L23
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,7FF9836F9968
       cmp       r14,rcx
       jne       near ptr M02_L07
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[r15+68]
       mov       [rbp-68],rcx
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,1E851006CA0
       mov       r13,[rcx]
       mov       rcx,1E851006AF0
       mov       r8,[rcx]
       mov       rax,r8
       test      r13,r13
       je        near ptr M02_L08
M02_L22:
       test      r13,r13
       je        near ptr M02_L12
       mov       rdx,[rax+8]
       mov       r8,rdx
       mov       [rbp-78],r8
       mov       rcx,[r8+8]
       mov       [rbp-70],rax
       cmp       byte ptr [rax+15],0
       jne       near ptr M02_L28
       mov       rdx,r12
       mov       r11,7FF982D10A28
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M02_L29
M02_L23:
       mov       rcx,rbx
       mov       rdx,7FF983770908
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L21
M02_L24:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FF982E561D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M02_L25:
       test      eax,eax
       jne       near ptr M02_L31
M02_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L30
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r10d,[rax+0C]
       cmp       r8d,r10d
       jae       short M02_L27
       mov       [rax+8],r8d
       jmp       near ptr M02_L20
M02_L27:
       mov       [rax+8],r10d
       jmp       near ptr M02_L34
M02_L28:
       mov       rcx,r12
       mov       rdx,[7FF9836EEA68]
       call      qword ptr [rdx+18]
       mov       r10d,eax
M02_L29:
       mov       eax,r10d
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983274FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L06
       jmp       near ptr M02_L24
M02_L30:
       mov       rcx,rdi
       mov       r11,7FF982D10A18
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L34
       jmp       near ptr M02_L20
M02_L31:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M02_L37
M02_L32:
       mov       rax,r15
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       mov       rcx,rbx
       mov       rdx,7FF983770830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L34:
       mov       rcx,rsp
       call      M02_L38
       nop
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L35:
       mov       ecx,10
       call      qword ptr [7FF983074F30]
       int       3
M02_L36:
       mov       ecx,0C
       call      qword ptr [7FF983074F30]
       int       3
M02_L37:
       mov       rcx,rdi
       mov       r11,7FF982D10A20
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L38:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+40]
       mov       [rsp+40],rbp
       lea       rbp,[rbp+0D0]
       cmp       qword ptr [rbp-60],0
       je        short M02_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-60]
       cmp       [rdi],rcx
       je        short M02_L39
       mov       rcx,rdi
       mov       r11,7FF982D10A20
       call      qword ptr [r11]
M02_L39:
       nop
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
; Total bytes of code 1731
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.ValidatePhoneNumber()
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       ecx,[rsi+8]
       mov       [rsi+8],ecx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9832E47F8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF9836E9D70
       mov       [rdi+18],r9
       lea       r9,[rsp+40]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FF9836A4318]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       rsi,rax
       mov       rcx,1B7F7B445A8
       call      qword ptr [7FF9836EDB78]; DotNetTips.Spargine.Core.RegularExpressions.RegexProcessor.GetNumbers(System.String)
       mov       rdi,rax
       mov       rcx,[rsi+80]
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],cl
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       xor       r9d,r9d
       call      qword ptr [7FF982E470C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbp,rax
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r13d,[rbp+8]
       test      r13d,r13d
       jle       short M00_L02
M00_L00:
       mov       ecx,r15d
       mov       rcx,[rbp+rcx*8+10]
       call      qword ptr [7FF9836EDB78]; DotNetTips.Spargine.Core.RegularExpressions.RegexProcessor.GetNumbers(System.String)
       mov       r12,rax
       mov       rcx,rdi
       mov       rdx,r12
       mov       r8d,5
       cmp       [rcx],ecx
       call      qword ptr [7FF982E462F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M00_L01
       inc       r15d
       cmp       r13d,r15d
       jg        short M00_L00
       jmp       short M00_L02
M00_L01:
       mov       r14d,1
       mov       edx,[r12+8]
       mov       r8d,[rdi+8]
       sub       r8d,edx
       mov       rcx,rdi
       call      qword ptr [7FF982E47240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
M00_L02:
       test      r14d,r14d
       je        short M00_L04
       mov       eax,[rdi+8]
       cmp       eax,[rsi+0B8]
       sete      al
       movzx     eax,al
M00_L03:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       xor       eax,eax
       jmp       short M00_L03
; Total bytes of code 376
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,1B7F7AA1950
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,17765C06BE8
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,1B7F7AA1950
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9832E47E0]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp-10]
       mov       rcx,1B7F7AA1950
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M02_L35
       test      rsi,rsi
       je        near ptr M02_L36
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M02_L33
M02_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-60],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FF9836E9D70
       cmp       r14,rcx
       jne       near ptr M02_L28
       jmp       near ptr M02_L17
M02_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L13
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r14,[r15+68]
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,17765C06CA0
       mov       r13,[rcx]
       mov       rcx,17765C06AF0
       mov       r8,[rcx]
       test      r13,r13
       je        near ptr M02_L05
M02_L03:
       test      r13,r13
       je        near ptr M02_L12
       mov       r10,[r8+8]
       mov       [rbp-78],r10
       mov       rcx,[r10+8]
       mov       [rbp-70],r8
       cmp       byte ptr [r8+15],0
       jne       near ptr M02_L14
       mov       rdx,r12
       mov       r11,7FF982D00A78
       call      qword ptr [r11]
       jmp       near ptr M02_L15
M02_L04:
       mov       eax,[rbp-44]
       mov       r8,[rbp-70]
       mov       [rbp-88],r8
       mov       r9,[rbp-78]
       mov       [rbp-80],r9
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832650C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L16
M02_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,17765C06C88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9836E9E48
       mov       [r13+18],rcx
       mov       rcx,17765C06CA0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       jmp       near ptr M02_L03
M02_L06:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M02_L27
M02_L07:
       mov       eax,[rbp-44]
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rdx,[rbp-78]
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832650C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L26
M02_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,17765C06C88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9836E9E48
       mov       [r13+18],rcx
       mov       rcx,17765C06CA0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M02_L22
M02_L09:
       mov       ecx,2BD
       mov       rdx,7FF982CF4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830666E8]
       int       3
M02_L10:
       call      qword ptr [7FF983354378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FF9833542D0]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7F7B38180
       mov       r8,rbx
       call      qword ptr [7FF982EFD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       ecx,0BB4
       mov       rdx,7FF983270B68
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9834A6190]
       int       3
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF983764F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L14:
       mov       rcx,r12
       mov       rax,[7FF9836DEA68]
       call      qword ptr [rax+18]
M02_L15:
       mov       r10d,eax
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],r10d
       mov       r9d,r10d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983264FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L04
M02_L16:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FF982E461D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M02_L31
M02_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L19
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M02_L18
       mov       [rax+8],r8d
       jmp       near ptr M02_L01
M02_L18:
       mov       [rax+8],r14d
       jmp       near ptr M02_L34
M02_L19:
       mov       rcx,rdi
       mov       r11,7FF982D00A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L34
       jmp       near ptr M02_L01
M02_L20:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L23
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,7FF9836E9D70
       cmp       r14,rcx
       jne       near ptr M02_L06
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[r15+68]
       mov       [rbp-68],rcx
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,17765C06CA0
       mov       r13,[rcx]
       mov       rcx,17765C06AF0
       mov       r8,[rcx]
       mov       rax,r8
       test      r13,r13
       je        near ptr M02_L08
M02_L22:
       test      r13,r13
       je        near ptr M02_L12
       mov       rdx,[rax+8]
       mov       r8,rdx
       mov       [rbp-78],r8
       mov       rcx,[r8+8]
       mov       [rbp-70],rax
       cmp       byte ptr [rax+15],0
       jne       short M02_L24
       mov       rdx,r12
       mov       r11,7FF982D00A78
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       short M02_L25
M02_L23:
       mov       rcx,rbx
       mov       rdx,7FF983764F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L21
M02_L24:
       mov       rcx,r12
       mov       rdx,[7FF9836DEA68]
       call      qword ptr [rdx+18]
       mov       r10d,eax
M02_L25:
       mov       eax,r10d
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983264FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L07
M02_L26:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FF982E461D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M02_L27:
       test      eax,eax
       jne       short M02_L31
M02_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L30
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r10d,[rax+0C]
       cmp       r8d,r10d
       jae       short M02_L29
       mov       [rax+8],r8d
       jmp       near ptr M02_L20
M02_L29:
       mov       [rax+8],r10d
       jmp       short M02_L34
M02_L30:
       mov       rcx,rdi
       mov       r11,7FF982D00A68
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L34
       jmp       near ptr M02_L20
M02_L31:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M02_L37
M02_L32:
       mov       rax,r15
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       mov       rcx,rbx
       mov       rdx,7FF983764E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L34:
       mov       rcx,rsp
       call      M02_L38
       nop
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L35:
       mov       ecx,10
       call      qword ptr [7FF983064F30]
       int       3
M02_L36:
       mov       ecx,0C
       call      qword ptr [7FF983064F30]
       int       3
M02_L37:
       mov       rcx,rdi
       mov       r11,7FF982D00A70
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L38:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+40]
       mov       [rsp+40],rbp
       lea       rbp,[rbp+0D0]
       cmp       qword ptr [rbp-60],0
       je        short M02_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-60]
       cmp       [rdi],rcx
       je        short M02_L39
       mov       rcx,rdi
       mov       r11,7FF982D00A70
       call      qword ptr [r11]
M02_L39:
       nop
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
; Total bytes of code 1707
```
```assembly
; DotNetTips.Spargine.Core.RegularExpressions.RegexProcessor.GetNumbers(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-38],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M03_L22
       mov       rcx,17765C06B68
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M03_L23
       mov       rcx,[rcx+18]
M03_L00:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M03_L26
       mov       rcx,[rsi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M03_L24
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M03_L24
M03_L01:
       mov       rdi,[rbp-38]
M03_L02:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M03_L03:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9830DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-40],rdi
       mov       rcx,17765C069E0
       mov       r14,[rcx]
       mov       r15,rbx
       test      byte ptr [r14+40],40
       jne       near ptr M03_L20
       xor       r13d,r13d
M03_L04:
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       cmp       [r15+8],r13d
       jb        near ptr M03_L19
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+20],r13d
       mov       dword ptr [rsi+24],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Text.RegularExpressions.Match, System.Text.RegularExpressions]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,17765C03E78
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+28],0
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchCollection+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r13+10],0FFFFFFFF
       mov       [rbp-48],r13
       jmp       near ptr M03_L11
M03_L05:
       mov       rcx,r13
       mov       edx,[rcx+10]
       test      edx,edx
       jl        near ptr M03_L14
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9836EEB38]; System.Text.RegularExpressions.MatchCollection.GetMatch(Int32)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L06
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       cmp       [rbx],rcx
       je        short M03_L06
       mov       rdx,rax
       call      qword ptr [7FF982E443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rbx,rax
M03_L06:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M03_L16
       mov       r14d,[rbx+10]
       mov       ebx,[rbx+14]
       mov       ecx,r14d
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        near ptr M03_L17
       test      ebx,ebx
       je        near ptr M03_L15
       cmp       eax,ebx
       je        near ptr M03_L18
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       mov       r8d,ebx
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       edx,r14d
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF982EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r15
M03_L07:
       test      rsi,rsi
       je        short M03_L11
       lea       rdx,[rsi+0C]
       mov       esi,[rsi+8]
       test      esi,esi
       je        short M03_L11
       mov       r8,[rdi+8]
       mov       r14d,[rdi+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[r8+8]
       ja        short M03_L10
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jg        short M03_L12
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       je        short M03_L09
M03_L08:
       add       esi,r14d
       mov       [rdi+18],esi
       jmp       short M03_L11
M03_L09:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M03_L08
M03_L10:
       mov       rcx,rdi
       mov       r8d,esi
       call      qword ptr [7FF9830DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M03_L11:
       mov       rbx,r13
       mov       edx,[rbx+10]
       cmp       edx,0FFFFFFFE
       je        near ptr M03_L21
       inc       edx
       mov       [rbx+10],edx
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9836EEB38]; System.Text.RegularExpressions.MatchCollection.GetMatch(Int32)
       test      rax,rax
       je        short M03_L13
       jmp       near ptr M03_L05
M03_L12:
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF982EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L08
M03_L13:
       mov       dword ptr [rbx+10],0FFFFFFFE
       jmp       short M03_L21
M03_L14:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98375D1E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF983066718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rsi,1B7F7B30008
       jmp       near ptr M03_L07
M03_L16:
       mov       rsi,1B7F7B30008
       jmp       near ptr M03_L07
M03_L17:
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF982E47258]
       int       3
M03_L18:
       jmp       near ptr M03_L07
M03_L19:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF98375C198]
       int       3
M03_L20:
       mov       r15,rbx
       mov       r13d,[r15+8]
       jmp       near ptr M03_L04
M03_L21:
       mov       rcx,rdi
       call      qword ptr [7FF9830CEB18]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M03_L27
       nop
       mov       rax,[rbp-50]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L22:
       mov       ecx,13E0
       mov       rdx,7FF98315BBC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830666E8]
       int       3
M03_L23:
       call      qword ptr [7FF983235E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M03_L00
M03_L24:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835AEF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L25
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M03_L01
M03_L25:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M03_L02
M03_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M03_L03
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,17765C06B68
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M03_L28
       mov       rdi,[rbp-40]
       call      qword ptr [7FF983235E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M03_L29
M03_L28:
       mov       rbx,[rcx+18]
M03_L29:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       near ptr M03_L34
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M03_L30
       mov       rdi,[rbp-40]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M03_L35
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9830DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L31
M03_L30:
       mov       rdi,[rbp-40]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M03_L35
M03_L31:
       cmp       qword ptr [rbx+20],0
       jne       short M03_L32
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L35
M03_L32:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M03_L33
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9835AEEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M03_L35
M03_L33:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M03_L35
M03_L34:
       mov       rdi,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L35:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1280
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,0E56987A83E21
       mov       [rbp],rax
       mov       rbx,rcx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jl        near ptr M04_L11
       test      edi,0FFFFFFFC
       jne       near ptr M04_L12
       cmp       esi,1
       jle       short M04_L01
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        short M04_L01
       cmp       dword ptr [rdx+8],0
       je        near ptr M04_L13
M04_L00:
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+58],rcx
       mov       dword ptr [rbp+60],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       lea       rcx,[rbx+0C]
       mov       [rbp+38],rcx
       mov       [rbp+40],r14d
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       lea       rcx,[rbp+38]
       lea       rdx,[rbp+28]
       lea       r8,[rbp+48]
       call      qword ptr [7FF982E471B0]; System.String.MakeSeparatorListAny(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+50]
       cmp       eax,[rbp+60]
       ja        short M04_L05
       mov       r8,[rbp+58]
       test      eax,eax
       jne       short M04_L06
       mov       esi,1
M04_L01:
       test      esi,esi
       je        near ptr M04_L16
       mov       r14,rbx
       test      dil,2
       jne       near ptr M04_L14
       test      dil,1
       jne       near ptr M04_L15
M04_L02:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M04_L03:
       mov       rcx,0E56987A83E21
       cmp       [rbp],rcx
       je        short M04_L04
       call      CORINFO_HELP_FAIL_FAST
M04_L04:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L05:
       call      qword ptr [7FF98303E9D0]
       int       3
M04_L06:
       test      edi,edi
       jne       short M04_L07
       xor       edi,edi
       mov       [rbp+18],r8
       mov       [rbp+20],eax
       mov       [rbp+8],rdi
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],esi
       mov       rcx,rbx
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FF982E47180]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M04_L08
M04_L07:
       xor       ecx,ecx
       mov       [rbp+18],r8
       mov       [rbp+20],eax
       mov       [rbp+8],rcx
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],esi
       mov       [rsp+28],edi
       mov       rcx,rbx
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FF982E47198]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M04_L08:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M04_L09
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,17765C03E30
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9835C7128]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M04_L09:
       mov       rax,r14
       mov       rcx,0E56987A83E21
       cmp       [rbp],rcx
       je        short M04_L10
       call      CORINFO_HELP_FAIL_FAST
M04_L10:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L11:
       mov       ecx,1C7
       mov       rdx,7FF982CF4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF983714BA0]
       int       3
M04_L12:
       mov       ecx,45
       mov       edx,59
       call      qword ptr [7FF98303ECB8]
       int       3
M04_L13:
       mov       ecx,edi
       and       ecx,0FFFFFFFD
       cmp       r14d,esi
       cmovl     edi,ecx
       jmp       near ptr M04_L00
M04_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF982E47318]; System.String.Trim()
       mov       r14,rax
       test      dil,1
       je        near ptr M04_L02
M04_L15:
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L02
M04_L16:
       mov       rcx,7FF982D85120
       mov       edx,5D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,17765C03E80
       mov       rax,[rax]
       jmp       near ptr M04_L03
; Total bytes of code 654
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
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
       mov       edi,r8d
M05_L00:
       test      rsi,rsi
       je        near ptr M05_L08
       cmp       rbx,rsi
       jne       short M05_L02
       cmp       edi,5
       ja        near ptr M05_L09
M05_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M05_L03
       cmp       edi,5
       ja        near ptr M05_L09
       jmp       short M05_L01
M05_L03:
       cmp       edi,5
       ja        near ptr M05_L12
       mov       eax,edi
       lea       rcx,[7FF98362A5F0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M05_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF982FE4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FF983236A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M05_L07
       test      byte ptr [7FF982D8539F],1
       je        near ptr M05_L10
M05_L04:
       mov       rcx,17769C003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FF983236A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M05_L05
       cmp       ebp,1
       je        near ptr M05_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF982EF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M05_L06
       call      qword ptr [7FF98321E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M05_L07
M05_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      qword ptr [7FF98321E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M05_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L08:
       mov       ecx,2E5
       mov       rdx,7FF982CF4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830666E8]
       int       3
M05_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF98303ECB8]
       int       3
M05_L10:
       mov       rcx,7FF982D85120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M05_L04
M05_L11:
       mov       ecx,27
       call      qword ptr [7FF98303ED00]
       int       3
M05_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9833A5338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF982CF4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF982E4F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       eax,edi
       mov       ecx,ebx
       add       rax,rcx
       mov       ecx,[rsi+8]
       mov       edx,ecx
       cmp       rax,rdx
       ja        short M06_L01
       test      ebx,ebx
       je        short M06_L02
       cmp       ecx,ebx
       je        short M06_L00
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF982EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF982E47258]
       int       3
M06_L02:
       mov       rax,1B7F7B30008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.ValidatePostalCode()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       ecx,[rsi+8]
       mov       [rsi+8],ecx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9833047F8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF983709BD8
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FF9836C4318]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       rcx,[rax+90]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       mov       rsi,15767CD45A8
       mov       rcx,15767CC0008
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,[rax+90]
       call      qword ptr [7FF98370E5E0]; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983234558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       edx,2
       xor       ecx,ecx
       test      eax,eax
       cmove     edx,ecx
M00_L00:
       mov       [rsp+28],edx
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98373D650]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       edx,1
       jmp       short M00_L00
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,15767C98638
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,116D6008BE0
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,15767C98638
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9833047E0]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp-10]
       mov       rcx,15767C98638
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M02_L35
       test      rsi,rsi
       je        near ptr M02_L36
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M02_L33
M02_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-60],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FF983709BD8
       cmp       r14,rcx
       jne       near ptr M02_L28
       jmp       near ptr M02_L17
M02_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L13
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r14,[r15+68]
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,116D6008C98
       mov       r13,[rcx]
       mov       rcx,116D6008AE8
       mov       r8,[rcx]
       test      r13,r13
       je        near ptr M02_L05
M02_L03:
       test      r13,r13
       je        near ptr M02_L12
       mov       r10,[r8+8]
       mov       [rbp-78],r10
       mov       rcx,[r10+8]
       mov       [rbp-70],r8
       cmp       byte ptr [r8+15],0
       jne       near ptr M02_L14
       mov       rdx,r12
       mov       r11,7FF982D20A48
       call      qword ptr [r11]
       jmp       near ptr M02_L15
M02_L04:
       mov       eax,[rbp-44]
       mov       r8,[rbp-70]
       mov       [rbp-88],r8
       mov       r9,[rbp-78]
       mov       [rbp-80],r9
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832850C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L16
M02_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,116D6008C80
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983709CB0
       mov       [r13+18],rcx
       mov       rcx,116D6008C98
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       jmp       near ptr M02_L03
M02_L06:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M02_L27
M02_L07:
       mov       eax,[rbp-44]
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rdx,[rbp-78]
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9832850C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L26
M02_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,116D6008C80
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983709CB0
       mov       [r13+18],rcx
       mov       rcx,116D6008C98
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M02_L22
M02_L09:
       mov       ecx,2BD
       mov       rdx,7FF982D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830866E8]
       int       3
M02_L10:
       call      qword ptr [7FF983374378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FF9833742D0]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,15767CC8180
       mov       r8,rbx
       call      qword ptr [7FF982F1D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       ecx,0BB4
       mov       rdx,7FF983290B68
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9834C6190]
       int       3
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF983797948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L14:
       mov       rcx,r12
       mov       rax,[7FF9836FEF38]
       call      qword ptr [rax+18]
M02_L15:
       mov       r10d,eax
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],r10d
       mov       r9d,r10d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983284FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L04
M02_L16:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FF982E661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M02_L31
M02_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L19
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M02_L18
       mov       [rax+8],r8d
       jmp       near ptr M02_L01
M02_L18:
       mov       [rax+8],r14d
       jmp       near ptr M02_L34
M02_L19:
       mov       rcx,rdi
       mov       r11,7FF982D20A38
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L34
       jmp       near ptr M02_L01
M02_L20:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L23
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,7FF983709BD8
       cmp       r14,rcx
       jne       near ptr M02_L06
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[r15+68]
       mov       [rbp-68],rcx
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,116D6008C98
       mov       r13,[rcx]
       mov       rcx,116D6008AE8
       mov       r8,[rcx]
       mov       rax,r8
       test      r13,r13
       je        near ptr M02_L08
M02_L22:
       test      r13,r13
       je        near ptr M02_L12
       mov       rdx,[rax+8]
       mov       r8,rdx
       mov       [rbp-78],r8
       mov       rcx,[r8+8]
       mov       [rbp-70],rax
       cmp       byte ptr [rax+15],0
       jne       short M02_L24
       mov       rdx,r12
       mov       r11,7FF982D20A48
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       short M02_L25
M02_L23:
       mov       rcx,rbx
       mov       rdx,7FF983797948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L21
M02_L24:
       mov       rcx,r12
       mov       rdx,[7FF9836FEF38]
       call      qword ptr [rdx+18]
       mov       r10d,eax
M02_L25:
       mov       eax,r10d
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF983284FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L07
M02_L26:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FF982E661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M02_L27:
       test      eax,eax
       jne       short M02_L31
M02_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M02_L30
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r10d,[rax+0C]
       cmp       r8d,r10d
       jae       short M02_L29
       mov       [rax+8],r8d
       jmp       near ptr M02_L20
M02_L29:
       mov       [rax+8],r10d
       jmp       short M02_L34
M02_L30:
       mov       rcx,rdi
       mov       r11,7FF982D20A38
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L34
       jmp       near ptr M02_L20
M02_L31:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M02_L37
M02_L32:
       mov       rax,r15
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       mov       rcx,rbx
       mov       rdx,7FF983797870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L34:
       mov       rcx,rsp
       call      M02_L38
       nop
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L35:
       mov       ecx,10
       call      qword ptr [7FF983084F30]
       int       3
M02_L36:
       mov       ecx,0C
       call      qword ptr [7FF983084F30]
       int       3
M02_L37:
       mov       rcx,rdi
       mov       r11,7FF982D20A40
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L38:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+40]
       mov       [rsp+40],rbp
       lea       rbp,[rbp+0D0]
       cmp       qword ptr [rbp-60],0
       je        short M02_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-60]
       cmp       [rdi],rcx
       je        short M02_L39
       mov       rcx,rdi
       mov       r11,7FF982D20A40
       call      qword ptr [r11]
M02_L39:
       nop
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
; Total bytes of code 1707
```
```assembly
; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M03_L10
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        near ptr M03_L11
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L11
       mov       rdx,[rax]
       add       rdx,10
M03_L00:
       mov       rsi,[rdx+8]
       test      rsi,rsi
       jne       short M03_L01
       mov       rax,116D6000438
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M03_L01
       mov       rax,116D6000418
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M03_L12
M03_L01:
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rsi],rax
       jne       near ptr M03_L13
       mov       rdi,[rsi+40]
M03_L02:
       mov       rbp,rbx
       xor       r14d,r14d
       mov       rax,116D60095C0
       mov       r15,[rax]
       test      r15,r15
       je        short M03_L08
       mov       rdx,[r15+18]
       mov       r13,[r15+20]
       mov       r12d,[r15+28]
       mov       r14,[r15+30]
       cmp       rbx,rdx
       jne       near ptr M03_L14
M03_L03:
       mov       rax,rdi
       mov       rdx,r13
       cmp       [rax],al
       cmp       rax,rdx
       jne       near ptr M03_L15
M03_L04:
       test      r12d,r12d
       jne       short M03_L07
       cmp       r14,0FFFFFFFFFFFFD8F0
       jne       short M03_L07
       mov       r14,[r15+8]
M03_L05:
       xor       eax,eax
       mov       [rsp+40],rax
       test      r14,r14
       je        near ptr M03_L16
M03_L06:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       mov       r14,[r15+10]
M03_L08:
       cmp       dword ptr [7FF98320BA60],0
       je        short M03_L09
       mov       rcx,116D60095C8
       mov       rcx,[rcx]
       mov       [rsp+20],rbx
       mov       [rsp+28],rdi
       xor       edx,edx
       mov       [rsp+30],edx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rdx,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FF983722D98]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.Text.RegularExpressions.RegexCache+Key, System.Text.RegularExpressions],[System.__Canon, System.Private.CoreLib]].TryGetValue(Key, System.__Canon ByRef)
       test      eax,eax
       je        short M03_L09
       mov       rcx,[rsp+40]
       inc       r14
       mov       [rcx+10],r14
       mov       rdx,[rsp+40]
       mov       rcx,116D60095C0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       r14,[rcx+8]
       jmp       near ptr M03_L05
M03_L09:
       xor       r14d,r14d
       jmp       near ptr M03_L05
M03_L10:
       mov       ecx,0C
       call      qword ptr [7FF9837B5E30]
       int       3
M03_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M03_L00
M03_L12:
       call      qword ptr [7FF983004030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       near ptr M03_L01
M03_L13:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M03_L02
M03_L14:
       test      rdx,rdx
       je        near ptr M03_L07
       mov       r8d,[rbx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L07
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF982F15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L07
       jmp       near ptr M03_L03
M03_L15:
       test      rdx,rdx
       je        near ptr M03_L07
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L07
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF982F15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L07
       jmp       near ptr M03_L04
M03_L16:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FF983234060]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Globalization.CultureInfo)
       mov       [rsp+20],rbp
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rcx,[rsp+20]
       mov       rdx,r14
       call      qword ptr [7FF98370E628]; System.Text.RegularExpressions.RegexCache.Add(Key, System.Text.RegularExpressions.Regex)
       jmp       near ptr M03_L06
; Total bytes of code 677
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M04_L02
       xor       ebx,ebx
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9832342E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M04_L01:
       mov       ecx,7
       call      qword ptr [7FF9837B5E30]
       int       3
M04_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M04_L00
; Total bytes of code 90
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9833047F8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
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
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,18A3921DCD8
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,149AB408BE0
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,18A3921DCD8
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9833047E0]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp-10]
       mov       rcx,18A3921DCD8
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```

