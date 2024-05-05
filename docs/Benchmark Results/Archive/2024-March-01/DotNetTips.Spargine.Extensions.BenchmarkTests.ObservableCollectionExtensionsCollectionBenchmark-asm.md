## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823B0D30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF8272EFB8]
       int       3
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
       mov       rcx,7FFF82435120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C72AC01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF823B0D38
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823B0D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF8272EFB8]
       int       3
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
       mov       rcx,7FFF82435120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21895C01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF823B0D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82390D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF8270EFB8]
       int       3
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
       mov       rcx,7FFF82415120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18B8E801FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF82390D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF82390D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF823B0D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF8272EFB8]
       int       3
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
       mov       rcx,7FFF82435120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19AF3C01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF823B0D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF823B0D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8296CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M01_L07
       xor       ebx,ebx
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],r11
       jne       near ptr M01_L08
       mov       rcx,[rcx+8]
       mov       r11,7FFF82380D30
       call      qword ptr [r11]
       mov       rsi,rax
M01_L00:
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L06
M01_L02:
       cmp       rdi,rbp
       jne       short M01_L03
       lea       r14,[rsi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       near ptr M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rsi
       mov       r11,7FFF82380D28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L08:
       mov       r11,7FFF82380D20
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFF826FEFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 264
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298C330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
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
       mov       r11,7FFF823A0908
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
       mov       r11,7FFF823A0910
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299C330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
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
       mov       r11,7FFF823B0888
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
       mov       r11,7FFF823B0890
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      al
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
; Total bytes of code 52
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,200D540ADA0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82D264C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,200D540AD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF824F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,200D540ADA0
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F58550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       near ptr M01_L15
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       near ptr M01_L15
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L09
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L10
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L11
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L11
       jmp       near ptr M01_L17
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFF82F58550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L08
M01_L10:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L11:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L12
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L12
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L07
M01_L12:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8277E688]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823B0D50
       call      qword ptr [r11]
M01_L14:
       test      eax,eax
       jne       near ptr M01_L07
       jmp       short M01_L21
M01_L15:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8277E688]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L21
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F58478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-40]
       mov       rcx,rdx
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823B0D58
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF824F41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,29309802240
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82D24DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29309802238
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF824E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29309802240
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F37E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       near ptr M01_L15
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       near ptr M01_L15
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L09
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L10
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L11
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L11
       jmp       near ptr M01_L17
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFF82F37E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L08
M01_L10:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L11:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L12
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L12
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L07
M01_L12:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823A0D50
       call      qword ptr [r11]
M01_L14:
       test      eax,eax
       jne       near ptr M01_L07
       jmp       short M01_L21
M01_L15:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L21
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F37DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-40]
       mov       rcx,rdx
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF824E41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,25E76002240
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82D25590]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25E76002238
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF824E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25E76002240
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F37E88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       near ptr M01_L15
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       near ptr M01_L15
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L09
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L10
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L11
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L11
       jmp       near ptr M01_L17
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFF82F37E88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L08
M01_L10:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L11:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L12
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L12
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L07
M01_L12:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823A0D50
       call      qword ptr [r11]
M01_L14:
       test      eax,eax
       jne       near ptr M01_L07
       jmp       short M01_L21
M01_L15:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L21
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F37DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-40]
       mov       rcx,rdx
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 778
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF824E41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,22EFD40ADA0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82D1C6A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22EFD40AD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFF824E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22EFD40ADA0
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       test      rax,rax
       je        near ptr M01_L12
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rdi
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r12,[rax+38]
       test      r12,r12
       mov       rax,[rbp-48]
       je        short M01_L05
       mov       edx,[r12+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F47320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L17
M01_L05:
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M01_L07
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M01_L07
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF8276E688]
       test      eax,eax
       je        near ptr M01_L21
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L10
M01_L09:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rdx
       jne       short M01_L11
       mov       r12,[rax+38]
       test      r12,r12
       mov       rax,[rbp-48]
       je        short M01_L12
       mov       edx,[r12+8]
       test      edx,edx
       je        short M01_L12
       jmp       near ptr M01_L17
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82F47320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L09
M01_L11:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L17
M01_L12:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rdi
       jne       short M01_L13
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M01_L14
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M01_L14
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823A0D50
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF8276E688]
M01_L15:
       test      eax,eax
       je        short M01_L21
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F47248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       cmp       [rax],rdi
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rcx,rax
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L25
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,[rbp-48]
       cmp       [rcx],rdi
       je        short M01_L25
       mov       r11,7FFF823A0D58
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 753
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF824E41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,28ED1002240
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82D6D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,28ED1002238
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E73FD8
       call      qword ptr [7FFF824C4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28ED1002240
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       test      rax,rax
       je        near ptr M01_L12
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rdi
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rdx,7FFF82E73FD8
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r12,[rax+38]
       test      r12,r12
       mov       rax,[rbp-48]
       je        short M01_L05
       mov       edx,[r12+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F3AF38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-48]
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M01_L07
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M01_L07
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF8274E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       je        near ptr M01_L21
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L10
M01_L09:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rdx,7FFF82E73FD8
       cmp       [rbx+18],rdx
       jne       short M01_L11
       mov       r12,[rax+38]
       test      r12,r12
       mov       rax,[rbp-48]
       je        short M01_L12
       mov       edx,[r12+8]
       test      edx,edx
       je        short M01_L12
       jmp       near ptr M01_L17
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82F3AF38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L09
M01_L11:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L12:
       mov       rax,[rbp-48]
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rdi
       jne       short M01_L13
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M01_L14
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M01_L14
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF82381098
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF8274E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M01_L15:
       test      eax,eax
       je        short M01_L21
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F3AE60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,[rbp-48]
       cmp       [rax],rdi
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82724F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82724F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rcx,rax
       mov       r11,7FFF823810A0
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L25
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,[rbp-48]
       cmp       [rcx],rdi
       je        short M01_L25
       mov       r11,7FFF823810A0
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 757
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFF824C41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,2705080ADA0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82E0CFC0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2705080AD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E83E28
       call      qword ptr [7FFF824D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2705080ADA0
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E83E28
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F4F878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L07
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L07
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8275E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       je        near ptr M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L10
M01_L09:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E83E28
       cmp       [rbx+18],rdx
       jne       short M01_L11
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L12
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L12
       jmp       near ptr M01_L17
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82F4F878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L09
M01_L11:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L12:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L14
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L14
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823912A0
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8275E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M01_L15:
       test      eax,eax
       je        short M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F4F7A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82734F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82734F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rcx,rdx
       mov       r11,7FFF823912A8
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823912A8
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 776
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFF824D41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,16632C0ADA0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82E1D980]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16632C0AD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E98858
       call      qword ptr [7FFF824E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16632C0ADA0
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E98858
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F5F0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L07
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L07
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       je        near ptr M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L10
M01_L09:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E98858
       cmp       [rbx+18],rdx
       jne       short M01_L11
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L12
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L12
       jmp       near ptr M01_L17
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82F5F0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L09
M01_L11:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L12:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L14
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L14
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823A12F8
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M01_L15:
       test      eax,eax
       je        short M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F5EFC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rcx,rdx
       mov       r11,7FFF823A1300
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823A1300
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 776
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFF824E41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,13D1B80ADA0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
       test      rsi,rsi
       je        short M00_L03
M00_L00:
       test      r8,r8
       je        short M00_L03
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFF82E1D980]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13D1B80AD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFF82E989A8
       call      qword ptr [7FFF824E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,13D1B80ADA0
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
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L19
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L16
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E989A8
       cmp       [rbx+18],rdx
       jne       short M01_L04
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L05
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L05
       jmp       near ptr M01_L17
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF82F70018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L05:
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L07
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L07
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       short M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       je        near ptr M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L10
M01_L09:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,7FFF82E989A8
       cmp       [rbx+18],rdx
       jne       short M01_L11
       mov       r13,[rax+38]
       test      r13,r13
       mov       rax,[rbp-40]
       je        short M01_L12
       mov       edx,[r13+8]
       test      edx,edx
       je        short M01_L12
       jmp       near ptr M01_L17
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFF82F70018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L09
M01_L11:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L17
M01_L12:
       mov       rax,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L13
       lea       rdi,[rax+8]
       mov       r14,[rdi]
       mov       ecx,[rdi+14]
       cmp       ecx,[r14+14]
       jne       short M01_L14
       mov       r8d,[rdi+10]
       cmp       r8d,[r14+10]
       jae       short M01_L14
       lea       rcx,[rdi+8]
       mov       r15,[r14+8]
       cmp       r8d,[r15+8]
       jae       near ptr M01_L06
       mov       edx,r8d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,rax
       mov       r11,7FFF823A1320
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFF8276E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M01_L15:
       test      eax,eax
       je        short M01_L21
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFF82F4FF40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L17:
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,[rbp-40]
       cmp       [rdx],rax
       jne       short M01_L22
M01_L18:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFF82744F30]
       int       3
M01_L20:
       mov       ecx,0C
       call      qword ptr [7FFF82744F30]
       int       3
M01_L21:
       mov       rcx,rsp
       call      M01_L24
       jmp       short M01_L23
M01_L22:
       mov       rcx,rdx
       mov       r11,7FFF823A1328
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L23:
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
M01_L24:
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
       je        short M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M01_L25
       mov       rcx,rax
       mov       r11,7FFF823A1328
       call      qword ptr [r11]
M01_L25:
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
; Total bytes of code 776
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFF824E41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8296CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82380D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF826FEFB8]
       int       3
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
       mov       rcx,7FFF82405120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22A4BC01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF82380D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF82380D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297C330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       test      rcx,rcx
       je        near ptr M01_L07
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L10
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L09
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L08
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L06
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       near ptr M01_L11
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82390D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L08:
       mov       rcx,7FFF82415120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22DFDC01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFF82390D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L10:
       mov       r11,7FFF82390D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       call      qword ptr [7FFF8270EFB8]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 397
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8297CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82390D38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF8270EFB8]
       int       3
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
       mov       rcx,7FFF82415120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25B78801FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF82390D40
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF82390D30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8296CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L11
       mov       rcx,[rcx+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L10
       cmp       dword ptr [rsi+10],0
       je        near ptr M01_L09
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ecx
       mov       [rdi+1C],esi
M01_L00:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rbp,rcx
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L07
M01_L02:
       cmp       rsi,rbp
       jne       short M01_L03
       lea       r14,[rdi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       short M01_L06
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L12
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rdi
       mov       r11,7FFF82380E20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FFF826FEFB8]
       int       3
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
       mov       rcx,7FFF82405120
       mov       edx,67
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27BBAC01FB8
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFF82380E28
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFF82380E18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       test      rcx,rcx
       je        near ptr M01_L07
       xor       ebx,ebx
       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],r11
       jne       near ptr M01_L08
       mov       rcx,[rcx+8]
       mov       r11,7FFF823A0D10
       call      qword ptr [r11]
       mov       rsi,rax
M01_L00:
       mov       rdi,[rsi]
       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       jmp       short M01_L02
M01_L01:
       add       ebx,1
       jo        near ptr M01_L06
M01_L02:
       cmp       rdi,rbp
       jne       short M01_L03
       lea       r14,[rsi+8]
       mov       rcx,[r14]
       mov       [rsp+28],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       near ptr M01_L09
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       short M01_L04
       lea       rcx,[r14+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L10
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M01_L01
M01_L03:
       mov       rcx,rsi
       mov       r11,7FFF823A0D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L05
M01_L04:
       mov       rcx,[r14]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
M01_L05:
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L08:
       mov       r11,7FFF823A0D00
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFF8271EFB8]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 264
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8298CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
; Total bytes of code 54
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
       je        short M01_L01
       mov       rcx,rbx
       mov       r11,7FFF823A0898
       call      qword ptr [r11]
       mov       rdi,rax
M01_L00:
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.ArrayEnumerator
       mov       rbp,rcx
       jmp       short M01_L03
M01_L01:
       mov       rdi,offset MT_System.ArrayEnumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       short M01_L00
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
       mov       r11,7FFF823A08A0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       mov       r11,7FFF823B0898
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFF8299CC30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       test      rax,rax
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
       mov       r11,7FFF823B0888
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
       mov       r11,7FFF823B0890
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

