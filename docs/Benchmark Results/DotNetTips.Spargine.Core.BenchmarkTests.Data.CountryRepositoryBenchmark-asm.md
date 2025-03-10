## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7E844030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF7EC43DE0
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF7EB5E778]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,240A3EC9FE8
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,2001A002C10
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,240A3EC9FE8
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7E844018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,240A3EC9FE8
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
       mov       rcx,7FFF7EC43DE0
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
       mov       rcx,2001A002CC8
       mov       r13,[rcx]
       mov       rcx,2001A002B18
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
       mov       r11,7FFF7E260A28
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
       call      qword ptr [7FFF7E7D4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L16
M02_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2001A002CB0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7EC43ED0
       mov       [r13+18],rcx
       mov       rcx,2001A002CC8
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
       call      qword ptr [7FFF7E7D4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L26
M02_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2001A002CB0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7EC43ED0
       mov       [r13+18],rcx
       mov       rcx,2001A002CC8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M02_L22
M02_L09:
       mov       ecx,2BD
       mov       rdx,7FFF7E254000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7E526790]
       int       3
M02_L10:
       call      qword ptr [7FFF7E84FA08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FFF7E84F960]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,240A3EF8180
       mov       r8,rbx
       call      qword ptr [7FFF7E45D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       ecx,0BB4
       mov       rdx,7FFF7E7C02D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EA04AE0]
       int       3
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFF7ECC08A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L14:
       mov       rcx,r12
       mov       rax,[7FFF7EC3EFF8]
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
       call      qword ptr [7FFF7E7D4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L04
M02_L16:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FFF7E3A61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       mov       r11,7FFF7E260A18
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
       mov       rcx,7FFF7EC43DE0
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
       mov       rcx,2001A002CC8
       mov       r13,[rcx]
       mov       rcx,2001A002B18
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
       mov       r11,7FFF7E260A28
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       short M02_L25
M02_L23:
       mov       rcx,rbx
       mov       rdx,7FFF7ECC08A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L21
M02_L24:
       mov       rcx,r12
       mov       rdx,[7FFF7EC3EFF8]
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
       call      qword ptr [7FFF7E7D4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L07
M02_L26:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FFF7E3A61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       mov       r11,7FFF7E260A18
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
       mov       rdx,7FFF7ECC07D0
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
       call      qword ptr [7FFF7E697A38]
       int       3
M02_L36:
       mov       ecx,0C
       call      qword ptr [7FFF7E697A38]
       int       3
M02_L37:
       mov       rcx,rdi
       mov       r11,7FFF7E260A20
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
       mov       r11,7FFF7E260A20
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7E834030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF7EC33DE0
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF7EB4E778]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       rsi,rax
       mov       rcx,[rsi+90]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       mov       rcx,2BB9D1643A8
       call      qword ptr [7FFF7E397318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,2BB9D150008
       test      rdi,rdi
       cmove     rdi,rcx
       mov       rcx,[rsi+90]
       call      qword ptr [7FFF7EC3C888]; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E74FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       edx,2
       xor       ecx,ecx
       test      eax,eax
       cmove     edx,ecx
M00_L00:
       mov       [rsp+28],edx
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7EC673D8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
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
; Total bytes of code 263
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,2BB9D134888
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,27B13002C10
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,2BB9D134888
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7E834018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,2BB9D134888
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
       mov       rcx,7FFF7EC33DE0
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
       mov       rcx,27B13002CC8
       mov       r13,[rcx]
       mov       rcx,27B13002B18
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
       mov       r11,7FFF7E250A48
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
       call      qword ptr [7FFF7E7C4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L16
M02_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,27B13002CB0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7EC33EB8
       mov       [r13+18],rcx
       mov       rcx,27B13002CC8
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
       call      qword ptr [7FFF7E7C4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L26
M02_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,27B13002CB0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7EC33EB8
       mov       [r13+18],rcx
       mov       rcx,27B13002CC8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M02_L22
M02_L09:
       mov       ecx,2BD
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7E516790]
       int       3
M02_L10:
       call      qword ptr [7FFF7E83FA08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FFF7E83F960]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BB9D158180
       mov       r8,rbx
       call      qword ptr [7FFF7E44D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       ecx,0BB4
       mov       rdx,7FFF7E7B02D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7E9F4AE0]
       int       3
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFF7ECC7C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L14:
       mov       rcx,r12
       mov       rax,[7FFF7EC2EF38]
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
       call      qword ptr [7FFF7E7C4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L04
M02_L16:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FFF7E3961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       mov       r11,7FFF7E250A38
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
       mov       rcx,7FFF7EC33DE0
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
       mov       rcx,27B13002CC8
       mov       r13,[rcx]
       mov       rcx,27B13002B18
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
       mov       r11,7FFF7E250A48
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       short M02_L25
M02_L23:
       mov       rcx,rbx
       mov       rdx,7FFF7ECC7C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L21
M02_L24:
       mov       rcx,r12
       mov       rdx,[7FFF7EC2EF38]
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
       call      qword ptr [7FFF7E7C4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L07
M02_L26:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FFF7E3961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       mov       r11,7FFF7E250A38
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
       mov       rdx,7FFF7ECC7B30
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
       call      qword ptr [7FFF7E687A38]
       int       3
M02_L36:
       mov       ecx,0C
       call      qword ptr [7FFF7E687A38]
       int       3
M02_L37:
       mov       rcx,rdi
       mov       r11,7FFF7E250A40
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
       mov       r11,7FFF7E250A40
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
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,7FFF8D3A2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF7EC9FA68]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFF8D3A2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF7EC9FA68]
       test      eax,eax
       jne       short M03_L04
M03_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7E3973F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
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
       je        near ptr M04_L10
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        near ptr M04_L11
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M04_L11
       mov       rdx,[rax]
       add       rdx,10
M04_L00:
       mov       rsi,[rdx+8]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,27B0F000438
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,27B0F000418
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M04_L12
M04_L01:
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rsi],rax
       jne       near ptr M04_L13
       mov       rdi,[rsi+40]
M04_L02:
       mov       rbp,rbx
       xor       r14d,r14d
       mov       rax,27B130035E8
       mov       r15,[rax]
       test      r15,r15
       je        short M04_L08
       mov       rdx,[r15+18]
       mov       r13,[r15+20]
       mov       r12d,[r15+28]
       mov       r14,[r15+30]
       cmp       rbx,rdx
       jne       near ptr M04_L14
M04_L03:
       mov       rax,rdi
       mov       rdx,r13
       cmp       [rax],al
       cmp       rax,rdx
       jne       near ptr M04_L15
M04_L04:
       test      r12d,r12d
       jne       short M04_L07
       cmp       r14,0FFFFFFFFFFFFD8F0
       jne       short M04_L07
       mov       r14,[r15+8]
M04_L05:
       xor       eax,eax
       mov       [rsp+40],rax
       test      r14,r14
       je        near ptr M04_L16
M04_L06:
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
M04_L07:
       mov       r14,[r15+10]
M04_L08:
       cmp       dword ptr [7FFF7E73B420],0
       je        short M04_L09
       mov       rcx,27B130035F0
       mov       rcx,[rcx]
       mov       [rsp+20],rbx
       mov       [rsp+28],rdi
       xor       edx,edx
       mov       [rsp+30],edx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rdx,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FFF7EC52D98]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.Text.RegularExpressions.RegexCache+Key, System.Text.RegularExpressions],[System.__Canon, System.Private.CoreLib]].TryGetValue(Key, System.__Canon ByRef)
       test      eax,eax
       je        short M04_L09
       mov       rcx,[rsp+40]
       inc       r14
       mov       [rcx+10],r14
       mov       rdx,[rsp+40]
       mov       rcx,27B130035E8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       r14,[rcx+8]
       jmp       near ptr M04_L05
M04_L09:
       xor       r14d,r14d
       jmp       near ptr M04_L05
M04_L10:
       mov       ecx,0C
       call      qword ptr [7FFF7EC9FDE0]
       int       3
M04_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M04_L00
M04_L12:
       call      qword ptr [7FFF7E50E070]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M04_L02
M04_L14:
       test      rdx,rdx
       je        near ptr M04_L07
       mov       r8d,[rbx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M04_L07
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF7E445068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M04_L07
       jmp       near ptr M04_L03
M04_L15:
       test      rdx,rdx
       je        near ptr M04_L07
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M04_L07
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF7E445068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M04_L07
       jmp       near ptr M04_L04
M04_L16:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFF7E74F690]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Globalization.CultureInfo)
       mov       [rsp+20],rbp
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rcx,[rsp+20]
       mov       rdx,r14
       call      qword ptr [7FFF7EC3C8D0]; System.Text.RegularExpressions.RegexCache.Add(Key, System.Text.RegularExpressions.Regex)
       jmp       near ptr M04_L06
; Total bytes of code 677
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M05_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M05_L02
       xor       ebx,ebx
M05_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFF7E74F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M05_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC9FDE0]
       int       3
M05_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M05_L00
; Total bytes of code 90
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF7E864030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
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
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,1F6B6D6E888
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1B62CC02C10
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,1F6B6D6E888
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7E864018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,1F6B6D6E888
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```

