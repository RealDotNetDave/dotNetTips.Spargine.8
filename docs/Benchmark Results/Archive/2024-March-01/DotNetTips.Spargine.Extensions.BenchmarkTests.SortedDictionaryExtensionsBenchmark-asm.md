## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF4F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DDE460]
       int       3
M01_L10:
       mov       rcx,7FFF82425120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23927001FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0D78
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823A0D60
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823A0D68
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBF4F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBF528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBF528]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DEE460]
       int       3
M01_L10:
       mov       rcx,7FFF82435120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C883C01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D40
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823B0D48
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCDF20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCDF50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCDF50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8272F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82E0C780]
       int       3
M01_L10:
       mov       rcx,7FFF82445120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,11104001FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823C0CB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823C0CA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823C0CA8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+20],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+38],ecx
       inc       edi
       or        edi,1
       xor       esi,esi
       lzcnt     esi,edi
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       add       esi,esi
       mov       ecx,esi
       mov       rdx,188618A9CB0
       call      qword ptr [7FFF8288FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEDF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+40]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L11
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       mov       rcx,7FFF82435120
       mov       edx,6A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,147D3C01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0D70
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,rbp
       mov       r11,7FFF823B0D60
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 534
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        near ptr M01_L09
       xor       ebx,ebx
       mov       rdx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       jne       near ptr M01_L11
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M01_L10
       mov       rcx,7FFF82435120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F00A401FB0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0D28
       call      qword ptr [r11]
M01_L00:
       mov       rdi,rax
M01_L01:
       test      rdi,rdi
       je        short M01_L05
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rdi],rcx
       jne       short M01_L05
       jmp       short M01_L03
M01_L02:
       add       ebx,1
       jo        short M01_L08
M01_L03:
       lea       rcx,[rdi+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82ED46A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L07
M01_L04:
       add       ebx,1
       jo        short M01_L08
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rdi],rcx
       jne       short M01_L12
       lea       rcx,[rdi+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82ED46A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L06:
       test      eax,eax
       jne       short M01_L04
M01_L07:
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L10:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rdx,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FFF8299C6A8]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       rax,rdi
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L12:
       mov       rcx,rdi
       mov       r11,7FFF823B0D18
       call      qword ptr [r11]
       jmp       short M01_L06
; Total bytes of code 311
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF823B0910
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823B0918
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rdi,offset MT_System.ArrayEnumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF823B0888
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.ArrayEnumerator
       mov       rbp,rcx
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        short M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       mov       rcx,rdi
       mov       r11,[rcx+10]
       inc       r11
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11,rcx
       jae       short M01_L06
       mov       [rdi+10],r11
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823B0890
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
M01_L05:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       [rdi+10],rcx
       jmp       short M01_L05
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       mov       esi,[rbx+17C]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8296C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       je        short M01_L01
       mov       rcx,rbx
       mov       r11,7FFF82380888
       call      qword ptr [r11]
       mov       rdi,rax
M01_L00:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L01:
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L00
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF82380890
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,2ABBA40ADB0
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
       call      qword ptr [7FFF82D8E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,2ABBA40ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824C4210]
       mov       rcx,2ABBA40ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L25
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,2ABBA4001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E217F8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E21800]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L23
M01_L05:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF82380D58
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82D6E828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L23
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82D8E850]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L27
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,2ABBA4001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E217F8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E21800]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L23
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82D6E828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L23
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82D8E850]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L27
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82D6E750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       je        short M01_L22
       mov       rcx,rax
       mov       r11,7FFF82380D60
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L24:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L26:
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L27:
       mov       rcx,rsp
       call      M01_L28
       jmp       short M01_L24
M01_L28:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L29
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       r11,[rbp-60]
       cmp       [r11],rcx
       je        short M01_L29
       mov       rcx,r11
       mov       r11,7FFF82380D60
       call      qword ptr [r11]
M01_L29:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
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
       vdivsd    xmm0,xmm0,[7FFF82E22248]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFF82E22250]
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,24F92C0ADB0
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
       call      qword ptr [7FFF82DADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,24F92C0ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824E4210]
       mov       rcx,24F92C0ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L24
       test      rbx,rbx
       je        near ptr M01_L25
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,24F92C001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E41898]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E418A0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L22
M01_L05:
       call      qword ptr [7FFF827B5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827B5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82DC0518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L22
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE2F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L26
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,24F92C001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E41898]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E418A0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L22
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82DC0518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L22
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE2F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82DC0440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L23:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L25:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L26:
       mov       rcx,rsp
       call      M01_L29
       jmp       short M01_L28
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823A0D60
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L28:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L30
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       je        short M01_L30
       mov       rcx,[rbp-60]
       mov       r11,7FFF823A0D60
       call      qword ptr [r11]
M01_L30:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1174
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF827B5B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FFF82E422E8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFF82E422F0]
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,23B1100ADB0
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
       call      qword ptr [7FFF82DBF4F8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,23B1100ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824F4210]
       mov       rcx,23B1100ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L25
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,23B110001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E53A58]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E53A60]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L23
M01_L05:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82DD0478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L23
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBFCF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L27
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,23B110001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E53A58]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E53A60]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L23
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82DD0478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L23
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBFCF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L27
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82DD03A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       je        short M01_L22
       mov       rcx,rax
       mov       r11,7FFF823B0D60
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L24:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M01_L26:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M01_L27:
       mov       rcx,rsp
       call      M01_L28
       jmp       short M01_L24
M01_L28:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L29
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       r11,[rbp-60]
       cmp       [r11],rcx
       je        short M01_L29
       mov       rcx,r11
       mov       r11,7FFF823B0D60
       call      qword ptr [r11]
M01_L29:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF827C5B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FFF82E544A8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFF82E544B0]
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1983D008DB8
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
       call      qword ptr [7FFF82D9F4F8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,1983D008DB0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF824D4210]
       mov       rcx,1983D008DB8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L25
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1984D0001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E31CF8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E31D00]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L23
M01_L05:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF82390D58
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82DB0518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L23
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82D9FCF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L27
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1984D0001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E31CF8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E31D00]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L23
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82DB0518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L23
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82D9FCF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L27
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82DB0440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       je        short M01_L22
       mov       rcx,rax
       mov       r11,7FFF82390D60
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L24:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L26:
       mov       ecx,0C
       call      qword ptr [7FFF82734F30]
       int       3
M01_L27:
       mov       rcx,rsp
       call      M01_L28
       jmp       short M01_L24
M01_L28:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L29
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       r11,[rbp-60]
       cmp       [r11],rcx
       je        short M01_L29
       mov       rcx,r11
       mov       r11,7FFF82390D60
       call      qword ptr [r11]
M01_L29:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,[rdx+8]
       cmp       [rbx],bl
       call      qword ptr [7FFF827A5B90]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FFF82E32748]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFF82E32750]
       seta      al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 131
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1A35F00ADB0
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
       call      qword ptr [7FFF82E66DA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,1A35F00ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E62C58
       call      qword ptr [7FFF824E4210]
       mov       rcx,1A35F00ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L24
       test      rbx,rbx
       je        near ptr M01_L25
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82E62C58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1A35F0001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E06FB8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E06FC0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L22
M01_L05:
       call      qword ptr [7FFF827B5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF823A0E88
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827B5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82E3FD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L22
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82E675A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L26
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82E62C58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1A35F0001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82E06FB8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82E06FC0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L22
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82E3FD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L22
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82E675A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82E3FCC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L23:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L25:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L26:
       mov       rcx,rsp
       call      M01_L29
       jmp       short M01_L28
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823A0E90
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L28:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L30
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       r11,[rbp-60]
       cmp       [r11],rcx
       je        short M01_L30
       mov       rcx,r11
       mov       r11,7FFF823A0E90
       call      qword ptr [r11]
M01_L30:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1A51FC0ADB0
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
       call      qword ptr [7FFF82EC5EA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,1A51FC0ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82EC1D58
       call      qword ptr [7FFF824D4210]
       mov       rcx,1A51FC0ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L24
       test      rbx,rbx
       je        near ptr M01_L25
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EC1D58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1A51FC001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D3AD58]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D3AD60]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L22
M01_L05:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF823912C0
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827A5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82E9BA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L22
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EC66A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L26
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EC1D58
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,1A51FC001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D3AD58]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D3AD60]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L22
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82E9BA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L22
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EC66A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82E9B960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L23:
       mov       eax,1
       add       rsp,68
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
       mov       ecx,0C
       call      qword ptr [7FFF82734F30]
       int       3
M01_L26:
       mov       rcx,rsp
       call      M01_L29
       jmp       short M01_L28
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823912C8
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L28:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L30
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       je        short M01_L30
       mov       rcx,rax
       mov       r11,7FFF823912C8
       call      qword ptr [r11]
M01_L30:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,2498400ADB0
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
       call      qword ptr [7FFF82EE58F0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,2498400ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82EE17A0
       call      qword ptr [7FFF824F4210]
       mov       rcx,2498400ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L24
       test      rbx,rbx
       je        near ptr M01_L25
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EE17A0
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,249840001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D5D4D8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D5D4E0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L22
M01_L05:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF823B1308
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF827C5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82EBBA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L22
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EE60E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L26
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EE17A0
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,249840001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D5D4D8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D5D4E0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L22
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82EBBA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L22
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EE60E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82EBB960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L23:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M01_L25:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M01_L26:
       mov       rcx,rsp
       call      M01_L29
       jmp       short M01_L28
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF823B1310
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L28:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L30
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       r11,[rbp-60]
       cmp       [r11],rcx
       je        short M01_L30
       mov       rcx,r11
       mov       r11,7FFF823B1310
       call      qword ptr [r11]
M01_L30:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1173
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,20FA280ADB0
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
       call      qword ptr [7FFF82EB58F0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       mov       rdx,20FA280ADA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82EB17A0
       call      qword ptr [7FFF824C4210]
       mov       rcx,20FA280ADB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 162
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L24
       test      rbx,rbx
       je        near ptr M01_L25
       mov       rcx,[rsi+10]
       mov       r11,[rcx+10]
       test      r11,r11
       je        near ptr M01_L21
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L19
       jmp       near ptr M01_L12
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EB17A0
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L11
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,20FA28001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L09
M01_L03:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L05
       add       rbx,[rdi+10]
M01_L04:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,4000000000000000
       or        rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       or        rdx,r8
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rdx,rcx
       sub       r8,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D2E7D8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D2E7E0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        near ptr M01_L12
       jmp       near ptr M01_L22
M01_L05:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L06:
       mov       rcx,rax
       mov       r11,7FFF82381370
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L07:
       call      qword ptr [7FFF82795C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L16
M01_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82E8BD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       near ptr M01_L22
M01_L12:
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EB60E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L26
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L17
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rcx,7FFF82EB17A0
       mov       [rbp+20],rbx
       cmp       [rbx+18],rcx
       jne       near ptr M01_L18
       mov       rdi,[rbp-38]
       mov       [rbp-68],rdi
       cmp       [rdi],dil
       lea       rcx,[rbp-48]
       mov       rax,7FF81A505350
       call      rax
       mov       rbx,[rbp-48]
       mov       rdx,20FA28001C8
       mov       rdi,[rdx]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFFE239505C],0
       jne       near ptr M01_L08
M01_L15:
       mov       edx,0B2D05E00
       cmp       rbx,rdx
       jae       near ptr M01_L07
       add       rbx,[rdi+10]
M01_L16:
       mov       rdi,[rbp-68]
       mov       r14,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rax
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       r8,rcx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r8
       vdivsd    xmm0,xmm0,[7FFF82D2E7D8]
       xor       r15d,r15d
       vucomisd  xmm0,qword ptr [7FFF82D2E7E0]
       seta      r15b
       test      r15d,r15d
       mov       rax,[rbp-60]
       mov       rbx,[rbp+20]
       je        short M01_L19
       jmp       near ptr M01_L22
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFF82E8BD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L14
M01_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rdx,[rbp-58]
       mov       rbx,[rbp+20]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       r15d,eax
       test      r15d,r15d
       mov       rax,[rbp-60]
       jne       short M01_L22
M01_L19:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L06
       lea       rcx,[rax+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EB60E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L20:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFF82E8BCC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L23:
       mov       eax,1
       add       rsp,68
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
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L26:
       mov       rcx,rsp
       call      M01_L29
       jmp       short M01_L28
M01_L27:
       mov       rcx,rax
       mov       r11,7FFF82381378
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L28:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L30
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       je        short M01_L30
       mov       rcx,[rbp-60]
       mov       r11,7FFF82381378
       call      qword ptr [r11]
M01_L30:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1174
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE628]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE658]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE658]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DECBA0]
       int       3
M01_L10:
       mov       rcx,7FFF82425120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B1FBC01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0CB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823A0CA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823A0CA8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF6A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF6D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAF6D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DDE0A0]
       int       3
M01_L10:
       mov       rcx,7FFF82425120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D03EC01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0CB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823A0CA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823A0CA8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 565
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBE628]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBE658]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBE658]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DFCBA0]
       int       3
M01_L10:
       mov       rcx,7FFF82435120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18CA5401FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0CB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0CA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823B0CA8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+20],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+38],ecx
       inc       edi
       or        edi,1
       xor       esi,esi
       lzcnt     esi,edi
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       add       esi,esi
       mov       ecx,esi
       mov       rdx,2A4C22F9CB0
       call      qword ptr [7FFF8287FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBEDF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+40]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L11
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       mov       rcx,7FFF82425120
       mov       edx,6A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26430401FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0D70
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,rbp
       mov       r11,7FFF823A0D60
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 534
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+20],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+38],ecx
       inc       edi
       or        edi,1
       xor       esi,esi
       lzcnt     esi,edi
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       add       esi,esi
       mov       ecx,esi
       mov       rdx,26AA19A9CB0
       call      qword ptr [7FFF828C40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82E7F6A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+40]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82E7F6D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L11
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82E7F6D8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       mov       rcx,7FFF82425120
       mov       edx,6A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22A0F801FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0DD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF823A0DC0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,rbp
       mov       r11,7FFF823A0DC8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 534
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF82390898
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823908A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF823A08A8
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823A08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8271EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF829AC900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       eax,1
       jmp       short M00_L00
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       je        short M01_L01
       mov       rcx,rbx
       mov       r11,7FFF823C08A8
       call      qword ptr [r11]
       mov       rdi,rax
M01_L00:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L01:
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L00
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823C08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8273EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBFAC8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBFAF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DBFAF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8271F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DEE0A0]
       int       3
M01_L10:
       mov       rcx,7FFF82435120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20DC1C01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0D78
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D60
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823B0D68
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE0D0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE100]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAE100]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DEC780]
       int       3
M01_L10:
       mov       rcx,7FFF82425120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24B10C01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0CB8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823A0CA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823A0CA8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+28],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+40],ecx
       inc       edi
       or        edi,1
       xor       r14d,r14d
       lzcnt     r14d,edi
       xor       r14d,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       add       r14d,r14d
       js        near ptr M01_L09
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rsi
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAFAC8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+28]
       vmovdqu   ymmword ptr [rsp+50],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+48]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAFAF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       r14,[rbp]
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L12
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DAFAF8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,87B
       mov       rdx,7FFF8270F3A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF82DDE0A0]
       int       3
M01_L10:
       mov       rcx,7FFF82425120
       mov       edx,6B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22B11C01FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0D78
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823A0D60
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rbp
       mov       r11,7FFF823A0D68
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 571
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+20],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+38],ecx
       inc       edi
       or        edi,1
       xor       esi,esi
       lzcnt     esi,edi
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       add       esi,esi
       mov       ecx,esi
       mov       rdx,18975869CB0
       call      qword ptr [7FFF8288FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEAF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+40]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEB20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L11
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82DCEB20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       mov       rcx,7FFF82435120
       mov       edx,6A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,148E3801FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823B0D70
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,rbp
       mov       r11,7FFF823B0D60
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 534
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       mov       rcx,rsi
       mov       edi,[rcx+20]
       test      edi,edi
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],sil
       mov       [rsp+20],rsi
       mov       ecx,[rsi+24]
       mov       [rsp+38],ecx
       inc       edi
       or        edi,1
       xor       esi,esi
       lzcnt     esi,edi
       xor       esi,1F
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]], System.Collections]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       add       esi,esi
       mov       ecx,esi
       mov       rdx,249A6189CB0
       call      qword ptr [7FFF828C40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EAEDF0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize()
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       lea       rdi,[rbp+8]
       lea       rsi,[rsp+40]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       dword ptr [rbp+8],1
M01_L00:
       test      rbp,rbp
       je        short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       short M01_L04
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L07
M01_L02:
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EAEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L06
M01_L03:
       add       ebx,1
       jo        short M01_L07
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbp],rcx
       jne       near ptr M01_L11
       lea       rcx,[rbp+8]
       add       rcx,8
       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       call      qword ptr [7FFF82EAEE20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L05:
       test      eax,eax
       jne       short M01_L03
M01_L06:
       mov       eax,ebx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       mov       rcx,7FFF82425120
       mov       edx,6A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20914401FC0
       mov       rcx,[rcx]
       mov       r11,7FFF823A0E28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF823A0E10
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,rbp
       mov       r11,7FFF823A0E18
       call      qword ptr [r11]
       jmp       near ptr M01_L05
; Total bytes of code 534
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF82390898
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823908A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF823908A8
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823908B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L08
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rbx],rcx
       jne       short M01_L00
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       r11,7FFF823B08A8
       call      qword ptr [r11]
       mov       rdi,rax
M01_L01:
       mov       rbx,[rdi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L07
M01_L03:
       cmp       rbx,rbp
       jne       short M01_L04
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L05
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFF823B08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L06:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 277
```

