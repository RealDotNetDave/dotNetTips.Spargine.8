## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C757C30]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C73D728
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2781D690390
       mov       rdx,2781D690210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2781D690008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2781D699D28
       mov       rdx,2781D690210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2781D690008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2781D69B6E8
       mov       rdx,2781D690210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2781D690008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rdx,7FF80C73D7C8
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C767A80]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C74D4D0
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,2165BC30390
       mov       rdx,2165BC30210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2165BC30008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C106670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,2165BC39D28
       mov       rdx,2165BC30210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2165BC30008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,2165BC3B6E8
       mov       rdx,2165BC30210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2165BC30008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       mov       rdx,7FF80C74D570
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C757C30]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C73D728
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2068E450390
       mov       rdx,2068E450210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2068E450008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2068E459D28
       mov       rdx,2068E450210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2068E450008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2068E45B6E8
       mov       rdx,2068E450210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2068E450008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rdx,7FF80C73D7C8
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C767C30]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C74D728
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1C8B2180390
       mov       rdx,1C8B2180210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C8B2180008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C106670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1C8B2189D28
       mov       rdx,1C8B2180210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C8B2180008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1C8B218B6E8
       mov       rdx,1C8B2180210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C8B2180008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       mov       rdx,7FF80C74D7C8
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C7AD518]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C78D250
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
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,269C4870390
       mov       rdx,269C4870210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,269C4870008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C136670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,269C4879D28
       mov       rdx,269C4870210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,269C4870008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,269C487B6E8
       mov       rdx,269C4870210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,269C4870008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
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
       mov       rdx,7FF80C78D2F0
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C89F0F0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C888FC0
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
       call      qword ptr [7FF80C3DC348]
       mov       rcx,1A71EF50390
       mov       rdx,1A71EF50210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A71EF50008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C126670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C3DC348]
       mov       rcx,1A71EF59D28
       mov       rdx,1A71EF50210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A71EF50008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C3DC348]
       mov       rcx,1A71EF5B6E8
       mov       rdx,1A71EF50210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A71EF50008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rdx,7FF80C889060
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C8AF360]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C898E48
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
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,159BFFC0390
       mov       rdx,159BFFC0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,159BFFC0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C126670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,159BFFC9D28
       mov       rdx,159BFFC0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,159BFFC0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,159BFFCB6E8
       mov       rdx,159BFFC0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,159BFFC0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rdx,7FF80C898EE8
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r9,[rbx+40]
       mov       r8,[r9+30]
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF80C8AF510]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       mov       rdx,7FF80C8993F8
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
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,21523E00390
       mov       rdx,21523E00210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21523E00008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C126670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,21523E09D28
       mov       rdx,21523E00210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21523E00008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,21523E0B6E8
       mov       rdx,21523E00210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21523E00008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rdx,7FF80C899498
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,1E88FC0AD50
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
       call      qword ptr [7FF80C766058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,1E88FC0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80BEA4210]
       mov       rcx,1E88FC0AD50
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,1E88FC001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C7DF8F0]
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
       call      qword ptr [7FF80C0DEFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C74B8B0
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
       call      qword ptr [7FF80C175C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD60D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C74B7D8
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
       call      qword ptr [7FF80C104F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C104F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD60D70
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
       mov       r11,7FF80BD60D70
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
       call      qword ptr [7FF80C175B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF80C7DFAE8]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,21B89C0AD50
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
       call      qword ptr [7FF80C757D20]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,21B89C0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80BE94210]
       mov       rcx,21B89C0AD50
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,21B89C001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C7ED810]
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
       call      qword ptr [7FF80C0CEFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C73D868
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
       call      qword ptr [7FF80C165C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD50D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C73D790
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
       call      qword ptr [7FF80C0F4F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C0F4F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD50D70
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
       mov       rcx,[rbp-58]
       mov       r11,7FF80BD50D70
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
; Total bytes of code 845
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FF80C165B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF80C7EDA08]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,2404C008D58
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
       call      qword ptr [7FF80C78C090]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,2404C008D50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80BEC4210]
       mov       rcx,2404C008D58
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,240500001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C81DC50]
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
       mov       rdx,7FF80C76D868
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,240500001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C81DC50]
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
       mov       rdx,7FF80C76D868
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
       call      qword ptr [7FF80C195C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FF80BD80D68
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FF80C0FEFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FF80C195C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       rdx,7FF80C76D790
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
       call      qword ptr [7FF80C124F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FF80C124F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FF80BD80D70
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
       mov       r11,7FF80BD80D70
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
       call      qword ptr [7FF80C195B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF80C81DE58]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,22FA9C0AD50
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
       call      qword ptr [7FF80C77C090]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,22FA9C0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80BEB4210]
       mov       rcx,22FA9C0AD50
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,22FA9C001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C801850]
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
       call      qword ptr [7FF80C0EEFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C75D868
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
       call      qword ptr [7FF80C185C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD70D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C75D790
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
       call      qword ptr [7FF80C114F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C114F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD70D70
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
       mov       r11,7FF80BD70D70
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
       call      qword ptr [7FF80C185B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF80C801A48]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,191BE808D58
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
       call      qword ptr [7FF80C79E928]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,191BE808D50
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80BEB4210]
       mov       rcx,191BE808D58
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
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,191C28001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C811210]
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
       call      qword ptr [7FF80C0EEFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C78B4D8
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
       call      qword ptr [7FF80C185C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD70E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C78B400
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
       call      qword ptr [7FF80C114F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C114F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD70E78
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
       mov       rcx,[rbp-58]
       mov       r11,7FF80BD70E78
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
; Total bytes of code 845
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FF80C185B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF80C811408]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,2E08BC0AD50
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
       call      qword ptr [7FF80C87F450]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,2E08BC0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF80C87B1F8
       call      qword ptr [7FF80BEA4210]
       mov       rcx,2E08BC0AD50
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
       mov       rcx,7FF80C87B1F8
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L07
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF8A71D5350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,2E08BC001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C7A46B0]
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
       mov       rdx,7FF80C85AF18
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
       mov       rcx,7FF80C87B1F8
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r13,[rbp-48]
       mov       [rbp-78],r13
       cmp       [r13],r13b
       lea       rcx,[rbp-58]
       mov       rax,7FF8A71D5350
       call      rax
       mov       rbx,[rbp-58]
       mov       rdx,2E08BC001C8
       mov       r13,[rdx]
       sub       rbx,[r13+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C7A46B0]
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
       mov       rdx,7FF80C85AF18
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
       call      qword ptr [7FF80C175C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rax
       mov       r11,7FF80BD611C8
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-70]
M01_L22:
       test      ecx,ecx
       jne       near ptr M01_L10
       jmp       near ptr M01_L32
M01_L23:
       call      qword ptr [7FF80C0DEFB8]
       int       3
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L25:
       call      qword ptr [7FF80C175C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       rdx,7FF80C85AE40
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
       call      qword ptr [7FF80C104F30]
       int       3
M01_L31:
       mov       ecx,0C
       call      qword ptr [7FF80C104F30]
       int       3
M01_L32:
       mov       rcx,rsp
       call      M01_L35
       jmp       short M01_L34
M01_L33:
       mov       rax,[rbp-70]
       mov       rcx,rax
       mov       r11,7FF80BD611D0
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
       mov       r11,7FF80BD611D0
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,17A8600AD50
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
       call      qword ptr [7FF80C8BE628]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,17A8600AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF80C8BA3D0
       call      qword ptr [7FF80BED4210]
       mov       rcx,17A8600AD50
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
       mov       rcx,7FF80C8BA3D0
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L08
       mov       r14,[rbp-30]
       mov       [rbp-60],r14
       cmp       [r14],r14b
       lea       rcx,[rbp-40]
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,17A860001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C738D50]
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
       call      qword ptr [7FF80C10EFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C8A9190
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
       call      qword ptr [7FF80C1A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD912E8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C8A90B8
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
       call      qword ptr [7FF80C134F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C134F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD912F0
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
       mov       r11,7FF80BD912F0
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,1D353C0AD50
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
       call      qword ptr [7FF80C8BF1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,1D353C0AD48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF80C8BAF88
       call      qword ptr [7FF80BED4210]
       mov       rcx,1D353C0AD50
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
       mov       rcx,7FF80C8BAF88
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L08
       mov       r14,[rbp-30]
       mov       [rbp-60],r14
       cmp       [r14],r14b
       lea       rcx,[rbp-40]
       mov       rax,7FF8A71D5350
       call      rax
       mov       rdi,[rbp-40]
       mov       rdx,1D353C001C8
       mov       rbx,[rdx]
       sub       rdi,[rbx+8]
       cmp       dword ptr [7FF86BD6305C],0
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
       vdivsd    xmm0,xmm0,[7FF80C72AB50]
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
       call      qword ptr [7FF80C10EFB8]
       int       3
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF80C8A9538
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
       call      qword ptr [7FF80C1A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       r11,7FF80BD91318
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L20
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF80C8A9460
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
       call      qword ptr [7FF80C134F30]
       int       3
M01_L19:
       mov       ecx,0C
       call      qword ptr [7FF80C134F30]
       int       3
M01_L20:
       mov       rax,[rbp-58]
       mov       rcx,rsp
       call      M01_L23
       jmp       short M01_L22
M01_L21:
       mov       rax,[rbp-58]
       mov       rcx,rax
       mov       r11,7FF80BD91320
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
       mov       rcx,[rbp-58]
       mov       r11,7FF80BD91320
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
; Total bytes of code 845
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD90D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD90D78
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD90D70
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
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,1EDE42F9D28
       mov       rdx,1EDE42F0210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1EDE42F0008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,1EDE42FB6E8
       mov       rdx,1EDE42F0210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1EDE42F0008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C10EF10]
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
       mov       rax,1EDE42F0008
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
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C3BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3BCE58]
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
       call      qword ptr [7FF80BED7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD60D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD60D78
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD60D70
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1E3EF519D28
       mov       rdx,1E3EF510210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E3EF510008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1E3EF51B6E8
       mov       rdx,1E3EF510210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E3EF510008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,1E3EF510008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD90D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD90D78
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD90D70
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
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,251D7319D28
       mov       rdx,251D7310210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,251D7310008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,251D731B6E8
       mov       rdx,251D7310210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,251D7310008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C10EF10]
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
       mov       rax,251D7310008
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
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C3BCC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3BC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3BCE58]
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
       call      qword ptr [7FF80BED7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD80D68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD80D78
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD80D70
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
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,27505979D28
       mov       rdx,27505970210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27505970008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,2750597B6E8
       mov       rdx,27505970210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27505970008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0FEF10]
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
       mov       rax,27505970008
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
       call      qword ptr [7FF80BEC6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEC6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C3ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3ACE58]
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
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD60E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD60E80
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD60E78
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,20367E69D28
       mov       rdx,20367E60210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20367E60008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,20367E6B6E8
       mov       rdx,20367E60210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20367E60008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,20367E60008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L06
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF80C86CA50]
       test      eax,eax
       jne       short M03_L06
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L05
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF80C86CA50]
       test      eax,eax
       jne       short M03_L05
M03_L03:
       mov       rcx,7FF80C8833B8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FF80C8833BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L05:
       mov       rcx,7FF80C8833C0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       mov       rcx,7FF80C8833C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD61230
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD61240
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD61238
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1DC2C5A9D28
       mov       rdx,1DC2C5A0210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1DC2C5A0008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1DC2C5AB6E8
       mov       rdx,1DC2C5A0210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1DC2C5A0008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,1DC2C5A0008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF80C65F228]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF80C65F228]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD61378
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD61388
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD61380
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,29D2E389D28
       mov       rdx,29D2E380210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,29D2E380008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,29D2E38B6E8
       mov       rdx,29D2E380210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,29D2E380008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,29D2E380008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF80C65E238]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF80C65E238]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
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
       mov       r11,7FF80BD71348
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FF80BD71358
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF80BD71350
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
       call      qword ptr [7FF80C3CC348]
       mov       rcx,234BD099D28
       mov       rdx,234BD090210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,234BD090008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3CC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
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
M00_L06:
       call      qword ptr [7FF80C3CC348]
       mov       rcx,234BD09B6E8
       mov       rdx,234BD090210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,234BD090008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3CC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,234BD090008
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
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M02_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M02_L01
M02_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M02_L01
       call      qword ptr [7FF80C3CC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3C7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3CC678]
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
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF80C66E148]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF80C66E148]
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
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C756388]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2273988B6E8
       mov       rdx,22739880210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22739880008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80C757600]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C75C750]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C921468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C921480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C921708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C921728
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
       call      qword ptr [7FF80C765ED0]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD50D90
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
       mov       rdx,7FF80C921748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0CEFB8]
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
       mov       rdx,7FF80C0BF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
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
       mov       rdx,7FF80C921468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C921708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C75C780]
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
       mov       r11,7FF80BD50D98
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
       mov       r11,7FF80BD50D98
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,22739880008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C37CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C37C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C37CE58]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C76C030]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,2C474D4B6E8
       mov       rdx,2C474D40210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C474D40008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80C76D2A8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C76E130]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C9325D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C9325F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C932878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C932898
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
       call      qword ptr [7FF80C779480]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD60CD0
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
       mov       rdx,7FF80C9328B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0DEFB8]
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
       mov       rdx,7FF80C0CF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
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
       mov       rdx,7FF80C9325D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C932878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C76E160]
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
       mov       r11,7FF80BD60CD8
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
       mov       r11,7FF80BD60CD8
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,2C474D40008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C77C030]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C39CB28]
       mov       rcx,2330CB1B6E8
       mov       rdx,2330CB10210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2330CB10008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80C77D2A8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C77E130]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C941C58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C941C70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C941EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C941F18
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
       call      qword ptr [7FF80C789480]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD70D90
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
       mov       rdx,7FF80C941F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0EEFB8]
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
       mov       rdx,7FF80C0DF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
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
       mov       rdx,7FF80C941C58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C941EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C77E160]
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
       mov       r11,7FF80BD70D98
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
       mov       r11,7FF80BD70D98
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,2330CB10008
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
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C39CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C39C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C39CE58]
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
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C77C4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C39CB28]
       mov       rcx,277D9ECB6E8
       mov       rdx,277D9EC0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,277D9EC0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80C77D728]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C77E5B0]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C9425F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C942608
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C942890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C9428B0
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
       call      qword ptr [7FF80C789480]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD70CD0
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
       mov       rdx,7FF80C9428D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0EEFB8]
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
       mov       rdx,7FF80C0DF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
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
       mov       rdx,7FF80C9425F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C942890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C77E5E0]
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
       mov       r11,7FF80BD70CD8
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
       mov       r11,7FF80BD70CD8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,277D9EC0008
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
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C39CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C39C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C39CE58]
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
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C76ECD0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,1EA1A33B6E8
       mov       rdx,1EA1A330210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1EA1A330008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80C76FF48]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C784E10]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C936138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C936150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C9363D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C9363F8
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
       call      qword ptr [7FF80C790DB8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD50D68
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
       mov       rdx,7FF80C936418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0CEFB8]
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
       mov       rdx,7FF80C0BF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
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
       mov       rdx,7FF80C936138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C9363D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C784E40]
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
       mov       r11,7FF80BD50D70
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
       mov       r11,7FF80BD50D70
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,1EA1A330008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C37CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C37C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C37CE58]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L06
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C884138]
       test      eax,eax
       jne       short M04_L06
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L05
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C884138]
       test      eax,eax
       jne       short M04_L05
M04_L03:
       mov       rcx,7FF80C87A210
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF80C87A214
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L05:
       mov       rcx,7FF80C87A218
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       rcx,7FF80C87A21C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C86F828]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,24CAA8CB6E8
       mov       rdx,24CAA8C0210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24CAA8C0008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80C884CA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C885B30]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C93C568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C93C580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C93C808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C93C828
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
       call      qword ptr [7FF80C87CEE0]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD511C8
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
       mov       rdx,7FF80C93C848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0CEFB8]
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
       mov       rdx,7FF80C0BF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
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
       mov       rdx,7FF80C93C568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C93C808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C885B60]
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
       mov       r11,7FF80BD511D0
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
       mov       r11,7FF80BD511D0
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,24CAA8C0008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C37CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C37C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C37CE58]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C64F228]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       ecx,ecx
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C64F228]
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
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C87F828]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,18BC25FB6E8
       mov       rdx,18BC25F0210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18BC25F0008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80C894CA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C895B30]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C959948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C959960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C959BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C959C08
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
       call      qword ptr [7FF80C88E1C0]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD512B8
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
       mov       rdx,7FF80C959C28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0CEFB8]
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
       mov       rdx,7FF80C0BF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
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
       mov       rdx,7FF80C959948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C959BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C895B60]
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
       mov       r11,7FF80BD512C0
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
       mov       r11,7FF80BD512C0
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,18BC25F0008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C37CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C37C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C37CE58]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C64E940]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C64E940]
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
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C87E850]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       call      qword ptr [7FF80C3AC348]
       mov       rcx,2773714B6E8
       mov       rdx,27737140210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27737140008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3AC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80C87FAC8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L01:
       mov       rdx,rbx
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF80C894E10]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF80C9594B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C9594D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C959758
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF80C959778
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
       call      qword ptr [7FF80C88EE38]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
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
       mov       r11,7FF80BD51280
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
       mov       rdx,7FF80C959798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L18:
       call      qword ptr [7FF80C0CEFB8]
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
       mov       rdx,7FF80C0BF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
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
       mov       rdx,7FF80C9594B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       mov       rdx,[r15+10]
       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80C959758
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+18]
       mov       rcx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C894E40]
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
       mov       r11,7FF80BD51288
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
       mov       r11,7FF80BD51288
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,27737140008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C3AC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3A7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3AC678]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C64E148]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C64E148]
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
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C767CC0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD60DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD60DB8
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD60DB0
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
       call      qword ptr [7FF80C104F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1FCC3909D28
       mov       rdx,1FCC3900210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1FCC3900008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1FCC390B6E8
       mov       rdx,1FCC3900210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1FCC3900008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C74D628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF80C74D818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF80C74D948
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
       mov       r11,7FF80BD60DC0
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
       call      qword ptr [7FF80C0DEFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF80C74D960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FF80BD60DC8
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
       call      qword ptr [7FF80C104F30]
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
       mov       rdx,7FF80C74DAF0
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
       mov       rdx,7FF80C74DAC0
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
       mov       rdx,7FF80C74DAD8
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
       mov       r11,7FF80BD60DD0
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
       mov       r11,7FF80BD60DD0
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,1FCC3900008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C767CC0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD60DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD60DB8
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD60DB0
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
       call      qword ptr [7FF80C104F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,24C82C59D28
       mov       rdx,24C82C50210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24C82C50008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,24C82C5B6E8
       mov       rdx,24C82C50210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24C82C50008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       je        near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L24
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L27
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
       mov       rdx,7FF80C74D678
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
       mov       rdx,7FF80C74D868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF80C74D998
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
       jne       near ptr M01_L15
M01_L08:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L18
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
       mov       r11,7FF80BD60DC0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L11:
       test      ecx,ecx
       je        near ptr M01_L21
M01_L12:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
M01_L13:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L17
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L15
M01_L14:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L19
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L20
M01_L15:
       call      qword ptr [7FF80C0DEFB8]
       int       3
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FF80C74D9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L13
M01_L17:
       mov       rcx,[rbp-48]
       mov       r11,7FF80BD60DC8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L12
       mov       rcx,rax
       jmp       short M01_L20
M01_L18:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L11
M01_L19:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L09
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L14
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
M01_L20:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       je        near ptr M01_L04
       mov       r11,7FF80BD60DD0
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L21:
       mov       rcx,rsp
       call      M01_L32
       nop
M01_L22:
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
M01_L23:
       mov       ecx,10
       call      qword ptr [7FF80C104F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L25
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FF80C74DB40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
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
M01_L27:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L28
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FF80C74DB10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L22
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L30
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rbx
       mov       rdx,7FF80C74DB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
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
M01_L32:
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
       je        short M01_L33
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L33
       mov       rcx,rax
       mov       r11,7FF80BD60DD0
       call      qword ptr [r11]
M01_L33:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1094
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,24C82C50008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C777CC0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD70DB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD70DC0
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD70DB8
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
       call      qword ptr [7FF80C114F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,25A15A29D28
       mov       rdx,25A15A20210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,25A15A20008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,25A15A2B6E8
       mov       rdx,25A15A20210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,25A15A20008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C75D678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF80C75D868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF80C75D998
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
       mov       r11,7FF80BD70DC8
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
       call      qword ptr [7FF80C0EEFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF80C75D9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FF80BD70DD0
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
       call      qword ptr [7FF80C114F30]
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
       mov       rdx,7FF80C75DB40
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
       mov       rdx,7FF80C75DB10
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
       mov       rdx,7FF80C75DB28
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
       mov       r11,7FF80BD70DD8
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
       mov       rcx,[rbp-48]
       mov       r11,7FF80BD70DD8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,25A15A20008
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
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C39CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C39C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C39CE58]
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
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C79C000]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD90DA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD90DB8
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD90DB0
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
       call      qword ptr [7FF80C134F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C3EC348]
       mov       rcx,2BCA9129D28
       mov       rdx,2BCA9120210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2BCA9120008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3EC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3E7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3EC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3EC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C3EC348]
       mov       rcx,2BCA912B6E8
       mov       rdx,2BCA9120210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2BCA9120008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3EC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3E7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3EC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3EC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3EC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
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
       call      qword ptr [7FF80BED4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BED4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C77D678
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
       mov       rdx,7FF80C77D868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF80C77D998
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
       mov       r11,7FF80BD90DC0
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
       mov       r11,7FF80BD90DC8
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
       call      qword ptr [7FF80C10EFB8]
       int       3
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FF80C77D9B0
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
       mov       r11,7FF80BD90DD0
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
       call      qword ptr [7FF80C134F30]
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
       mov       rdx,7FF80C77DB40
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
       mov       rdx,7FF80C77DB10
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
       mov       rdx,7FF80C77DB28
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
       mov       r11,7FF80BD90DD0
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C10EF10]
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
       mov       rax,2BCA9120008
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
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BED6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C3EC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3E7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3EC678]
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
       call      qword ptr [7FF80BED7318]; System.String.Trim()
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF856285318]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C77EBF8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD50DF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD50E00
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD50DF8
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
       call      qword ptr [7FF80C0F4F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C3AC348]
       mov       rcx,235F9D69D28
       mov       rdx,235F9D60210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,235F9D60008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3AC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C3AC348]
       mov       rcx,235F9D6B6E8
       mov       rdx,235F9D60210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,235F9D60008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3AC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80BE94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BE94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C76B1B8
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
       mov       rdx,7FF80C76B3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF80C76B4D8
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
       mov       r11,7FF80BD50E08
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
       mov       r11,7FF80BD50E10
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
       call      qword ptr [7FF80C0CEFB8]
       int       3
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FF80C76B4F0
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
       mov       r11,7FF80BD50E18
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
       call      qword ptr [7FF80C0F4F30]
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
       mov       rdx,7FF80C76B680
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
       mov       rdx,7FF80C76B650
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
       mov       rdx,7FF80C76B668
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
       mov       r11,7FF80BD50E18
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,235F9D60008
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
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BE96670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C3AC468]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3A7AB0]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3AC678]
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
       call      qword ptr [7FF80BE97318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L06
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C85CC18]
       test      eax,eax
       jne       short M04_L06
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L05
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C85CC18]
       test      eax,eax
       jne       short M04_L05
M04_L03:
       mov       rcx,7FF80C882138
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FF80C88213C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L05:
       mov       rcx,7FF80C882140
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       rcx,7FF80C882144
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C89E5C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD81210
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD81220
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD81218
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
       call      qword ptr [7FF80C124F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,2A31EDD9D28
       mov       rdx,2A31EDD0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A31EDD0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,2A31EDDB6E8
       mov       rdx,2A31EDD0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A31EDD0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C888FA0
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
       mov       rdx,7FF80C889190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF80C8892C0
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
       mov       r11,7FF80BD81228
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
       mov       r11,7FF80BD81230
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
       call      qword ptr [7FF80C0FEFB8]
       int       3
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FF80C8892D8
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
       mov       r11,7FF80BD81238
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
       call      qword ptr [7FF80C124F30]
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
       mov       rdx,7FF80C889468
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
       mov       rdx,7FF80C889438
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
       mov       rdx,7FF80C889450
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
       mov       r11,7FF80BD81238
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0FEF10]
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
       mov       rax,2A31EDD0008
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
       call      qword ptr [7FF80BEC6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEC6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C3ACC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C3AC498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C3ACE58]
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
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C67F138]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C67F138]
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
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C88E5C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD612A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD612B0
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD612A8
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
       call      qword ptr [7FF80C104F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1E9A99C9D28
       mov       rdx,1E9A99C0210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E9A99C0008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1E9A99CB6E8
       mov       rdx,1E9A99C0210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E9A99C0008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C878FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF80C879190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF80C8792C0
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
       mov       r11,7FF80BD612B8
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
       mov       r11,7FF80BD612C0
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
       mov       rdx,7FF80C8792D8
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
       call      qword ptr [7FF80C0DEFB8]
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
       call      qword ptr [7FF80C104F30]
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
       mov       rdx,7FF80C879468
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
       mov       rdx,7FF80C879438
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
       mov       rdx,7FF80C879450
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
       mov       r11,7FF80BD612C8
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
       mov       r11,7FF80BD612C8
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0DEF10]
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
       mov       rax,1E9A99C0008
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
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C38CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C38C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C38CE58]
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
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C65E148]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C65E148]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+190]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FF80C88F5A0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
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
       mov       r11,7FF80BD713F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF80BD71408
       call      qword ptr [r11]
M00_L00:
       mov       rcx,rsi
       mov       r8,rbp
       mov       rdx,rdi
       mov       r11,7FF80BD71400
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
       call      qword ptr [7FF80C114F90]
       int       3
M00_L03:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,24DFAA29D28
       mov       rdx,24DFAA20210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24DFAA20008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,24DFAA2B6E8
       mov       rdx,24DFAA20210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24DFAA20008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C879768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF80C879958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF80C879A88
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
       mov       r11,7FF80BD71410
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
       mov       r11,7FF80BD71418
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
       mov       rdx,7FF80C879AA0
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
       call      qword ptr [7FF80C0EEFB8]
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
       call      qword ptr [7FF80C114F30]
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
       mov       rdx,7FF80C879C30
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
       mov       rdx,7FF80C879C00
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
       mov       rdx,7FF80C879C18
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
       mov       r11,7FF80BD71420
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
       mov       r11,7FF80BD71420
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,24DFAA20008
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
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FF80BEB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FF80C39CC48]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FF80C39C498]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF80C39CE58]
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
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C66E238]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C66E238]
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
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
