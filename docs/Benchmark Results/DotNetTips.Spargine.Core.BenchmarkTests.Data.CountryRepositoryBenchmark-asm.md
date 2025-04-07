## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountryByCountryId()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass6_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       qword ptr [rsi+8],0E9
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC04604030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFC04A03DE0
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFC0491E778]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
; Total bytes of code 167
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
       mov       rcx,1E6D7088728
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1A64540ABD8
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,1E6D7088728
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFC04604018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,1E6D7088728
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       [rbp+28],r9
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M02_L12
       test      rbx,rbx
       je        near ptr M02_L13
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M02_L09
M02_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-40],rdi
       mov       r14,[rdi]
       jmp       short M02_L05
M02_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L03
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r13,rax
       mov       rdx,7FFC04A03DE0
       cmp       [rbx+18],rdx
       jne       short M02_L04
       mov       rdx,[r13+0B0]
       mov       rcx,[rbx+8]
       cmp       rdx,[rcx+8]
       jne       short M02_L05
       jmp       short M02_L08
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFC04A37B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L02
M02_L04:
       mov       rdx,r13
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       short M02_L08
M02_L05:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       r14,rcx
       jne       short M02_L07
       mov       rax,rdi
       mov       ecx,[rax+8]
       inc       ecx
       mov       r15d,[rax+0C]
       cmp       ecx,r15d
       jae       short M02_L06
       mov       [rax+8],ecx
       jmp       near ptr M02_L01
M02_L06:
       mov       [rax+8],r15d
       jmp       short M02_L14
M02_L07:
       mov       rcx,rdi
       mov       r11,7FFC040109F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       jmp       near ptr M02_L01
M02_L08:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFC04A37A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       r14,rax
       jne       short M02_L15
M02_L11:
       mov       rax,r13
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L12:
       mov       ecx,10
       call      qword ptr [7FFC04457A38]
       int       3
M02_L13:
       mov       ecx,0C
       call      qword ptr [7FFC04457A38]
       int       3
M02_L14:
       mov       rcx,rsp
       call      M02_L17
       jmp       short M02_L16
M02_L15:
       mov       rcx,rdi
       mov       r11,7FFC04010A00
       call      qword ptr [r11]
       jmp       short M02_L11
M02_L16:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
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
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M02_L18
       mov       rdi,[rbp-40]
       mov       r14,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       r14,rcx
       je        short M02_L18
       mov       rcx,rdi
       mov       r11,7FFC04010A00
       call      qword ptr [r11]
M02_L18:
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
; Total bytes of code 492
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rcx,rax
       call      qword ptr [7FFC048DEAD8]; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC04614030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFC04A13DE0
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFC0492E778]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
; 		input = input.ArgumentDefined();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _descriptionCache.GetOrAdd(input, key =>
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			var field = key.GetType().GetField(key.ToString());
; 			                                                   
; 			var attributes = (EnumMemberAttribute[])field.GetCustomAttributes(typeof(EnumMemberAttribute), false);
; 			                                                                                                      
; 			return attributes.Length > 0 ? attributes[0].Value : key.ToString();
; 			                                                                    
; 		});
; 		   
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,rbx
       xor       eax,eax
       test      rcx,rcx
       setne     al
       test      eax,eax
       je        near ptr M01_L04
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,1E7F7C08C98
       mov       rsi,[rcx]
       mov       rcx,1E7F7C08AE8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
M01_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+15],0
       je        short M01_L03
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M01_L01:
       lea       rdx,[rbp-30]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,r15d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFC045A4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L10
M01_L02:
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rdx,rbx
       mov       r11,7FFC04020A18
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFC0461FB58]
       mov       ecx,13E0
       mov       rdx,7FFC0448B8C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FFC0448B8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC04166B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFC0448B8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC04166B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC0461F948]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFC042E6718]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L05:
       mov       ecx,2BD
       mov       rdx,7FFC04014000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC042E6790]
       int       3
M01_L06:
       call      qword ptr [7FFC0461FA08]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L07
       call      qword ptr [7FFC0461F960]
       mov       r14,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,22889C68180
       mov       r8,r14
       call      qword ptr [7FFC0421D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E7F7C08C80
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFC04A13EB8
       call      qword ptr [7FFC04164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E7F7C08C98
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L09:
       mov       ecx,0BB4
       mov       rdx,7FFC045902D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC047D4AE0]
       int       3
M01_L10:
       mov       byte ptr [rbp-38],1
       mov       [rbp-34],r15d
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-30]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC045A4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 667
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
       mov       rcx,22889C3FE78
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1E7F7C08BE0
       cmp       qword ptr [rbx],0
       je        short M02_L01
M02_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,22889C3FE78
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFC04614018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L00
M02_L02:
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
       mov       rcx,22889C3FE78
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M03_L19
       test      rsi,rsi
       je        near ptr M03_L20
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M03_L16
M03_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-40],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FFC04A13DE0
       cmp       r14,rcx
       jne       near ptr M03_L10
       jmp       short M03_L03
M03_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M03_L05
M03_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC041661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L14
M03_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L06
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M03_L04
       mov       [rax+8],r8d
       jmp       short M03_L01
M03_L04:
       mov       [rax+8],r14d
       jmp       near ptr M03_L21
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFC04A90E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M03_L02
M03_L06:
       mov       rcx,rdi
       mov       r11,7FFC04020A20
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M03_L21
       jmp       near ptr M03_L01
M03_L07:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M03_L12
M03_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,7FFC04A13DE0
       cmp       r14,rdx
       jne       near ptr M03_L15
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC041661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M03_L09:
       test      eax,eax
       jne       short M03_L14
M03_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L13
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r13d,[rax+0C]
       cmp       r8d,r13d
       jae       short M03_L11
       mov       [rax+8],r8d
       jmp       short M03_L07
M03_L11:
       mov       [rax+8],r13d
       jmp       near ptr M03_L21
M03_L12:
       mov       rcx,rbx
       mov       rdx,7FFC04A90E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M03_L08
M03_L13:
       mov       rcx,rdi
       mov       r11,7FFC04020A20
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L21
       jmp       near ptr M03_L07
M03_L14:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       short M03_L17
M03_L15:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M03_L09
M03_L16:
       mov       rcx,rbx
       mov       rdx,7FFC04A90D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M03_L00
M03_L17:
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M03_L22
M03_L18:
       mov       rax,r15
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       mov       ecx,10
       call      qword ptr [7FFC04467A38]
       int       3
M03_L20:
       mov       ecx,0C
       call      qword ptr [7FFC04467A38]
       int       3
M03_L21:
       mov       rcx,rsp
       call      M03_L24
       jmp       short M03_L23
M03_L22:
       mov       rcx,rdi
       mov       r11,7FFC04020A28
       call      qword ptr [r11]
       jmp       short M03_L18
M03_L23:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
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
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M03_L25
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-40]
       cmp       [rdi],rcx
       je        short M03_L25
       mov       rcx,rdi
       mov       r11,7FFC04020A28
       call      qword ptr [r11]
M03_L25:
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
; Total bytes of code 677
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rcx,rax
       call      qword ptr [7FFC048CEAD8]; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC04604030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFC04A03DE0
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFC0491E778]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       rcx,[rax+90]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       mov       rsi,1D8F14945A8
       mov       rcx,1D8F1480008
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,[rax+90]
       call      qword ptr [7FFC04A0C7F8]; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0451FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       edx,2
       xor       ecx,ecx
       test      eax,eax
       cmove     edx,ecx
M00_L00:
       mov       [rsp+28],edx
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC04A373D8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
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
; Total bytes of code 281
```
```assembly
; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
; 		input = input.ArgumentDefined();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _descriptionCache.GetOrAdd(input, key =>
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			var field = key.GetType().GetField(key.ToString());
; 			                                                   
; 			var attributes = (EnumMemberAttribute[])field.GetCustomAttributes(typeof(EnumMemberAttribute), false);
; 			                                                                                                      
; 			return attributes.Length > 0 ? attributes[0].Value : key.ToString();
; 			                                                                    
; 		});
; 		   
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,rbx
       xor       eax,eax
       test      rcx,rcx
       setne     al
       test      eax,eax
       je        near ptr M01_L04
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,1985F408C98
       mov       rsi,[rcx]
       mov       rcx,1985F408AE8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
M01_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+15],0
       je        short M01_L03
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M01_L01:
       lea       rdx,[rbp-30]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,r15d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFC04594990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L10
M01_L02:
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rdx,rbx
       mov       r11,7FFC04010A40
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFC0460FB58]
       mov       ecx,13E0
       mov       rdx,7FFC0447B8C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FFC0447B8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC04156B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFC0447B8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC04156B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC0460F948]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFC042D6718]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L05:
       mov       ecx,2BD
       mov       rdx,7FFC04004000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC042D6790]
       int       3
M01_L06:
       call      qword ptr [7FFC0460FA08]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L07
       call      qword ptr [7FFC0460F960]
       mov       r14,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1D8F1488180
       mov       r8,r14
       call      qword ptr [7FFC0420D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1985F408C80
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFC04A03EA0
       call      qword ptr [7FFC04154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1985F408C98
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L09:
       mov       ecx,0BB4
       mov       rdx,7FFC045802D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC047C4AE0]
       int       3
M01_L10:
       mov       byte ptr [rbp-38],1
       mov       [rbp-34],r15d
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-30]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC04594A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 667
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
       mov       rcx,1D8F1444928
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1985F408BE0
       cmp       qword ptr [rbx],0
       je        short M02_L01
M02_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,1D8F1444928
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFC04604018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L00
M02_L02:
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
       mov       rcx,1D8F1444928
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M03_L19
       test      rsi,rsi
       je        near ptr M03_L20
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M03_L16
M03_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-40],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FFC04A03DE0
       cmp       r14,rcx
       jne       near ptr M03_L10
       jmp       short M03_L03
M03_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M03_L05
M03_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC041561D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L14
M03_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L06
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M03_L04
       mov       [rax+8],r8d
       jmp       short M03_L01
M03_L04:
       mov       [rax+8],r14d
       jmp       near ptr M03_L21
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFC04A98338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M03_L02
M03_L06:
       mov       rcx,rdi
       mov       r11,7FFC04010A48
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M03_L21
       jmp       near ptr M03_L01
M03_L07:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M03_L12
M03_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,7FFC04A03DE0
       cmp       r14,rdx
       jne       near ptr M03_L15
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC041561D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M03_L09:
       test      eax,eax
       jne       short M03_L14
M03_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L13
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r13d,[rax+0C]
       cmp       r8d,r13d
       jae       short M03_L11
       mov       [rax+8],r8d
       jmp       short M03_L07
M03_L11:
       mov       [rax+8],r13d
       jmp       near ptr M03_L21
M03_L12:
       mov       rcx,rbx
       mov       rdx,7FFC04A98338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M03_L08
M03_L13:
       mov       rcx,rdi
       mov       r11,7FFC04010A48
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L21
       jmp       near ptr M03_L07
M03_L14:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       short M03_L17
M03_L15:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M03_L09
M03_L16:
       mov       rcx,rbx
       mov       rdx,7FFC04A98260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M03_L00
M03_L17:
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M03_L22
M03_L18:
       mov       rax,r15
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       mov       ecx,10
       call      qword ptr [7FFC04457A38]
       int       3
M03_L20:
       mov       ecx,0C
       call      qword ptr [7FFC04457A38]
       int       3
M03_L21:
       mov       rcx,rsp
       call      M03_L24
       jmp       short M03_L23
M03_L22:
       mov       rcx,rdi
       mov       r11,7FFC04010A50
       call      qword ptr [r11]
       jmp       short M03_L18
M03_L23:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
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
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M03_L25
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-40]
       cmp       [rdi],rcx
       je        short M03_L25
       mov       rcx,rdi
       mov       r11,7FFC04010A50
       call      qword ptr [r11]
M03_L25:
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
; Total bytes of code 677
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
       mov       rax,[rax+40]
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
       mov       rax,19863400438
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,19863400418
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
       mov       rax,1985F4095C0
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
       cmp       dword ptr [7FFC0450B420],0
       je        short M04_L09
       mov       rcx,1985F4095C8
       mov       rcx,[rcx]
       mov       [rsp+20],rbx
       mov       [rsp+28],rdi
       xor       edx,edx
       mov       [rsp+30],edx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rdx,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FFC04A22D68]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.Text.RegularExpressions.RegexCache+Key, System.Text.RegularExpressions],[System.__Canon, System.Private.CoreLib]].TryGetValue(Key, System.__Canon ByRef)
       test      eax,eax
       je        short M04_L09
       mov       rcx,[rsp+40]
       inc       r14
       mov       [rcx+10],r14
       mov       rdx,[rsp+40]
       mov       rcx,1985F4095C0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       r14,[rcx+8]
       jmp       near ptr M04_L05
M04_L09:
       xor       r14d,r14d
       jmp       near ptr M04_L05
M04_L10:
       mov       ecx,0C
       call      qword ptr [7FFC04A6FB88]
       int       3
M04_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M04_L00
M04_L12:
       call      qword ptr [7FFC042CE070]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFC04205068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC04205068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0451F690]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Globalization.CultureInfo)
       mov       [rsp+20],rbp
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       qword ptr [rsp+38],0FFFFFFFFFFFFD8F0
       lea       rcx,[rsp+20]
       mov       rdx,r14
       call      qword ptr [7FFC04A0C840]; System.Text.RegularExpressions.RegexCache.Add(Key, System.Text.RegularExpressions.Regex)
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
       call      qword ptr [7FFC0451F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M05_L01:
       mov       ecx,7
       call      qword ptr [7FFC04A6FB88]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFC04634030]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
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
       mov       rcx,24574C76C78
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,204EAC02C10
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,24574C76C78
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFC04634018]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,24574C76C78
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```

