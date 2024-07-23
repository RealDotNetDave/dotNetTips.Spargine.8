## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8298E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L09
       add       rcx,8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L05
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       mov       rcx,rdi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L04
       mov       [rdi+10],r11d
       jb        short M01_L01
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823A0D18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L04:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82F36DF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82746718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,7FFF82854100
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,17CBE001FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       r11,7FFF823A0D10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
; Total bytes of code 312
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8297E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L09
       add       rcx,8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L05
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       mov       rcx,rdi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L04
       mov       [rdi+10],r11d
       jb        short M01_L01
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82390D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L04:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82F27228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82736718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,7FFF82844100
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29477C01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       r11,7FFF82390D00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
; Total bytes of code 312
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8299E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L09
       add       rcx,8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L05
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       mov       rcx,rdi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L04
       mov       [rdi+10],r11d
       jb        short M01_L01
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823B0D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L04:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82F4C2A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82756718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,7FFF82864100
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1861B001FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       r11,7FFF823B0D00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
; Total bytes of code 312
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8298E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L09
       add       rcx,8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L05
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       mov       rcx,rdi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L04
       mov       [rdi+10],r11d
       jb        short M01_L01
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823A0DE0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L04:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82F5E1F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82746718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,7FFF82854100
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,287DD801FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       r11,7FFF823A0DD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
; Total bytes of code 312
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8296E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L09
       add       rcx,8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        short M01_L05
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       mov       rcx,rdi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L04
       mov       [rdi+10],r11d
       jb        short M01_L01
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82380DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L04:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82F3E5C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82726718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,7FFF82834100
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B550C01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       r11,7FFF82380DD0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
; Total bytes of code 312
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8297E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
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
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
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
       mov       r11,7FFF82390928
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
       mov       r11,7FFF82390930
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8299E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
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
       mov       r11,7FFF823B0898
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
       mov       r11,7FFF823B08A0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       edi,[rbx+17C]
       cmp       dword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8297E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 97
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
       mov       r11,7FFF82390888
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
       mov       r11,7FFF82390890
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82D953E0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,217B523B6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,217B5230008
       call      qword ptr [7FFF82D95428]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828571F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82D774A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        short M01_L08
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       mov       rcx,rsi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L07
       mov       [rsi+10],r11d
       jb        short M01_L03
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D774D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF82380D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L07:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 295
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82D96A30]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,2414B93B6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,2414B930008
       call      qword ptr [7FFF82D96A78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828571F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82D79260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        short M01_L08
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       mov       rcx,rsi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L07
       mov       [rsi+10],r11d
       jb        short M01_L03
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D79288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF82380D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L07:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 295
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82DB6A30]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,2115601B6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,21156010008
       call      qword ptr [7FFF82DB6A78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828771F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82D99260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        short M01_L08
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       mov       rcx,rsi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L07
       mov       [rsi+10],r11d
       jb        short M01_L03
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D99288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF823A0D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L07:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 295
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82DA6C88]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,2C1257BB6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,2C1257B0008
       call      qword ptr [7FFF82DA6CD0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828671F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82D89260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        short M01_L08
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       mov       rcx,rsi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L07
       mov       [rsi+10],r11d
       jb        short M01_L03
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82D89288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF82390D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L07:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 295
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82E87948]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,237E3BFB6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,237E3BF0008
       call      qword ptr [7FFF82E87990]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828571F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Immutable.ImmutableArray`1+EnumeratorObject[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82E77500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        short M01_L08
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       mov       rcx,rsi
       mov       r11d,[rcx+10]
       inc       r11d
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11d,ecx
       ja        short M01_L07
       mov       [rsi+10],r11d
       jb        short M01_L03
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82E77528
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF82380DC8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L07:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 295
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82EDD3E0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,27AF2B4B6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,27AF2B40008
       call      qword ptr [7FFF82EDD428]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L12
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828971F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82EE4A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        near ptr M01_L11
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       lea       r14,[rsi+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       near ptr M01_L10
       mov       r13d,[r14+10]
       cmp       r13d,[r15+10]
       jae       short M01_L09
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82EE4A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF823C12F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L08
M01_L07:
       lea       rcx,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13d,[rdx+8]
       jae       short M01_L13
       mov       eax,r13d
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L03
M01_L08:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
       jmp       short M01_L08
M01_L10:
       call      qword ptr [7FFF8273EFB8]
       int       3
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 392
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82E9D230]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,239BC0AB6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,239BC0A0008
       call      qword ptr [7FFF82E9D278]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L12
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828671F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82EB4858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        near ptr M01_L11
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       lea       r14,[rsi+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       near ptr M01_L10
       mov       r13d,[r14+10]
       cmp       r13d,[r15+10]
       jae       short M01_L09
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82EB4880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF82391338
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L08
M01_L07:
       lea       rcx,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13d,[rdx+8]
       jae       short M01_L13
       mov       eax,r13d
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L03
M01_L08:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
       jmp       short M01_L08
M01_L10:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 392
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82EBCD50]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,1F1184AB6E8
       mov       [rsp+20],rdx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       r9,1F1184A0008
       call      qword ptr [7FFF82EBCD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L12
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       ebx,ebx
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FFF828871F8]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerable.GetEnumerator()
       mov       rsi,rax
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       jmp       short M01_L04
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFF82ED4D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       add       ebx,1
       jo        near ptr M01_L11
M01_L04:
       cmp       rdi,rbp
       jne       short M01_L06
       lea       r14,[rsi+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       near ptr M01_L10
       mov       r13d,[r14+10]
       cmp       r13d,[r15+10]
       jae       short M01_L09
       jmp       short M01_L07
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFF82ED4D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rsi
       mov       r11,7FFF823B12D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L08
M01_L07:
       lea       rcx,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13d,[rdx+8]
       jae       short M01_L13
       mov       eax,r13d
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L03
M01_L08:
       mov       eax,ebx
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
       jmp       short M01_L08
M01_L10:
       call      qword ptr [7FFF8272EFB8]
       int       3
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 392
```

