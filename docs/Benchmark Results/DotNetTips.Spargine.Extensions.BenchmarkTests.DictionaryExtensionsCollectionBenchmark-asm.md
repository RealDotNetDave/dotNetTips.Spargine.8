## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82D86538]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82D5DB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,23C67740390
       mov       rdx,23C67740210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23C67740008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829ACC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82726670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,23C67749D28
       mov       rdx,23C67740210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23C67740008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,23C6774B6E8
       mov       rdx,23C67740210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23C67740008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82D5DC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82D94810]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82D6BC08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2C33B100390
       mov       rdx,2C33B100210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C33B100008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829BCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2C33B109D28
       mov       rdx,2C33B100210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C33B100008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2C33B10B6E8
       mov       rdx,2C33B100210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C33B100008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82D6BCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82DA6838]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82D7DB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,21915DA0390
       mov       rdx,21915DA0210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21915DA0008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829CCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82746670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,21915DA9D28
       mov       rdx,21915DA0210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21915DA0008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,21915DAB6E8
       mov       rdx,21915DA0210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21915DA0008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82D7DC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82DEE070]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82DCB580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,23CC3D10390
       mov       rdx,23CC3D10210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23CC3D10008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829ECC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82766670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,23CC3D19D28
       mov       rdx,23CC3D10210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23CC3D10008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829ECC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,23CC3D1B6E8
       mov       rdx,23CC3D10210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23CC3D10008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829ECC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82DCB620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82EAC9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82E8C2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,1AD28380390
       mov       rdx,1AD28380210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1AD28380008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829CCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82746670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,1AD28389D28
       mov       rdx,1AD28380210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1AD28380008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,1AD2838B6E8
       mov       rdx,1AD28380210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1AD28380008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82E8C350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82EAE070]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82E992D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1CD805A0390
       mov       rdx,1CD805A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1CD805A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829BCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1CD805A9D28
       mov       rdx,1CD805A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1CD805A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1CD805AB6E8
       mov       rdx,1CD805A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1CD805A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82E99370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82EAC810]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82E990C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,30415840390
       mov       rdx,30415840210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30415840008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829BCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,30415849D28
       mov       rdx,30415840210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30415840008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,3041584B6E8
       mov       rdx,30415840210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30415840008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82E99168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF82EAC9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M01_L03
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rcx,[rdi+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFF82E895F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
M01_L02:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,22996070390
       mov       rdx,22996070210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22996070008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFF829BCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,22996079D28
       mov       rdx,22996070210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22996070008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L09
M01_L08:
       mov       ecx,1
M01_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2299607B6E8
       mov       rdx,22996070210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22996070008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L16
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdi
       mov       rdx,7FFF82E89690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+28],rbp
       jmp       near ptr M01_L02
; Total bytes of code 1070
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,20EA5C08D58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82D85FB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20EA5C08D50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824C4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20EA5C08D58
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,20EADC001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82DFF2F0]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82D5DA20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,20EADC001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82DFF2F0]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82D5DA20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF82380D30
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFF82D5D948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF82795B90]; System.DateTime.get_UtcNow()
       mov       rcx,[rbx+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       mov       rdx,4000000000000000
       or        rcx,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       and       rcx,rdx
       sub       rax,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFF82DFF4F8]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,7FFF82EA5404
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,7FFF82EA5400
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFF824C41F8]
       int       3
; Total bytes of code 82
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1E97640AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82D86628]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E97640AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824C4210]
       mov       rcx,1E97640AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1E9764001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82DFD350]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82D5DCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1E9764001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82DFD350]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82D5DCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF82380D30
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFF82D5DBC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF82795B90]; System.DateTime.get_UtcNow()
       mov       rcx,[rbx+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       mov       rdx,4000000000000000
       or        rcx,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       and       rcx,rdx
       sub       rax,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFF82DFD558]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1EF9A40AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82DC6628]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EF9A40AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82504210]
       mov       rcx,1EF9A40AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-70],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
       test      rbx,rbx
       je        near ptr M01_L19
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L15
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       near ptr M01_L09
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L07
M01_L02:
       lea       rdx,[rbp-38]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L08
       mov       r14,[rbp-30]
       mov       [rbp-60],r14
       cmp       [r14],r14b
       lea       rcx,[rbp-40]
       mov       rax,7FF81A505350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,1EF9A4001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L06
M01_L03:
       mov       edx,0B2D05E00
       cmp       rdi,rdx
       jae       near ptr M01_L11
       add       rdi,[rbx+10]
M01_L04:
       mov       r14,[rbp-60]
       mov       rdx,[r14+48]
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdi
       mov       rax,4000000000000000
       or        rcx,rax
       mov       rax,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,4000000000000000
       or        rdx,rax
       mov       rax,3FFFFFFFFFFFFFFF
       and       rcx,rax
       and       rdx,rax
       sub       rcx,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rcx
       vdivsd    xmm0,xmm0,[7FFF82E3D610]
       vxorps    xmm1,xmm1,xmm1
       xor       ebx,ebx
       vucomisd  xmm0,xmm1
       seta      bl
       test      ebx,ebx
       mov       rax,[rbp-58]
       mov       rbx,[rbp+20]
       je        short M01_L09
       jmp       near ptr M01_L16
M01_L05:
       call      qword ptr [7FFF8273EFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFF82D9DCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L08:
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       lea       rdx,[rbp-50]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L16
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L14
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       short M01_L05
M01_L10:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       mov       r14d,[rdx+38]
       cmp       ecx,r14d
       jb        short M01_L13
       mov       rax,[rbp-58]
       inc       r14d
       mov       [rdi+0C],r14d
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L20
M01_L11:
       call      qword ptr [7FFF827D5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rdi,rax
       jmp       near ptr M01_L04
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rdx,[rdx+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L12
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L10
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rax
       mov       r11,7FFF823C0D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFF82D9DBC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L21
M01_L17:
       mov       eax,1
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      qword ptr [7FFF82764F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FFF82764F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FFF823C0D38
       call      qword ptr [r11]
       jmp       short M01_L17
M01_L22:
       xor       eax,eax
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L23:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L24
       mov       rcx,rax
       mov       r11,7FFF823C0D38
       call      qword ptr [r11]
M01_L24:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 844
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF827D5B90]; System.DateTime.get_UtcNow()
       mov       rcx,[rbx+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       mov       rdx,4000000000000000
       or        rcx,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       and       rcx,rdx
       sub       rax,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFF82E3D808]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,20F9500AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82DADBD8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20F9500AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824C4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20F9500AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,20F950001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E11130]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82D8B6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,20F950001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E11130]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82D8B6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF82380E28
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFF82D8B5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF82380E30
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF82380E30
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF82795B90]; System.DateTime.get_UtcNow()
       mov       rcx,[rbx+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       mov       rdx,4000000000000000
       or        rcx,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rax,rdx
       and       rcx,rdx
       sub       rax,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFF82E11338]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,7FFF82EB9D34
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,7FFF82EB9D30
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFF824C41F8]
       int       3
; Total bytes of code 82
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1EB69C0AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82E86EB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EB69C0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E82C58
       call      qword ptr [7FFF824F4210]
       mov       rcx,1EB69C0AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82E82C58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1EB69C001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E332F0]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82E6D5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82E82C58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1EB69C001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E332F0]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82E6D5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF823B0E60
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFF82E6D4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF823B0E68
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF823B0E68
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,241CE40AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82EAD458]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,241CE40AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82EA9200
       call      qword ptr [7FFF824D4210]
       mov       rcx,241CE40AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82EA9200
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,241CE4001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D36510]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82E991C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82EA9200
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,241CE4001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D36510]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82E991C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF82391288
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,offset System.Runtime.CompilerServices.Unsafe.WriteUnaligned[[System.Int32, System.Private.CoreLib]](Byte ByRef, Int32)
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82734F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF82391290
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF82391290
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1B311408D58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82EDCAB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B311408D50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82ED8858
       call      qword ptr [7FFF82504210]
       mov       rcx,1B311408D58
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L30
       test      rbx,rbx
       je        near ptr M01_L31
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L27
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L16
       jmp       near ptr M01_L08
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L06
M01_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82ED8858
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1B3154001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L24
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L25
       add       rbx,[r13+10]
M01_L04:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D57950]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L08
       jmp       near ptr M01_L28
M01_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFF82EC9410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L08:
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L09:
       mov       r8d,[rdi+0C]
       mov       r14,[rdi]
       cmp       r8d,[r14+38]
       jae       near ptr M01_L26
       mov       r14,[r14+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       near ptr M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L09
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L14
M01_L11:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-70]
       call      qword ptr [r11]
       mov       rcx,7FFF82ED8858
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,1B3154001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L05
M01_L12:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L20
       add       rbx,[r13+10]
M01_L13:
       mov       r13,[rbp-78]
       mov       r12,[r13+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r12
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D57950]
       vxorps    xmm1,xmm1,xmm1
       xor       r10d,r10d
       vucomisd  xmm0,xmm1
       seta      r10b
       test      r10d,r10d
       mov       rax,[rbp-70]
       mov       rbx,[rbp+20]
       je        short M01_L16
       jmp       near ptr M01_L28
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF82EC9410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rdx,[rbp-68]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r10d,eax
       test      r10d,r10d
       mov       rax,[rbp-70]
       jne       near ptr M01_L28
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L23
M01_L17:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       cmp       r8d,[rcx+38]
       jae       short M01_L18
       mov       rcx,[rdi]
       mov       r14,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r14+8]
       jae       short M01_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       dword ptr [r15+14],0FFFFFFFF
       jl        short M01_L17
       mov       rdx,[r15]
       mov       r13,[r15+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rbp-70]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L22
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       call      qword ptr [7FFF827D5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FFF823C12E0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FFF8273EFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FFF827D5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L26:
       mov       rax,[rbp-70]
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M01_L32
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFF82EC9338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L33
M01_L29:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,10
       call      qword ptr [7FFF82764F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FFF82764F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FFF823C12E8
       call      qword ptr [r11]
       jmp       short M01_L29
M01_L34:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-70],0
       je        short M01_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M01_L36
       mov       rcx,rax
       mov       r11,7FFF823C12E8
       call      qword ptr [r11]
M01_L36:
       nop
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
; Total bytes of code 1420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1A769C0AD50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFF82ECCAB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A769C0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82EC8858
       call      qword ptr [7FFF824F4210]
       mov       rcx,1A769C0AD50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-70],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
       test      rbx,rbx
       je        near ptr M01_L19
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L15
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       near ptr M01_L09
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L07
M01_L02:
       lea       rdx,[rbp-38]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,7FFF82EC8858
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L08
       mov       r14,[rbp-30]
       mov       [rbp-60],r14
       cmp       [r14],r14b
       lea       rcx,[rbp-40]
       mov       rax,7FF81A505350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,1A769C001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L06
M01_L03:
       mov       edx,0B2D05E00
       cmp       rdi,rdx
       jae       near ptr M01_L11
       add       rdi,[rbx+10]
M01_L04:
       mov       r14,[rbp-60]
       mov       rdx,[r14+48]
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdi
       mov       rax,4000000000000000
       or        rcx,rax
       mov       rax,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,4000000000000000
       or        rdx,rax
       mov       rax,3FFFFFFFFFFFFFFF
       and       rcx,rax
       and       rdx,rax
       sub       rcx,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rcx
       vdivsd    xmm0,xmm0,[7FFF82D48AD0]
       vxorps    xmm1,xmm1,xmm1
       xor       ebx,ebx
       vucomisd  xmm0,xmm1
       seta      bl
       test      ebx,ebx
       mov       rax,[rbp-58]
       mov       rbx,[rbp+20]
       je        short M01_L09
       jmp       near ptr M01_L16
M01_L05:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFF82EA9730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L08:
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       lea       rdx,[rbp-50]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L16
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L14
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       short M01_L05
M01_L10:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       mov       r14d,[rdx+38]
       cmp       ecx,r14d
       jb        short M01_L13
       mov       rax,[rbp-58]
       inc       r14d
       mov       [rdi+0C],r14d
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L20
M01_L11:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rdi,rax
       jmp       near ptr M01_L04
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rdx,[rdx+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L12
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L10
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rax
       mov       r11,7FFF823B1338
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFF82EA9658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L21
M01_L17:
       mov       eax,1
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FFF823B1340
       call      qword ptr [r11]
       jmp       short M01_L17
M01_L22:
       xor       eax,eax
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L23:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L24
       mov       rcx,rax
       mov       r11,7FFF823B1340
       call      qword ptr [r11]
M01_L24:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 844
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82380D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82380D40
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,229CEBE9D28
       mov       rdx,229CEBE0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,229CEBE0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,229CEBEB6E8
       mov       rdx,229CEBE0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,229CEBE0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF826FEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,229CEBE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829ACE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFFE1E85308]
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
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82390D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82390D40
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF82390D38
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829EC348]
       mov       rcx,24EC2F49D28
       mov       rdx,24EC2F40210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24EC2F40008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829EC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829E7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
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
M00_L06:
       call      qword ptr [7FFF829EC348]
       mov       rcx,24EC2F4B6E8
       mov       rdx,24EC2F40210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24EC2F40008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829EC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829E7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
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
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8270EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,24EC2F40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829EC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829E7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829EC678]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFFE1E85308]
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
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B0D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B0D40
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF823B0D38
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF82A0C348]
       mov       rcx,1C556A99D28
       mov       rdx,1C556A90210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C556A90008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF82860C58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF82860C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF82A0C348]
       mov       rcx,1C556A9B6E8
       mov       rdx,1C556A90210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C556A90008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF82860C58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF82860C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8272EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1C556A90008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF82A0C468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF82A07AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF82A0C678]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFFE1E85308]
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
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82390E18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82390E28
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF82390E20
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1F06FD49D28
       mov       rdx,1F06FD40210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F06FD40008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1F06FD4B6E8
       mov       rdx,1F06FD40210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F06FD40008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8270EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1F06FD40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L06
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       short M03_L06
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L05
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       short M03_L05
M03_L03:
       mov       rcx,7FFF82E8DDC8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FFF82E8DDCC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L05:
       mov       rcx,7FFF82E8DDD0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       mov       rcx,7FFF82E8DDD4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823A0E48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823A0E58
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF823A0E50
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,1E17FD09D28
       mov       rdx,1E17FD00210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E17FD00008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,1E17FD0B6E8
       mov       rdx,1E17FD00210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E17FD00008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8271EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1E17FD00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829CCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829CC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829CCE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L06
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82EA7138]
       test      eax,eax
       jne       short M03_L06
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L05
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82EA7138]
       test      eax,eax
       jne       short M03_L05
M03_L03:
       mov       rcx,7FFF82E9D248
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FFF82E9D24C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L05:
       mov       rcx,7FFF82E9D250
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       mov       rcx,7FFF82E9D254
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B1328
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B1338
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF823B1330
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,2E615369D28
       mov       rdx,2E615360210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2E615360008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,2E61536B6E8
       mov       rdx,2E615360210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2E615360008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8272EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2E615360008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82CAE2B0]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82CAE2B0]
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
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B12E0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF823B12F0
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF823B12E8
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,2CA42389D28
       mov       rdx,2CA42380210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2CA42380008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,2CA4238B6E8
       mov       rdx,2CA42380210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2CA42380008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8272EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2CA42380008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82CAE1C0]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82CAE1C0]
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
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rdi,[rbx+40]
       mov       rbp,[rdi+30]
       test      rdi,rdi
       je        short M00_L01
       xor       ecx,ecx
       test      rbp,rbp
       setne     cl
       test      ecx,ecx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82391310
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFF82391320
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFF82391318
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
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
M00_L02:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,23620CC9D28
       mov       rdx,23620CC0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23620CC0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,23620CCB6E8
       mov       rdx,23620CC0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23620CC0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L08
M00_L07:
       mov       ecx,1
M00_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L09
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 738
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF8270EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,23620CC0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M02_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82C8E2B0]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82C8E2B0]
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
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82DB6B50]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,2C22B77B6E8
       mov       rdx,2C22B770210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C22B770008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82DB7DC8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82DBCE10]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F71E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F71E78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F72100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F72120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DC5100]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823B0C98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F72140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F71E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F72100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82DBCE40]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,2C22B770008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82DB6850]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF82A0C348]
       mov       rcx,14548A4B6E8
       mov       rdx,14548A40210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,14548A40008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82DB7AC8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82DBCE10]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F71BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F71BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F71E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F71E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DC5530]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823B0C98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F71EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F71BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F71E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82DBCE40]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,14548A40008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF82A0C468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF82A07AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF82A0C678]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82DB6B50]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1961C98B6E8
       mov       rdx,1961C980210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1961C980008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82DB7DC8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82DBCE10]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F71F98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F71FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F72238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F72258
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DC5100]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823B0C98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F72278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F71F98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F72238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82DBCE40]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,1961C980008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82DCD830]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1BA411AB6E8
       mov       rdx,1BA411A0210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1BA411A0008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82DCEAA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82DCF930]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F85EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F85EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F86150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F86170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DE0DB8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823B0D80
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F86190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F85EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F86150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82DCF960]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B0D88
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823B0D88
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,1BA411A0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L06
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82EAE940]
       test      eax,eax
       jne       short M04_L06
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L05
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82EAE940]
       test      eax,eax
       jne       short M04_L05
M04_L03:
       mov       rcx,7FFF82ED7638
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFF82ED763C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L05:
       mov       rcx,7FFF82ED7640
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       rcx,7FFF82ED7644
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82E8C4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,2CB159DB6E8
       mov       rdx,2CB159D0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2CB159D0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82E8D728]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82E8E5B0]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F65E68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F65E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F66108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F66128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82E906C8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF82380F70
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F66148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF826EF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827266E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F65E68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F66108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82E8E5E0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF82380F78
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF82380F78
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF826FEF10]
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
       mov       rax,2CB159D0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829ACE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L06
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C941B0]
       test      eax,eax
       jne       short M04_L06
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L05
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C941B0]
       test      eax,eax
       jne       short M04_L05
M04_L03:
       mov       rcx,7FFF82E949A0
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFF82E949A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L05:
       mov       rcx,7FFF82E949A8
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       rcx,7FFF82E949AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824C73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82ECCCD8]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1DF5AA2B6E8
       mov       rdx,1DF5AA20210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1DF5AA20008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82ECDF50]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82ECEDD8]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F98ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F98EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F99170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F99190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82ED9480]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823B1258
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F991B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F98ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F99170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82ECEE08]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B1260
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823B1260
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,1DF5AA20008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824F6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829DCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829DC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82CAE1C0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82CAE1C0]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82EBCCD8]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829FC348]
       mov       rcx,1ECB1DBB6E8
       mov       rdx,1ECB1DB0210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1ECB1DB0008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829FC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829F7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
M00_L03:
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
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82EBDF50]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82EBEDD8]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F89768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F89780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F89A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F89A28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82EC9480]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823A1248
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F89A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8271EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F89768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F89A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82EBEE08]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823A1250
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823A1250
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8271EF10]
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
       mov       rax,1ECB1DB0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829FC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829F7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829FC678]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C9E448]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C9E448]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82EBD830]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFF829FC348]
       mov       rcx,2F54E92B6E8
       mov       rdx,2F54E920210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2F54E920008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFF829FC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829F7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
M00_L03:
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
       int       3
; Total bytes of code 388
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFF82EBEAA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L22
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF82EBF930]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L08
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
       jmp       short M01_L09
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFF82F891F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF82F89208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFF82F89490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFF82F894B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L09:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L12
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+60]
       test      r11,r11
       je        near ptr M01_L17
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-58]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,rdx
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82EC8E48]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-58]
M01_L12:
       cmp       rsi,r15
       jne       short M01_L15
       lea       r14,[rax+8]
       mov       ecx,[r14+8]
       mov       rdx,[r14]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L18
M01_L13:
       mov       ecx,[r14+0C]
       mov       rbx,[r14]
       cmp       ecx,[rbx+38]
       jae       short M01_L16
       mov       rdx,[rbx+10]
       lea       r8d,[rcx+1]
       mov       [r14+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L14
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rdx,[rcx]
       mov       rbx,[rcx+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       mov       rcx,rax
       mov       r11,7FFF823A1338
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rbp-58]
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-58]
       mov       ecx,[rbx+38]
       inc       ecx
       mov       [r14+0C],ecx
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       jmp       short M01_L19
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF82F894D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FFF8271EFB8]
       int       3
M01_L19:
       cmp       rsi,r15
       jne       near ptr M01_L27
M01_L20:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,7ED
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L22:
       mov       r15,[rsi+18]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rdi
       mov       rdx,7FFF82F891F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L02
       mov       rcx,[rax+8]
       mov       rdx,[r14+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L02
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rdi
       mov       rdx,7FFF82F89490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FFF82EBF960]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823A1340
       call      qword ptr [r11]
       jmp       near ptr M01_L20
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-58],0
       je        short M01_L28
       mov       rax,[rbp-58]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFF823A1340
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 956
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8271EF10]
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
       mov       rax,2F54E920008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824E6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829FC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829F7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829FC678]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C9E538]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C9E538]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82D94A50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82390D70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82390D80
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82390D78
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82734F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2DA52F69D28
       mov       rdx,2DA52F60210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2DA52F60008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2DA52F6B6E8
       mov       rdx,2DA52F60210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2DA52F60008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L28
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L06
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L07
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82D6BD60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D6BF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFF82D6C080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L10
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L17
M01_L08:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L20
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L09
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L08
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L10:
       mov       rcx,rax
       mov       r11,7FFF82390D88
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L11:
       test      ecx,ecx
       je        near ptr M01_L22
M01_L12:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L18
M01_L13:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L15
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L17
M01_L14:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L16
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L09
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L14
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L15:
       mov       rcx,[rbp-48]
       mov       r11,7FFF82390D90
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L12
       mov       rcx,rax
       jmp       short M01_L19
M01_L16:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       short M01_L19
M01_L17:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFF82D6C098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L13
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L21
M01_L20:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L11
M01_L21:
       cmp       rsi,r15
       je        near ptr M01_L04
       mov       r11,7FFF82390D98
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L23:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82D6C228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L29
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFF82D6C1F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L23
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L31
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L31
       jmp       short M01_L32
M01_L31:
       mov       rcx,rbx
       mov       rdx,7FFF82D6C210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L32:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF82390D98
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1097
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8270EF10]
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
       mov       rax,2DA52F60008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82D96100]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82390D70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82390D80
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82390D78
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82734F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,274B0A29D28
       mov       rdx,274B0A20210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,274B0A20008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,274B0A2B6E8
       mov       rdx,274B0A20210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,274B0A20008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DC28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DD58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF82390D88
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFF82390D90
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFF82D6DEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFF82390D98
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF82390D98
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8270EF10]
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
       mov       rax,274B0A20008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82D868C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82380D70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82380D80
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82380D78
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82724F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829DC348]
       mov       rcx,27743CA9D28
       mov       rdx,27743CA0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27743CA0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829DC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829DC348]
       mov       rcx,27743CAB6E8
       mov       rdx,27743CA0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27743CA0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829DC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L28
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L06
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L07
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DAB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L10
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L17
M01_L08:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L20
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L09
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L08
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L10:
       mov       rcx,rax
       mov       r11,7FFF82380D88
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L11:
       test      ecx,ecx
       je        near ptr M01_L22
M01_L12:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L18
M01_L13:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L15
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L17
M01_L14:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L16
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L09
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L14
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L15:
       mov       rcx,[rbp-48]
       mov       r11,7FFF82380D90
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L12
       mov       rcx,rax
       jmp       short M01_L19
M01_L16:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       short M01_L19
M01_L17:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L13
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L21
M01_L20:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L11
M01_L21:
       cmp       rsi,r15
       je        near ptr M01_L04
       mov       r11,7FFF82380D98
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L23:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DF78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L29
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DF48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L23
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L31
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L31
       jmp       short M01_L32
M01_L31:
       mov       rcx,rbx
       mov       rdx,7FFF82D5DF60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L32:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF82380D98
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1097
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF826FEF10]
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
       mov       rax,27743CA0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829DC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829D7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829DC678]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFFE1E81470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82DAE100]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82380E68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82380E78
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82380E70
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82724F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,20487B29D28
       mov       rdx,20487B20210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20487B20008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,20487B2B6E8
       mov       rdx,20487B20210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20487B20008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF82380E80
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFF82380E88
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFF82D8B9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFF82380E90
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF82380E90
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF826FEF10]
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
       mov       rax,20487B20008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829ACE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L06
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       jne       short M04_L06
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L05
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       jne       short M04_L05
M04_L03:
       mov       rcx,7FFF82E7E718
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFF82E7E71C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L05:
       mov       rcx,7FFF82E7E720
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       rcx,7FFF82E7E724
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824C73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82E87CC0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82381080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82381090
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82381088
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82724F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,225331A9D28
       mov       rdx,225331A0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,225331A0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,225331AB6E8
       mov       rdx,225331A0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,225331A0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824C4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82E6AA80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF82381098
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFF823810A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B6A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFF82E6B6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFF823810A8
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF823810A8
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF826FEF10]
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
       mov       rax,225331A0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824C6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829ACE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C941B0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C941B0]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824C73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82EACA50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF823912A8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF823912B8
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF823912B0
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82734F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2ACE88A9D28
       mov       rdx,2ACE88A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2ACE88A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2ACE88AB6E8
       mov       rdx,2ACE88A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2ACE88A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82E991E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82E993D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82E99500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF823912C0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFF82E99518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFF823912C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFF82E996A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFF82E99678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFF82E99690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFF823912D0
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFF823912D0
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8270EF10]
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
       mov       rax,2ACE88A0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C8E1C0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C8E1C0]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82EACA50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF82391290
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF823912A0
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF82391298
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82734F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,27B5ECD9D28
       mov       rdx,27B5ECD0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27B5ECD0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,27B5ECDB6E8
       mov       rdx,27B5ECD0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27B5ECD0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82E99220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82E99410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82E99540
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L19
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L18
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF823912A8
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L19
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFF823912B0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L16
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
M01_L16:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFF82E99558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L19:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFF82E996E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFF82E996B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFF82E996D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFF823912B8
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFF823912B8
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1085
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8270EF10]
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
       mov       rax,27B5ECD0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF824D6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829BCE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82C8E1C0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82C8E1C0]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFF82EDD5A8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        near ptr M00_L02
       mov       rdi,[rsp+30]
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        short M00_L01
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        short M00_L03
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF823C1388
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFF823C1398
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FFF823C1390
       call      qword ptr [r11]
M00_L01:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFF82764F90]
       int       3
M00_L03:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,2A323129D28
       mov       rdx,2A323120210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A323120008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF829ECC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,2A32312B6E8
       mov       rdx,2A323120210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A323120008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFF829ECC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 802
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFF82504348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF82504348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFF82EB95B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFF82EB97A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82EB98D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L19
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L18
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFF823C13A0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L19
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFF823C13A8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L16
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
M01_L16:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFF82EB98F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L19:
       call      qword ptr [7FFF8273EFB8]
       int       3
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFF82764F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFF82EB9A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFF82EB9A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFF82EB9A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFF823C13B0
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFF823C13B0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1085
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
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8273EF10]
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
       mov       rax,2A323120008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF82506670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFF82506670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFF829ECC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFF829EC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFF829ECE58]
M03_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M03_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82CBE448]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82CBE448]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF825073F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

