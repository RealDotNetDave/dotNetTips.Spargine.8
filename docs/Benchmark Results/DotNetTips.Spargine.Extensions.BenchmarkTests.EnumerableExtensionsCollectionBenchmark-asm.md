## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.CountWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,187F840ACA8
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Count[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFC20666A60]; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,187F840AC98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<CountWithPredicate>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFC1FDB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,187F840ACA8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-0D0],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       lea       rcx,[rbp-0C0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       test      rdi,rdi
       je        near ptr M01_L25
       test      rbx,rbx
       je        near ptr M01_L26
       xor       r14d,r14d
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L22
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       near ptr M01_L07
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<CountWithPredicate>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rcx
       jne       near ptr M01_L13
       mov       r13,[rax+38]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L09
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
       mov       r10,[rcx]
       add       r10,10
M01_L03:
       mov       rcx,[r10+8]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,187F8400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,187F8400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L17
M01_L04:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M01_L21
       mov       r12,rcx
       mov       rcx,[r12+8]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       dword ptr [rbp-44],61
       cmp       [rcx],cl
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       lea       r9,[rbp-44]
       mov       [rbp-60],rdx
       mov       [rbp-58],r8d
       mov       [rbp-70],r9
       mov       dword ptr [rbp-68],1
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rbp-60]
       lea       r8,[rbp-70]
       xor       r9d,r9d
       call      qword ptr [7FFC201FEF88]; System.Globalization.CompareInfo.IcuIndexOfCore(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions, Int32*, Boolean)
       cmp       eax,0FFFFFFFF
       je        short M01_L07
M01_L06:
       add       r14d,1
       jo        near ptr M01_L15
M01_L07:
       mov       rax,[rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L14
       lea       rdi,[rax+8]
       mov       r15,[rdi]
       mov       rcx,r15
       mov       [rbp-80],rcx
       mov       edx,[rdi+14]
       cmp       edx,[rcx+14]
       jne       short M01_L11
       mov       edx,[rdi+10]
       cmp       edx,[rcx+10]
       jae       short M01_L12
       lea       rcx,[rdi+8]
       mov       r8,[rbp-80]
       mov       r8,[r8+8]
       cmp       edx,[r8+8]
       jae       short M01_L08
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFC2080CA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-78]
       mov       ecx,[rdi+14]
       cmp       ecx,[r15+14]
       jne       short M01_L16
M01_L12:
       mov       rax,[rbp-78]
       mov       ecx,[r15+10]
       inc       ecx
       mov       [rdi+10],ecx
       xor       ecx,ecx
       mov       [rdi+8],rcx
       jmp       near ptr M01_L23
M01_L13:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        near ptr M01_L07
       mov       rax,[rbp-78]
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rax
       mov       r11,7FFC1FC70CF0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rbp-78]
       jmp       near ptr M01_L23
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       call      qword ptr [7FFC1FFEEFB8]
       int       3
M01_L17:
       call      qword ptr [7FFC1FF94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[r12+30]
       mov       rdi,r12
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L19
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[rdi+40]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFC201FE838]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L20
M01_L19:
       mov       rdi,r12
       mov       rcx,[rdi+40]
       call      qword ptr [7FFC1FF94630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r15,rax
M01_L20:
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFC2080C958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L23:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L27
M01_L24:
       mov       eax,r14d
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,10
       call      qword ptr [7FFC20014F30]
       int       3
M01_L26:
       mov       ecx,0C
       call      qword ptr [7FFC20014F30]
       int       3
M01_L27:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFC1FC70CF8
       call      qword ptr [r11]
       jmp       short M01_L24
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       cmp       qword ptr [rbp-78],0
       je        short M01_L28
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M01_L28
       mov       rcx,rax
       mov       r11,7FFC1FC70CF8
       call      qword ptr [r11]
M01_L28:
       nop
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
; Total bytes of code 1020
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<CountWithPredicate>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,[rdx+38]
       cmp       [rcx],cl
       mov       edx,61
       xor       r8d,r8d
       call      qword ptr [7FFC1FDB74C8]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 38
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
       call      qword ptr [7FFC1FDB41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAnyWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,17F9EC0ACB0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
       mov       rdx,rsi
       test      rdx,rdx
       je        short M00_L02
M00_L00:
       test      r8,r8
       je        near ptr M00_L06
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFC205F7B10]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,17F9EC0AC98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAnyWithPredicate>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFC1FDC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17F9EC0ACB0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       mov       rdx,rsi
       test      rdx,rdx
       jne       short M00_L00
M00_L02:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,1C0308FB6E8
       mov       rdx,1C0308F0210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C0308F0008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,1C030905680
       mov       rdx,1C0308F0210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C0308F0008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 739
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
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-0D0],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       lea       rcx,[rbp-0C0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       test      rdi,rdi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L24
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L19
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       near ptr M01_L16
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L14
M01_L02:
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAnyWithPredicate>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rcx
       jne       near ptr M01_L15
       mov       r14,[rax+38]
       cmp       [r14],r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L12
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       r10,[rcx]
       add       r10,10
M01_L03:
       mov       rcx,[r10+8]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,17F9EC00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,17F9EC00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L06
M01_L04:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M01_L10
       mov       r15,rcx
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       mov       dword ptr [rbp-44],61
       cmp       [rcx],cl
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       lea       r9,[rbp-44]
       mov       [rbp-60],rdx
       mov       [rbp-58],r8d
       mov       [rbp-70],r9
       mov       dword ptr [rbp-68],1
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rbp-60]
       lea       r8,[rbp-70]
       xor       r9d,r9d
       call      qword ptr [7FFC2020EF88]; System.Globalization.CompareInfo.IcuIndexOfCore(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions, Int32*, Boolean)
       cmp       eax,0FFFFFFFF
       mov       rax,[rbp-78]
       je        near ptr M01_L16
       jmp       near ptr M01_L20
M01_L06:
       call      qword ptr [7FFC1FFA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L07:
       mov       rcx,[r15+30]
       mov       rdi,r15
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L08
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,[rdi+40]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFC2020E838]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L09
M01_L08:
       mov       rdi,r15
       mov       rcx,[rdi+40]
       call      qword ptr [7FFC1FFA4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
M01_L09:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       jmp       near ptr M01_L05
M01_L10:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rax
       mov       r11,7FFC1FC80CF0
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L12:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       near ptr M01_L03
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFC2081D360
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L15:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-78]
       jne       near ptr M01_L20
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L11
       lea       rdi,[rax+8]
       mov       rcx,[rdi]
       mov       [rbp-80],rcx
       mov       edx,[rdi+14]
       cmp       edx,[rcx+14]
       jne       short M01_L17
       mov       edx,[rdi+10]
       cmp       edx,[rcx+10]
       jae       short M01_L17
       lea       rcx,[rdi+8]
       mov       r8,[rbp-80]
       mov       r8,[r8+8]
       cmp       edx,[r8+8]
       jae       short M01_L13
       mov       rdx,[r8+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC2004E688]
M01_L18:
       test      eax,eax
       je        short M01_L25
       jmp       near ptr M01_L01
M01_L19:
       mov       rcx,rsi
       mov       rdx,7FFC2081D288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L20:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L26
M01_L21:
       mov       edx,1
M01_L22:
       movzx     eax,dl
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       ecx,10
       call      qword ptr [7FFC20024F30]
       int       3
M01_L24:
       mov       ecx,0C
       call      qword ptr [7FFC20024F30]
       int       3
M01_L25:
       mov       rcx,rsp
       call      M01_L28
       jmp       short M01_L27
M01_L26:
       mov       rcx,rax
       mov       r11,7FFC1FC80CF8
       call      qword ptr [r11]
       jmp       short M01_L21
M01_L27:
       xor       edx,edx
       jmp       short M01_L22
M01_L28:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       cmp       qword ptr [rbp-78],0
       je        short M01_L29
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M01_L29
       mov       rcx,rax
       mov       r11,7FFC1FC80CF8
       call      qword ptr [r11]
M01_L29:
       nop
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
; Total bytes of code 973
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAnyWithPredicate>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,[rdx+38]
       cmp       [rcx],cl
       mov       edx,61
       xor       r8d,r8d
       call      qword ptr [7FFC1FDC74C8]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 38
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
       call      qword ptr [7FFC1FDC41F8]
       int       3
; Total bytes of code 44
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFC1FFFEF10]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,1C0308F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M05_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M05_L01
M05_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M05_L01
       call      qword ptr [7FFC202ADC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202AD4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202ADEA8]
M05_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M05_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M05_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
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
       je        short M06_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCountWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       r8,12E05C0ACB8
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
       mov       rdx,rsi
       test      rdx,rdx
       je        short M00_L02
M00_L00:
       test      r8,r8
       je        near ptr M00_L06
       mov       rcx,offset MD_System.Linq.Enumerable.Count[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFC20656B08]; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       movsxd    rcx,eax
       mov       rax,[rbx+18]
       mov       [rax+18],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,12E05C0AC98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCountWithPredicate>b__17_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFC1FDA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12E05C0ACB8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       mov       rdx,rsi
       test      rdx,rdx
       jne       short M00_L00
M00_L02:
       call      qword ptr [7FFC2028DB78]
       mov       rcx,16E939CB6E8
       mov       rdx,16E939C0210
       call      qword ptr [7FFC1FDA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16E939C0008
       call      qword ptr [7FFC1FDA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC2028DC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201108A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201108A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC2028D4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC2028D890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC2028DE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20006670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC2028D890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20006670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFC2028DB78]
       mov       rcx,16E939D5680
       mov       rdx,16E939C0210
       call      qword ptr [7FFC1FDA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16E939C0008
       call      qword ptr [7FFC1FDA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC2028DC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201108A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201108A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC2028D4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC2028D890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC2028DE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20006670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC2028D890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20006670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 743
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-0D0],rsp
       mov       [rbp-40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       lea       rcx,[rbp-0C0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       test      rdi,rdi
       je        near ptr M01_L26
       test      rbx,rbx
       je        near ptr M01_L27
       xor       r14d,r14d
       mov       rcx,[rsi+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L22
M01_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       near ptr M01_L07
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L10
M01_L02:
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCountWithPredicate>b__17_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [rbx+18],rcx
       jne       near ptr M01_L13
       mov       r13,[rax+38]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L09
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
       mov       r10,[rcx]
       add       r10,10
M01_L03:
       mov       rcx,[r10+8]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,12E05C00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L04
       mov       rcx,12E05C00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L17
M01_L04:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M01_L21
       mov       r12,rcx
       mov       rcx,[r12+8]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       dword ptr [rbp-44],61
       cmp       [rcx],cl
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       lea       r9,[rbp-44]
       mov       [rbp-60],rdx
       mov       [rbp-58],r8d
       mov       [rbp-70],r9
       mov       dword ptr [rbp-68],1
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rbp-60]
       lea       r8,[rbp-70]
       xor       r9d,r9d
       call      qword ptr [7FFC201EEF88]; System.Globalization.CompareInfo.IcuIndexOfCore(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions, Int32*, Boolean)
       cmp       eax,0FFFFFFFF
       je        short M01_L07
M01_L06:
       add       r14d,1
       jo        near ptr M01_L15
M01_L07:
       mov       rax,[rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L14
       lea       rdi,[rax+8]
       mov       r15,[rdi]
       mov       rcx,r15
       mov       [rbp-80],rcx
       mov       edx,[rdi+14]
       cmp       edx,[rcx+14]
       jne       short M01_L11
       mov       edx,[rdi+10]
       cmp       edx,[rcx+10]
       jae       short M01_L12
       lea       rcx,[rdi+8]
       mov       r8,[rbp-80]
       mov       r8,[r8+8]
       cmp       edx,[r8+8]
       jae       short M01_L08
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       near ptr M01_L01
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFC207FCD30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-78]
       mov       ecx,[rdi+14]
       cmp       ecx,[r15+14]
       jne       short M01_L16
M01_L12:
       mov       rax,[rbp-78]
       mov       ecx,[r15+10]
       inc       ecx
       mov       [rdi+10],ecx
       xor       ecx,ecx
       mov       [rdi+8],rcx
       jmp       near ptr M01_L24
M01_L13:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        near ptr M01_L07
       mov       rax,[rbp-78]
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rax
       mov       r11,7FFC1FC60CF0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rbp-78]
       jmp       near ptr M01_L24
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       call      qword ptr [7FFC1FFDEFB8]
       int       3
M01_L17:
       call      qword ptr [7FFC1FF84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[r12+30]
       mov       rdi,r12
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L19
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[rdi+40]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFC201EE838]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L20
M01_L19:
       mov       rdi,r12
       mov       rcx,[rdi+40]
       call      qword ptr [7FFC1FF84630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r15,rax
M01_L20:
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFC207FCC58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L23:
       mov       eax,r14d
       jmp       short M01_L25
M01_L24:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L28
       jmp       short M01_L23
M01_L25:
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       ecx,10
       call      qword ptr [7FFC20004F30]
       int       3
M01_L27:
       mov       ecx,0C
       call      qword ptr [7FFC20004F30]
       int       3
M01_L28:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFC1FC60CF8
       call      qword ptr [r11]
       jmp       short M01_L23
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       cmp       qword ptr [rbp-78],0
       je        short M01_L29
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M01_L29
       mov       rcx,rax
       mov       r11,7FFC1FC60CF8
       call      qword ptr [r11]
M01_L29:
       nop
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
; Total bytes of code 1024
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCountWithPredicate>b__17_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,[rdx+38]
       cmp       [rcx],cl
       mov       edx,61
       xor       r8d,r8d
       call      qword ptr [7FFC1FDA74C8]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 38
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
       call      qword ptr [7FFC1FDA41F8]
       int       3
; Total bytes of code 44
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFC1FFDEF10]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,16E939C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
       call      qword ptr [7FFC1FDA6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M05_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDA6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M05_L01
M05_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M05_L01
       call      qword ptr [7FFC2028DC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC2028D4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC2028DEA8]
M05_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M05_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M05_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDA7318]; System.String.Trim()
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
       je        short M06_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+30]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean ByRef)
       call      qword ptr [7FFC20115FC8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L01
M00_L00:
       mov       [rsp+28],rax
       mov       rdi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFC20034F90]
       int       3
M00_L02:
       mov       rax,rdi
       xor       ecx,ecx
       test      rax,rax
       setne     cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFC202BD2D8]
       mov       rcx,28C35965680
       mov       rdx,28C35950210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,28C35950008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202BD3F8]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC20140C58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC20140C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BCC00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BCFF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BD578]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BCFF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L00
; Total bytes of code 481
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L26
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L03
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L27
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L30
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L06
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L06
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-40],rsi
       jmp       short M01_L07
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFC207702A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFC20770498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFC207705C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L13
       mov       r15,rsi
       mov       r13d,[r15+14]
       cmp       r13d,1
       jne       near ptr M01_L17
       mov       rcx,[r15+18]
       mov       r11,7FFC1FC90D28
       call      qword ptr [r11]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       jne       near ptr M01_L15
       lea       rdi,[rcx+8]
       mov       rcx,[rdi]
       mov       [rbp-48],rcx
       mov       edx,[rdi+14]
       cmp       edx,[rcx+14]
       jne       short M01_L09
       mov       edx,[rdi+10]
       cmp       edx,[rcx+10]
       jae       short M01_L09
       lea       rcx,[rdi+8]
       mov       rax,[rbp-48]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rdi+10]
       jmp       short M01_L10
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC2005E688]
       test      eax,eax
       je        near ptr M01_L16
M01_L10:
       mov       rcx,[r15+28]
       mov       r11,7FFC1FC90D38
       call      qword ptr [r11]
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+14],2
M01_L11:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L19
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L19
M01_L12:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L20
M01_L13:
       mov       rcx,rsi
       mov       r11,7FFC1FC90D18
       call      qword ptr [r11]
       mov       edi,eax
M01_L14:
       test      edi,edi
       je        near ptr M01_L24
       jmp       short M01_L11
M01_L15:
       mov       r11,7FFC1FC90D30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
M01_L16:
       mov       rdx,[r15+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+14],0FFFFFFFF
       jmp       short M01_L11
M01_L17:
       cmp       r13d,2
       jne       short M01_L18
       mov       rcx,[r15+28]
       mov       r11,7FFC1FC90D40
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       mov       rcx,[r15+28]
       mov       r11,7FFC1FC90D48
       call      qword ptr [r11]
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L11
M01_L18:
       mov       rcx,r15
       call      qword ptr [7FFC20686630]; System.Linq.Enumerable+DefaultIfEmptyIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       edi,edi
       jmp       short M01_L14
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFC207706E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L12
M01_L20:
       mov       rax,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rax
       jne       short M01_L23
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M01_L22
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L35
M01_L21:
       xor       eax,eax
       mov       [rsi+28],rax
M01_L22:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M01_L04
M01_L23:
       mov       rcx,rsi
       mov       r11,7FFC1FC90D20
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,rsp
       call      M01_L36
       nop
M01_L25:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
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
M01_L26:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M01_L27:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L28
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFC207707F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L31
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L31
       jmp       short M01_L32
M01_L31:
       mov       rcx,rbx
       mov       rdx,7FFC207707C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L32:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L25
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L33
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L33
       jmp       short M01_L34
M01_L33:
       mov       rcx,rbx
       mov       rdx,7FFC207707D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L34:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       r11,7FFC1FC90D50
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L36:
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
       je        short M01_L40
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rsi,[rbp-40]
       cmp       [rsi],rcx
       jne       short M01_L39
       cmp       qword ptr [rsi+28],0
       je        short M01_L38
       mov       rcx,[rsi+28]
       mov       r11,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],r11
       je        short M01_L37
       mov       r11,7FFC1FC90D50
       call      qword ptr [r11]
M01_L37:
       xor       ecx,ecx
       mov       [rsi+28],rcx
M01_L38:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       short M01_L40
M01_L39:
       mov       rcx,rsi
       mov       r11,7FFC1FC90D20
       call      qword ptr [r11]
M01_L40:
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
; Total bytes of code 1183
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2000EF10]
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
       mov       rax,28C35950008
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
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFC202BD3F8]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202BCC48]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202BD608]
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
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
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
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFC7F765308]
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
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultPredicateAlternate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+190]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultPredicateAlternate>b__19_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rsi,[rbx+40]
       xor       edx,edx
       test      rsi,rsi
       setne     dl
       test      edx,edx
       je        short M00_L01
       test      rdi,rdi
       je        near ptr M00_L05
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFC20214138]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L05
       mov       rcx,rdi
       call      qword ptr [7FFC2024C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L05
       mov       r8,rsi
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFC20666B38]
M00_L00:
       mov       [rsp+28],rax
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
M00_L01:
       call      qword ptr [7FFC2029DB78]
       mov       rcx,1A9D48B5680
       mov       rdx,1A9D48A0210
       call      qword ptr [7FFC1FDB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A9D48A0008
       call      qword ptr [7FFC1FDB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L02
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L03
M00_L02:
       mov       ecx,1
M00_L03:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L04
       call      qword ptr [7FFC2029DC98]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFC201208A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFC201208A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC2029D4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC2029D890]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC2029DE18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFC20016670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC2029D890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20016670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,rsi
       jmp       near ptr M00_L00
; Total bytes of code 499
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultPredicateAlternate>b__19_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       r8,[rdx+30]
       mov       rdx,[rcx+40]
       mov       rdx,[rdx+30]
       cmp       r8,rdx
       jne       short M01_L00
       mov       eax,1
       jmp       short M01_L03
M01_L00:
       test      r8,r8
       je        short M01_L01
       test      rdx,rdx
       je        short M01_L01
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       je        short M01_L02
M01_L01:
       xor       eax,eax
       jmp       short M01_L03
M01_L02:
       add       r8,0C
       mov       [rsp+20],r8
       add       ecx,ecx
       mov       r8d,ecx
       add       rdx,0C
       mov       rcx,[rsp+20]
       call      qword ptr [7FFC1FE65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       nop
       add       rsp,28
       ret
; Total bytes of code 86
```
```assembly
; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L09
       test      rdi,rdi
       je        near ptr M02_L10
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFC2080C998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L02
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFC2080CBD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDB4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L12
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L04
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       rdx,7FFC2080CCF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M02_L18
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       rdx,7FFC2080D198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M02_L08:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFC20014F30]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFC20014F30]
       int       3
M02_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [rax+10]
M02_L12:
       cmp       dword ptr [rbp+8],0
       je        short M02_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],70
       jle       short M02_L13
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFC2080D3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rdi
       call      qword ptr [7FFC20214720]
       mov       rax,rbx
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M02_L16
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rbx
       mov       rdx,7FFC2080D320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC2021E178]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M02_L18:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M02_L19
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rbx
       mov       rdx,7FFC2080D2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFC20214498]
       mov       rax,rbx
       jmp       near ptr M02_L08
; Total bytes of code 601
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M03_L29
       xor       ebx,ebx
       mov       rax,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L30
       mov       rsi,rcx
       cmp       dword ptr [rsi+14],0
       jne       short M03_L02
       mov       edi,[rsi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       edi,eax
       jne       short M03_L02
       mov       rax,rsi
M03_L00:
       mov       dword ptr [rax+14],1
       mov       rsi,rax
M03_L01:
       test      rsi,rsi
       je        near ptr M03_L23
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M03_L23
       jmp       near ptr M03_L06
M03_L02:
       mov       rcx,rsi
       call      qword ptr [7FFC20674658]; Precode of System.Linq.Enumerable+WhereEnumerableIterator`1[[System.__Canon, System.Private.CoreLib]].Clone()
       jmp       short M03_L00
M03_L03:
       mov       rcx,[rsi+28]
       mov       r11,7FFC1FC70D78
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+20]
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultPredicateAlternate>b__19_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [r13+18],r8
       jne       near ptr M03_L32
       mov       r12,[r13+8]
       mov       rcx,[r15+30]
       mov       r8,[r12+40]
       mov       rdx,[r8+30]
       cmp       rcx,rdx
       jne       near ptr M03_L07
       mov       eax,1
M03_L04:
       test      eax,eax
       jne       near ptr M03_L33
M03_L05:
       mov       rcx,[rsi+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       jne       near ptr M03_L11
       lea       rbp,[rcx+8]
       mov       rdi,[rbp]
       mov       rax,rdi
       mov       ecx,[rbp+14]
       cmp       ecx,[rax+14]
       jne       near ptr M03_L39
       mov       r8d,[rbp+10]
       cmp       r8d,[rax+10]
       jae       near ptr M03_L10
       lea       rcx,[rbp+8]
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M03_L40
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbp+10]
       jmp       near ptr M03_L03
M03_L06:
       mov       rax,rsi
       mov       edi,[rax+14]
       cmp       edi,1
       jne       near ptr M03_L22
       mov       rcx,[rsi+18]
       mov       r11,7FFC1FC70D68
       call      qword ptr [r11]
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+14],2
       jmp       near ptr M03_L05
M03_L07:
       test      rcx,rcx
       je        short M03_L08
       test      rdx,rdx
       je        short M03_L08
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M03_L09
M03_L08:
       xor       eax,eax
       jmp       near ptr M03_L04
M03_L09:
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFC1FE65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,[rdi+10]
       inc       ecx
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp+8],rcx
       jmp       short M03_L12
M03_L11:
       mov       r11,7FFC1FC70D70
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L03
M03_L12:
       cmp       qword ptr [rsi+28],0
       je        short M03_L13
       mov       rcx,[rsi+28]
       mov       r11,7FFC1FC70D80
       call      qword ptr [r11]
       xor       eax,eax
       mov       [rsi+28],rax
M03_L13:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
M03_L14:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L15:
       mov       rcx,[rsi+28]
       mov       r11,7FFC1FC70D78
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+20]
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultPredicateAlternate>b__19_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       cmp       [r13+18],r8
       jne       near ptr M03_L34
       mov       r12,[r13+8]
       mov       rcx,[r15+30]
       mov       r8,[r12+40]
       mov       rdx,[r8+30]
       cmp       rcx,rdx
       jne       short M03_L16
       mov       eax,1
       jmp       short M03_L19
M03_L16:
       test      rcx,rcx
       je        short M03_L17
       test      rdx,rdx
       je        short M03_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M03_L18
M03_L17:
       xor       eax,eax
       jmp       short M03_L19
M03_L18:
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFC1FE65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M03_L19:
       test      eax,eax
       jne       near ptr M03_L35
M03_L20:
       mov       rcx,[rsi+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       jne       near ptr M03_L24
       lea       rbp,[rcx+8]
       mov       rax,[rbp]
       mov       ecx,[rbp+14]
       cmp       ecx,[rax+14]
       jne       near ptr M03_L39
       mov       r8d,[rbp+10]
       cmp       r8d,[rax+10]
       jae       short M03_L21
       lea       rcx,[rbp+8]
       mov       r14,[rax+8]
       cmp       r8d,[r14+8]
       jae       near ptr M03_L40
       mov       edx,r8d
       mov       rdx,[r14+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbp+10]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,[rbp]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rbp+10],ecx
       xor       ecx,ecx
       mov       [rbp+8],rcx
       jmp       short M03_L25
M03_L22:
       cmp       edi,2
       jne       near ptr M03_L14
       jmp       near ptr M03_L05
M03_L23:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M03_L38
       mov       rax,rsi
       mov       edi,[rax+14]
       cmp       edi,1
       jne       short M03_L27
       mov       rcx,[rsi+18]
       mov       r11,7FFC1FC70D68
       call      qword ptr [r11]
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+14],2
       jmp       near ptr M03_L20
M03_L24:
       mov       r11,7FFC1FC70D70
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L15
M03_L25:
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M03_L26
       mov       r11,7FFC1FC70D80
       call      qword ptr [r11]
       xor       eax,eax
       mov       [rsi+28],rax
M03_L26:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M03_L14
M03_L27:
       cmp       edi,2
       jne       near ptr M03_L14
       jmp       near ptr M03_L20
M03_L28:
       call      CORINFO_HELP_OVERFLOW
M03_L29:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L30:
       mov       r11,7FFC1FC70D58
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M03_L01
M03_L31:
       add       ebx,1
       jo        short M03_L28
       jmp       near ptr M03_L06
M03_L32:
       mov       rdx,r15
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       jmp       near ptr M03_L04
M03_L33:
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       jmp       short M03_L36
M03_L34:
       mov       rdx,r15
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        near ptr M03_L20
M03_L35:
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L37
M03_L36:
       test      eax,eax
       jne       short M03_L31
       jmp       near ptr M03_L14
M03_L37:
       add       ebx,1
       jo        near ptr M03_L28
       jmp       near ptr M03_L23
M03_L38:
       mov       rcx,rsi
       mov       r11,7FFC1FC70D60
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L37
       jmp       near ptr M03_L14
M03_L39:
       call      qword ptr [7FFC1FFEEFB8]
       int       3
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFC1FFEEF10]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,1A9D48A0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
       call      qword ptr [7FFC1FDB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M05_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M05_L01
M05_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M05_L01
       call      qword ptr [7FFC2029DC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC2029D4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC2029DEA8]
M05_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M05_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M05_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDB7318]; System.String.Trim()
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
       je        short M06_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       esi,[rbx+184]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFC2024C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
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
       mov       r11,7FFC1FC70CF0
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
       call      qword ptr [7FFC1FFEEFB8]
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
       mov       rcx,7FFC1FCF5120
       mov       edx,65
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29A8D801F90
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFC1FC70CF8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFC1FC70CE8
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.IndexOfComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+190]
       lea       r8,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean ByRef)
       call      qword ptr [7FFC20686A18]; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rsi
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Collections.Generic.IEqualityComparer`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC206869D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFC20034F90]
       int       3
; Total bytes of code 120
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L17
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L00
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFC207FF010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L18
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFC207FF200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L04
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFC207FF528
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L15
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L06
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFC207FF540
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       lea       edx,[rsi-1]
       mov       rcx,rdi
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L09
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFC207FF330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90E38
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
M01_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FFC207FF348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90E40
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       [rbp-30],rsi
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L16
M01_L14:
       mov       rcx,rsp
       call      M01_L21
       nop
M01_L15:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L17:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M01_L18:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L19
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFC207FF558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L21:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L22
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90E48
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L01:
       mov       rdx,rsi
       mov       r8,25318A40008
       mov       r9,25318A4B6E8
       call      qword ptr [7FFC204CCFC0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rdx,[r14+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        near ptr M02_L34
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M02_L38
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M02_L17
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L17
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass23_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rdi+18],rcx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L19
       mov       rbp,[rcx+38]
       test      rbp,rbp
       je        near ptr M02_L19
M02_L03:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M02_L21
       mov       r14,[rcx+40]
       test      r14,r14
       je        near ptr M02_L21
M02_L04:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC20686BB0]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rsi,rax
       mov       rcx,r14
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M02_L42
M02_L05:
       test      rsi,rsi
       je        near ptr M02_L47
       test      rdx,rdx
       je        near ptr M02_L48
       mov       rcx,rsi
       call      qword ptr [7FFC20687018]; System.Linq.Enumerable.Where[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L47
       xor       ebp,ebp
       mov       r14,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Int32, System.Private.CoreLib]]
       cmp       [rdi],r14
       jne       near ptr M02_L52
       mov       rax,rdi
       cmp       dword ptr [rax+0C],0
       jne       short M02_L06
       mov       ebx,[rdi+8]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M02_L23
M02_L06:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       r15,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+8],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L07:
       mov       dword ptr [rbx+0C],1
M02_L08:
       cmp       [rbx],r14
       jne       near ptr M02_L24
       mov       rax,rbx
       mov       eax,[rax+0C]
       cmp       eax,1
       je        near ptr M02_L27
       cmp       eax,2
       jne       near ptr M02_L25
M02_L09:
       mov       rcx,[rbx+28]
       mov       r11,7FFC1FC90E68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L18
M02_L10:
       mov       rcx,[rbx+28]
       mov       rdx,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       cmp       [rcx],rdx
       jne       near ptr M02_L31
       mov       esi,[rcx+34]
       mov       r15,[rbx+20]
       mov       rdx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__23`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__23_1(Int32)
       cmp       [r15+18],rdx
       jne       short M02_L14
       cmp       esi,0FFFFFFFF
       je        short M02_L15
M02_L11:
       mov       [rbx+10],esi
M02_L12:
       add       ebp,1
       jo        near ptr M02_L33
       jmp       short M02_L08
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFC2066D1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L14:
       mov       edx,esi
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rcx,[rbx+28]
       mov       r11,7FFC1FC90E68
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       jmp       short M02_L18
M02_L16:
       mov       rcx,rbx
       mov       rdx,7FFC2066D1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L17:
       mov       rcx,rbx
       mov       rdx,7FFC2066D4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L18:
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L20
M02_L19:
       mov       rcx,rbx
       mov       rdx,7FFC2066D598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
       jmp       near ptr M02_L03
M02_L20:
       mov       r11,7FFC1FC90E78
       call      qword ptr [r11]
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M02_L22
M02_L21:
       mov       rcx,rbx
       mov       rdx,7FFC2066D8E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
       jmp       near ptr M02_L04
M02_L22:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       dword ptr [rbx+0C],0FFFFFFFF
       jmp       short M02_L25
M02_L23:
       mov       rbx,rdi
       jmp       near ptr M02_L07
M02_L24:
       mov       rcx,rbx
       mov       r11,7FFC1FC90E58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L12
M02_L25:
       mov       ecx,ebp
       test      ecx,ecx
       jle       near ptr M02_L47
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+8],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],0FFFFFFFF
       lea       rdx,[rsp+28]
       mov       rcx,rbx
       call      qword ptr [7FFC206878B8]; System.Linq.Enumerable.TryGetFirst[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        near ptr M02_L32
M02_L26:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L27:
       mov       rcx,[rbx+18]
       mov       rsi,rcx
       mov       rax,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       cmp       [rsi],rax
       jne       near ptr M02_L53
       cmp       dword ptr [rsi+30],0FFFFFFFE
       jne       short M02_L28
       mov       r15d,[rsi+38]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       short M02_L28
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       r15,rsi
       jmp       short M02_L29
M02_L28:
       mov       rcx,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       eax,eax
       mov       [r15+30],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+38],eax
M02_L29:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
M02_L30:
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+0C],2
       jmp       near ptr M02_L09
M02_L31:
       mov       r11,7FFC1FC90E70
       call      qword ptr [r11]
       mov       esi,eax
       mov       r15,[rbx+20]
       jmp       near ptr M02_L14
M02_L32:
       call      qword ptr [7FFC20034F90]
       int       3
M02_L33:
       call      CORINFO_HELP_OVERFLOW
M02_L34:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,25318A4B588
       mov       rdx,25318A40210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,25318A40008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L35
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L36
M02_L35:
       mov       ecx,1
M02_L36:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L37
       call      qword ptr [7FFC202BDC98]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFC20036670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L37:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFC20036670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L38:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,25318A55680
       mov       rdx,25318A40210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,25318A40008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L39
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L40
M02_L39:
       mov       ecx,1
M02_L40:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L41
       call      qword ptr [7FFC202BDC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L41:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L42:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L43
       mov       rdi,[rcx+40]
       test      rdi,rdi
       je        short M02_L43
       jmp       short M02_L44
M02_L43:
       mov       rcx,rbx
       mov       rdx,7FFC2066D8E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M02_L44:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__23`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__23_1(Int32)
       call      qword ptr [7FFC1FDD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L45
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rbx
       mov       rdx,7FFC2066D8E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L46:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       jmp       near ptr M02_L05
M02_L47:
       mov       eax,0FFFFFFFF
       jmp       near ptr M02_L26
M02_L48:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,25318A556D0
       mov       rdx,25318A40210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,25318A40008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L49
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L50
M02_L49:
       mov       ecx,1
M02_L50:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L51
       call      qword ptr [7FFC202BDC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L51:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L52:
       mov       rcx,rdi
       mov       r11,7FFC1FC90E50
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M02_L08
M02_L53:
       mov       rcx,rsi
       mov       r11,7FFC1FC90E60
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L30
; Total bytes of code 2202
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_312.__ForDisassemblyDiagnoser__()

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.AddDistinct()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       mov       rdi,[rbx+198]
       test      rdi,rdi
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M00_L02
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC204FD800]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.AddDistinct[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
       call      qword ptr [7FFC206757B8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.AddDistinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FFC20024F30]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFC1FC80D18
       call      qword ptr [r11]
       jmp       short M00_L00
; Total bytes of code 168
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M01_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M01_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M01_L04
M01_L00:
       cmp       [r10],rcx
       je        short M01_L02
       cmp       [r10+8],rcx
       je        short M01_L02
       cmp       [r10+10],rcx
       je        short M01_L02
       cmp       [r10+18],rcx
       je        short M01_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L00
       test      r8,r8
       jne       short M01_L04
M01_L01:
       test      dword ptr [rbx],406C0000
       jne       short M01_L03
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       pop       rbx
       ret
M01_L03:
       pop       rbx
       jmp       qword ptr [7FFC1FDC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
       jmp       short M01_L01
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L00
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFC2081C408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFC2081C428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M02_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       rdx,7FFC2081C440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L06
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       rdx,7FFC2081C550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rsi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rbx
       mov       rdx,7FFC2081C418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC20806850]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FFC2081C418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFC208068C8]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFC2081C418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC20806958]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rbx
       mov       rdx,7FFC2081C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FFC2022D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 521
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.AddDistinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M03_L11
       test      rbx,rbx
       je        near ptr M03_L14
M03_L00:
       xor       ebp,ebp
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [r14+10],0FFFFFFFFFFFFFFFF
       jmp       short M03_L02
M03_L01:
       add       ebp,1
       jo        near ptr M03_L10
M03_L02:
       mov       rcx,r14
       mov       rdx,[rcx+10]
       inc       rdx
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       rdx,rcx
       jae       short M03_L03
       mov       [r14+10],rdx
       jmp       short M03_L01
M03_L03:
       mov       [r14+10],rcx
       test      ebp,ebp
       jle       near ptr M03_L14
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L05
M03_L04:
       mov       rdx,rdi
       call      qword ptr [7FFC2025C708]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M03_L09
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFC2065B138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L04
M03_L06:
       mov       ecx,ebp
       mov       r15,[rbx+rcx*8+10]
       cmp       dword ptr [rdi+10],0
       je        short M03_L07
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFC1FF31C68]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].IndexOf(System.__Canon)
       test      eax,eax
       jge       short M03_L08
M03_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       r13d,[rdi+10]
       cmp       [rcx+8],r13d
       ja        short M03_L15
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFC1FE7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L08:
       inc       ebp
       cmp       r14d,ebp
       jg        short M03_L06
M03_L09:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFC2065B5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      qword ptr [7FFC2022D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M03_L00
M03_L14:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L15:
       lea       edx,[r13+1]
       mov       [rdi+10],edx
       movsxd    rdx,r13d
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L08
; Total bytes of code 378
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.AddIf()
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
       test      rdi,rdi
       je        short M00_L01
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrependIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+30],1
M00_L00:
       mov       rsi,rbp
M00_L01:
       mov       [rsp+30],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFC206658D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFC2029DB78]
       mov       rcx,296079EB6E8
       mov       rdx,296079E0210
       call      qword ptr [7FFC1FDB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,296079E0008
       call      qword ptr [7FFC1FDB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC2029DC98]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFC201208A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFC201208A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC2029D4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC2029D890]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC2029DE18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20016670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC2029D890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20016670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rbp,rax
       jmp       near ptr M00_L00
; Total bytes of code 482
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M01_L03
       cmp       [rax],rcx
       je        short M01_L03
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M01_L00:
       cmp       rdx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M01_L02
       test      rdx,rdx
       jne       short M01_L04
M01_L01:
       xor       eax,eax
M01_L02:
       ret
M01_L03:
       ret
M01_L04:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L01
       mov       rdx,[rdx+10]
       jmp       short M01_L00
; Total bytes of code 82
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFC1FFEEF10]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,296079E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
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
       call      qword ptr [7FFC1FDB6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M04_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDB6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M04_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M04_L01
M04_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M04_L01
       call      qword ptr [7FFC2029DC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC2029D4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC2029DEA8]
M04_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M04_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDB7318]; System.String.Trim()
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
       je        short M05_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M05_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M05_L04
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M05_L04
M05_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M05_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M05_L04
       jmp       short M05_L03
M05_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M05_L04
M05_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ContainsAny()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean ByRef)
       call      qword ptr [7FFC2011E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L03
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrependIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L08
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+30],1
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L09
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       mov       r8d,0A
       call      qword ptr [7FFC204CD248]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L10
       mov       rcx,rax
       mov       r11,7FFC1FC90DF8
       call      qword ptr [r11]
       mov       r14,rax
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L11
       call      qword ptr [7FFC2026C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L11
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rsi+18],r8
       mov       rdx,rbp
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFC20607B10]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L02:
       mov       [rsp+30],al
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20686F58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rbp,rsi
       jmp       near ptr M00_L00
M00_L04:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,2EC8C43B6E8
       mov       rdx,2EC8C430210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2EC8C430008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L05
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L06
M00_L05:
       mov       ecx,1
M00_L06:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L07
       call      qword ptr [7FFC202BDC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L09:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M00_L10:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC2050D800]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L11:
       xor       eax,eax
       jmp       near ptr M00_L02
; Total bytes of code 769
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L16
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFC20761258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L17
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFC20761448
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L04
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFC20761770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L14
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L06
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFC20761788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFC20761578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90DC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L13
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L11
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFC20761698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L15
M01_L13:
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L14:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L15:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L16:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M01_L17:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L18
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFC207617A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L19:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90DD0
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 614
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M02_L03
       cmp       [rax],rcx
       je        short M02_L03
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M02_L00:
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       jne       short M02_L04
M02_L01:
       xor       eax,eax
M02_L02:
       ret
M02_L03:
       ret
M02_L04:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       jmp       short M02_L00
; Total bytes of code 82
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFC2082F118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M03_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M03_L02
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFC2082F140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M03_L06
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M03_L04
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rdx,7FFC2082F268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+28],eax
       dec       edi
       mov       [rbx+2C],edi
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L06:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M03_L07
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rbx
       mov       rdx,7FFC2082F258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFC20605F08]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rbx
       mov       rdx,7FFC2082F128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L11:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 380
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rbx,[rdx]
       movzx     eax,word ptr [rbx+0E]
       test      rax,rax
       je        short M04_L01
       mov       r8,[rbx+38]
       cmp       rax,4
       jl        short M04_L03
M04_L00:
       cmp       [r8],rcx
       je        short M04_L02
       cmp       [r8+8],rcx
       je        short M04_L02
       cmp       [r8+10],rcx
       je        short M04_L02
       cmp       [r8+18],rcx
       je        short M04_L02
       add       r8,20
       add       rax,0FFFFFFFFFFFFFFFC
       cmp       rax,4
       jge       short M04_L00
       test      rax,rax
       jne       short M04_L03
M04_L01:
       test      dword ptr [rbx],406C0000
       jne       short M04_L04
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       ret
M04_L03:
       cmp       [r8],rcx
       je        short M04_L02
       add       r8,8
       dec       rax
       test      rax,rax
       jg        short M04_L03
       jmp       short M04_L01
M04_L04:
       pop       rbx
       jmp       qword ptr [7FFC1FDD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 111
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
       je        near ptr M05_L07
       xor       esi,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       cmp       [rbx],rcx
       jne       near ptr M05_L08
       mov       rdi,offset MT_System.ArrayEnumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
M05_L00:
       mov       rbx,[rdi]
       mov       rcx,offset MT_System.ArrayEnumerator
       mov       rbp,rcx
       jmp       short M05_L02
M05_L01:
       add       esi,1
       jo        short M05_L06
M05_L02:
       cmp       rbx,rbp
       jne       short M05_L03
       mov       rcx,rdi
       mov       r11,[rcx+10]
       inc       r11
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       r11,rcx
       jae       short M05_L05
       mov       [rdi+10],r11
       jmp       short M05_L01
M05_L03:
       mov       rcx,rdi
       mov       r11,7FFC1FC90E50
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L01
M05_L04:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       mov       [rdi+10],rcx
       jmp       short M05_L04
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L08:
       mov       rcx,rbx
       mov       r11,7FFC1FC90E48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M05_L00
; Total bytes of code 215
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M06_L00
       mov       rcx,rax
       jmp       short M06_L01
M06_L00:
       mov       rdx,7FFC2066DDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M06_L01:
       mov       rdx,[rbx+8]
       mov       r8,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC20686E98]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
; Total bytes of code 78
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M07_L18
       test      rsi,rsi
       je        near ptr M07_L19
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M07_L13
M07_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-38],rdi
       test      rdi,rdi
       je        near ptr M07_L08
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       near ptr M07_L08
       mov       r14,[rdi]
       mov       r15,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,r15
       jne       near ptr M07_L08
       jmp       short M07_L03
M07_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
M07_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [7FFC20686C28]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       test      eax,eax
       jne       near ptr M07_L14
M07_L03:
       mov       rcx,rdi
       call      qword ptr [7FFC20616FE0]; System.Linq.Enumerable+AppendPrepend1Iterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M07_L20
       jmp       short M07_L01
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFC2082FC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M07_L02
M07_L05:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L10
M07_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M07_L11
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [7FFC20686C28]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass6_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
M07_L07:
       test      eax,eax
       jne       short M07_L14
M07_L08:
       mov       r14,[rdi]
       mov       r15,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,r15
       jne       short M07_L12
       mov       rcx,rdi
       call      qword ptr [7FFC20616FE0]; System.Linq.Enumerable+AppendPrepend1Iterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M07_L09:
       test      eax,eax
       je        near ptr M07_L20
       jmp       short M07_L05
M07_L10:
       mov       rcx,rbx
       mov       rdx,7FFC2082FC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M07_L06
M07_L11:
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M07_L07
M07_L12:
       mov       rcx,rdi
       mov       r11,7FFC1FC90E58
       call      qword ptr [r11]
       jmp       short M07_L09
M07_L13:
       mov       rcx,rbx
       mov       rdx,7FFC2082FB38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L14:
       cmp       r14,r15
       jne       short M07_L22
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M07_L16
       mov       rax,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       short M07_L21
M07_L15:
       xor       eax,eax
       mov       [rdi+20],rax
M07_L16:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
M07_L17:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L18:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M07_L19:
       mov       ecx,0C
       call      qword ptr [7FFC20034F30]
       int       3
M07_L20:
       mov       rcx,rsp
       call      M07_L24
       jmp       short M07_L23
M07_L21:
       mov       r11,7FFC1FC90E68
       call      qword ptr [r11]
       jmp       short M07_L15
M07_L22:
       mov       rcx,rdi
       mov       r11,7FFC1FC90E60
       call      qword ptr [r11]
       jmp       short M07_L17
M07_L23:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L24:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M07_L28
       mov       rcx,[rbp-38]
       mov       r14,[rcx]
       mov       r15,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,r15
       jne       short M07_L27
       mov       rdi,rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M07_L26
       mov       r11,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],r11
       je        short M07_L25
       mov       r11,7FFC1FC90E68
       call      qword ptr [r11]
M07_L25:
       xor       ecx,ecx
       mov       [rdi+20],rcx
M07_L26:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M07_L28
M07_L27:
       mov       r11,7FFC1FC90E60
       call      qword ptr [r11]
M07_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 675
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
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
       je        near ptr M09_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L02
       test      rbx,rbx
       je        short M09_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M09_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       call      qword ptr [7FFC2000EF10]
       int       3
M09_L02:
       test      rbx,rbx
       je        short M09_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M09_L04
M09_L03:
       mov       rax,2EC8C430008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
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
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M10_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M10_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M10_L01
M10_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M10_L01
       call      qword ptr [7FFC202BDC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202BD4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202BDEA8]
M10_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M10_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M10_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
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
       je        short M11_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M11_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M11_L04
       jmp       short M11_L01
M11_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M11_L04
M11_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M11_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M11_L04
       jmp       short M11_L03
M11_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M11_L04
M11_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       movaps    [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FFC967E6430]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFC967E5600]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M12_L01
       mov       rcx,rbx
       call      qword ptr [7FFC967E70A0]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       esi,eax
       test      esi,esi
       je        short M12_L00
       mov       rcx,rbx
       call      qword ptr [7FFC967E6A40]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFC967E55F0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFC967E70A8]
       mov       rcx,rdi
       mov       r11,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [rax]
       mov       rax,rsi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L00:
       mov       rcx,rbx
       call      qword ptr [7FFC967E6B28]
       mov       rcx,rax
       call      qword ptr [7FFC967E7C58]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rcx,rbx
       call      qword ptr [7FFC967E6428]
       mov       rbx,rax
       mov       rdx,rbx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC967E8258]
       mov       rdx,rbx
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFC967E82A0]
       mov       rdx,rbx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC967E82E0]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 246
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count_Default()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFC2025C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
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
       mov       rax,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
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
       mov       r11,7FFC1FC80CD8
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
       call      qword ptr [7FFC1FFFEFB8]
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
       mov       rcx,7FFC1FD05120
       mov       edx,65
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FEE7401F90
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFC1FC80CE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFC1FC80CD0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.CountAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC20676EF8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<CountAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC20676B38]
       jmp       short M00_L00
; Total bytes of code 79
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC20676A30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<CountAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountAsync>d__11 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFC1FDCD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFC20676D18]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<CountAsync>d__11.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFC206770C0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFC206770C0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC1FFF4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFC1FFF42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFC20676A48]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC1FFF4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.DoesNotHaveItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,20D497444D0
       mov       [rax+8],rcx
       mov       rcx,rax
       call      qword ptr [7FFC2026C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        near ptr M01_L06
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L08
       mov       rsi,rcx
       cmp       dword ptr [rsi+10],0
       jne       near ptr M01_L07
       mov       rax,1CCBB801F78
       mov       rdi,[rax]
M01_L00:
       test      rdi,rdi
       je        short M01_L03
       mov       rax,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rax,rcx
       jne       short M01_L03
M01_L01:
       mov       rdx,rdi
       mov       r8d,[rdx+8]
       inc       r8d
       mov       eax,[rdx+0C]
       cmp       r8d,eax
       jb        near ptr M01_L10
       mov       [rdi+8],eax
M01_L02:
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rax,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rax,rcx
       jne       short M01_L04
       mov       rdx,rdi
       mov       r8d,[rdx+8]
       inc       r8d
       mov       eax,[rdx+0C]
       cmp       r8d,eax
       jb        near ptr M01_L12
       mov       [rdi+8],eax
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       r11,7FFC1FC90CE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       jmp       short M01_L02
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rdx,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FFC1FE8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M01_L00
M01_L08:
       mov       r11,7FFC1FC90CE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L09:
       add       ebx,1
       jo        short M01_L05
       jmp       near ptr M01_L01
M01_L10:
       mov       [rdi+8],r8d
       jmp       short M01_L09
M01_L11:
       add       ebx,1
       jo        short M01_L05
       jmp       near ptr M01_L03
M01_L12:
       mov       [rdi+8],r8d
       jmp       short M01_L11
; Total bytes of code 292
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.EnsureUnique()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean ByRef)
       call      qword ptr [7FFC2011E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L01
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrependIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+30],1
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+DistinctIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r8,[rdi+20]
       mov       rdx,[rdi+18]
       mov       rcx,rsi
       call      qword ptr [7FFC20086B80]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.HashSetToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC20686BE0]; System.Linq.Enumerable.HashSetToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
M00_L01:
       mov       rbp,rsi
       jmp       near ptr M00_L00
M00_L02:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,28C159CB6E8
       mov       rdx,28C159C0210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,28C159C0008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202BDC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFC202BDB78]
       mov       rcx,28C159CB6E8
       mov       rdx,28C159C0210
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,28C159C0008
       call      qword ptr [7FFC1FDD6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202BDC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202BD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202BD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202BDE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20036670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202BD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 911
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L16
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFC207605D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L17
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFC207607C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L04
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFC20760AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L14
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L06
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFC20760B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFC207608F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90D98
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L13
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L11
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFC20760A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L15
M01_L13:
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L14:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L15:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L16:
       mov       ecx,10
       call      qword ptr [7FFC20034F30]
       int       3
M01_L17:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L18
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFC20760B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L19:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC90DA0
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 614
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M02_L03
       cmp       [rax],rcx
       je        short M02_L03
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M02_L00:
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L01
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       jne       short M02_L04
M02_L01:
       xor       eax,eax
M02_L02:
       ret
M02_L03:
       ret
M02_L04:
       mov       rdx,[rdx+10]
       jmp       short M02_L00
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       test      r8,r8
       jne       short M03_L02
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFC2082D120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L01:
       mov       rcx,rdx
       call      qword ptr [7FFC1FDDFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r8,rax
M03_L02:
       lea       rcx,[rbx+18]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       jne       near ptr M03_L08
       mov       rcx,[rbx+18]
       mov       rdx,24B87C01D50
       cmp       rcx,[rdx]
       jne       short M03_L03
       mov       rcx,24B87C01950
       mov       rbp,[rcx]
       jmp       short M03_L05
M03_L03:
       mov       rdx,24B87C002D8
       cmp       rcx,[rdx]
       jne       short M03_L04
       mov       rcx,24B87C01958
       mov       rbp,[rcx]
       jmp       short M03_L05
M03_L04:
       mov       rdx,24B87C002E0
       xor       ebp,ebp
       mov       rax,24B87C01960
       cmp       rcx,[rdx]
       cmove     rbp,[rax]
M03_L05:
       test      rbp,rbp
       je        short M03_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rdi
       mov       rdx,7FFC2082BD40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L07:
       mov       rdx,rbp
       call      qword ptr [7FFC1FDD4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       test      rsi,rsi
       je        near ptr M03_L16
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rdi
       mov       rdx,7FFC2082D050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M03_L17
M03_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rdi
       mov       rdx,7FFC2082D060
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L13:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L20
M03_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC2006B230]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rbx+28]
       test      ecx,ecx
       jle       short M03_L15
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M03_L23
M03_L15:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L16:
       mov       ecx,17
       call      qword ptr [7FFC2000ECD0]
       int       3
M03_L17:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rdi
       mov       rdx,7FFC2082D050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L19:
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFC20086FE8]
       test      eax,eax
       je        near ptr M03_L11
       mov       rcx,rbx
       mov       rdx,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFC20086BC8]
M03_L20:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L21
       jmp       short M03_L22
M03_L21:
       mov       rcx,rdi
       mov       rdx,7FFC2082D070
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L22:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M03_L14
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FFC20086F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M03_L14
M03_L23:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFC20086EF8]
; Total bytes of code 650
```
```assembly
; System.Linq.Enumerable.HashSetToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFC2082FEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M04_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FFC1FE8DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rdx,[rbp-30]
       mov       rcx,rbx
       call      qword ptr [7FFC20086CA0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M04_L02
       mov       rbx,[rdx+30]
       test      rbx,rbx
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rdx,7FFC208500D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M04_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FFC203ACC30]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M04_L07
M04_L04:
       mov       r8,[rbp-28]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M04_L05
       lea       eax,[rdx+1]
       mov       [rsi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,r8
       call      qword ptr [7FFC1FE8E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M04_L06:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FFC203ACC30]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M04_L04
M04_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+8],38
       jle       short M04_L08
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rdx,7FFC208500F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M04_L09:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+8],38
       jle       short M04_L10
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rdx,7FFC208500F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M04_L11:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 374
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
       je        near ptr M05_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M05_L02
       test      rbx,rbx
       je        short M05_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M05_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L01:
       call      qword ptr [7FFC2000EF10]
       int       3
M05_L02:
       test      rbx,rbx
       je        short M05_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M05_L04
M05_L03:
       mov       rax,28C159C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
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
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M06_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDD6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M06_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M06_L01
M06_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M06_L01
       call      qword ptr [7FFC202BDC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202BD4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202BDEA8]
M06_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M06_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M06_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDD7318]; System.String.Trim()
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
       je        short M07_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M07_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L01
M07_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M07_L04
M07_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M07_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L03
M07_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M07_L04
M07_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FFC2026C4C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cdqe
       mov       rcx,[rbx+18]
       mov       [rcx+18],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFC202AD2D8]
       mov       rcx,2F7A444B6E8
       mov       rdx,2F7A4440210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2F7A4440008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202AD3F8]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC20130C58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC20130C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202ACC00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202ACFF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202AD578]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202ACFF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 335
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
       mov       rax,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
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
       mov       r11,7FFC1FC80CD0
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
       call      qword ptr [7FFC1FFFEFB8]
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
       mov       rcx,7FFC1FD05120
       mov       edx,65
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B712401F90
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFC1FC80CD8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFC1FC80CC8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FFFEF10]
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
       mov       rax,2F7A4440008
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
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M03_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M03_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M03_L01
M03_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M03_L01
       call      qword ptr [7FFC202AD3F8]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202ACC48]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202AD608]
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
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
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
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFC7F765308]
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
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+188]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull>b__20_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rsi+18],rcx
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFC20676B08]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       vmovups   xmm0,[rsp+30]
       vmovups   [rsp+20],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC206779A8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Nullable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull>b__20_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       eax,[rdx]
       mov       ecx,[rcx+6C]
       cmp       eax,ecx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 14
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rbp,rcx
       mov       r14,rdx
       mov       rbx,r8
       test      r14,r14
       je        near ptr M02_L19
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L21
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate[]
       cmp       [rax],rdx
       jne       near ptr M02_L20
       mov       edx,[rax+8]
       test      edx,edx
       jl        near ptr M02_L18
       mov       r15d,edx
M02_L00:
       test      r15d,r15d
       setg      r15b
       movzx     r15d,r15b
M02_L01:
       movzx     edx,r15b
       test      edx,edx
       je        near ptr M02_L24
       test      r14,r14
       je        near ptr M02_L25
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L27
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate[]
       cmp       [rax],rdx
       jne       near ptr M02_L26
       mov       edx,[rax+8]
       test      edx,edx
       jl        near ptr M02_L18
       mov       r13d,edx
M02_L02:
       test      r13d,r13d
       setg      r13b
       movzx     r13d,r13b
M02_L03:
       movzx     edx,r13b
       test      edx,edx
       je        near ptr M02_L30
       test      r14,r14
       je        near ptr M02_L31
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L32
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFC204F7768]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]..ctor(System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
M02_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r12,r12
       je        near ptr M02_L33
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M02_L34
       xor       r12d,r12d
       jmp       near ptr M02_L09
M02_L05:
       mov       rcx,[r14+8]
       mov       rdx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       jne       near ptr M02_L38
       cmp       r12d,[rcx+10]
       jae       near ptr M02_L41
       mov       rdx,[rcx+8]
       cmp       r12d,[rdx+8]
       jae       near ptr M02_L42
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       mov       rax,[rdx+rcx*4+10]
       mov       [rsp+78],rax
       mov       eax,[rdx+rcx*4+18]
       mov       [rsp+80],eax
M02_L06:
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull>b__20_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       cmp       [rbx+18],rdx
       jne       short M02_L07
       mov       rdx,[rbx+8]
       mov       ecx,[rsp+78]
       mov       edx,[rdx+6C]
       cmp       ecx,edx
       jne       short M02_L08
       jmp       near ptr M02_L16
M02_L07:
       mov       rdx,[rsp+78]
       mov       [rsp+30],rdx
       mov       edx,[rsp+80]
       mov       [rsp+38],edx
       lea       rdx,[rsp+30]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M02_L16
M02_L08:
       add       r12d,1
       jo        near ptr M02_L18
M02_L09:
       xor       r15d,r15d
       mov       rcx,[r14+8]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M02_L40
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L39
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       eax,[rsi+14]
       mov       [rsp+44],eax
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       [rsp+60],ecx
       mov       [rsp+48],rsi
       lea       rdi,[r13+8]
       lea       rsi,[rsp+48]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       movsq
       xor       ecx,ecx
       mov       [r13+10],ecx
       mov       ecx,[rsp+44]
       mov       [r13+14],ecx
M02_L10:
       jmp       short M02_L12
M02_L11:
       add       r15d,1
       jo        near ptr M02_L18
M02_L12:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       cmp       [r13],rcx
       jne       short M02_L13
       lea       rcx,[r13+8]
       mov       r11,[rcx]
       mov       eax,[rcx+0C]
       cmp       eax,[r11+14]
       jne       near ptr M02_L17
       mov       eax,[rcx+8]
       cmp       eax,[r11+10]
       jae       short M02_L14
       mov       r11,[r11+8]
       cmp       eax,[r11+8]
       jae       near ptr M02_L42
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*4+10]
       mov       [rcx+10],rdx
       mov       edx,[r11+rax*4+18]
       mov       [rcx+18],edx
       inc       dword ptr [rcx+8]
       jmp       short M02_L11
M02_L13:
       mov       rcx,r13
       mov       r11,7FFC1FC80E48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       mov       r11,[rcx]
       mov       r11d,[r11+10]
       inc       r11d
       mov       [rcx+8],r11d
       xor       r11d,r11d
       mov       [rcx+10],r11
       mov       [rcx+18],r11d
M02_L15:
       mov       edx,r15d
       movsxd    rcx,r12d
       movsxd    rdx,edx
       cmp       rcx,rdx
       jl        near ptr M02_L05
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp],xmm0
       mov       rax,rbp
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+68],xmm0
       mov       rax,[rsp+78]
       mov       [rsp+6C],rax
       mov       eax,[rsp+80]
       mov       [rsp+74],eax
       mov       byte ptr [rsp+68],1
       vmovups   xmm0,[rsp+68]
       vmovups   [rbp],xmm0
       mov       rax,rbp
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L17:
       call      qword ptr [7FFC1FFFEFB8]
       int       3
M02_L18:
       call      CORINFO_HELP_OVERFLOW
M02_L19:
       xor       r15d,r15d
       jmp       near ptr M02_L01
M02_L20:
       mov       rcx,rax
       mov       r11,7FFC1FC80E10
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M02_L00
M02_L21:
       xor       r12d,r12d
       mov       rcx,r14
       mov       r11,7FFC1FC80E00
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M02_L23
M02_L22:
       add       r12d,1
       jo        short M02_L18
M02_L23:
       mov       rcx,rsi
       mov       r11,7FFC1FC80E08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L22
       mov       r15d,r12d
       jmp       near ptr M02_L00
M02_L24:
       call      qword ptr [7FFC202AD8F0]
       mov       rbx,rax
       mov       rcx,260ADCEB6E8
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       xor       r13d,r13d
       jmp       near ptr M02_L03
M02_L26:
       mov       rcx,rax
       mov       r11,7FFC1FC80E28
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M02_L02
M02_L27:
       xor       esi,esi
       mov       rcx,r14
       mov       r11,7FFC1FC80E18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M02_L29
M02_L28:
       add       esi,1
       jo        near ptr M02_L18
M02_L29:
       mov       rcx,rdi
       mov       r11,7FFC1FC80E20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L28
       mov       r13d,esi
       jmp       near ptr M02_L02
M02_L30:
       call      qword ptr [7FFC202AD8F0]
       mov       rbx,rax
       mov       rcx,260ADCEB6E8
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L31:
       mov       ecx,10
       call      qword ptr [7FFC20024F30]
       int       3
M02_L32:
       mov       rcx,rax
       mov       r11,7FFC1FC80E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M02_L04
M02_L33:
       mov       ecx,14
       call      qword ptr [7FFC1FFFECD0]
       int       3
M02_L34:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,260ADCEC990
       mov       rdx,260ADCE0210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,260ADCE0008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L35
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L36
M02_L35:
       mov       ecx,1
M02_L36:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L37
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L37:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L38:
       lea       rdx,[rsp+78]
       mov       r8d,r12d
       mov       r11,7FFC1FC80E38
       call      qword ptr [r11]
       jmp       near ptr M02_L06
M02_L39:
       mov       rcx,7FFC1FD05120
       mov       edx,60
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2201BC01F78
       mov       r13,[rcx]
       jmp       near ptr M02_L10
M02_L40:
       mov       rcx,rsi
       mov       r11,7FFC1FC80E50
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M02_L10
M02_L41:
       call      qword ptr [7FFC1FFFEA30]
       int       3
M02_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1728
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Nullable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasDuplicates()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.HasDuplicates[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC20686970]; DotNetTips.Spargine.Extensions.EnumerableExtensions.HasDuplicates[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.HasDuplicates[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-44],eax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L06
       xor       edi,edi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       near ptr M01_L26
       mov       rcx,rsi
       cmp       dword ptr [rcx+10],0
       je        near ptr M01_L25
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],ecx
       mov       [r14+1C],r15d
M01_L00:
       mov       r15,[r14]
       jmp       short M01_L02
M01_L01:
       add       edi,1
       jo        near ptr M01_L24
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r15,rcx
       jne       short M01_L05
       lea       r13,[r14+8]
       mov       r12,[r13]
       mov       rcx,r12
       mov       [rbp-58],rcx
       mov       edx,[r13+14]
       cmp       edx,[rcx+14]
       jne       near ptr M01_L27
       mov       edx,[r13+10]
       cmp       edx,[rcx+10]
       jae       short M01_L03
       lea       rcx,[r13+8]
       mov       rax,[rbp-58]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L30
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r13+10]
       jmp       short M01_L01
M01_L03:
       mov       ecx,[r12+10]
       inc       ecx
       mov       [r13+10],ecx
       xor       ecx,ecx
       mov       [r13+8],rcx
M01_L04:
       mov       eax,edi
       test      eax,eax
       jg        short M01_L06
       xor       eax,eax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,r14
       mov       r11,7FFC1FC90D20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L04
M01_L06:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L19
M01_L07:
       call      qword ptr [7FFC206870F0]; System.Collections.Immutable.ImmutableHashSet.CreateBuilder[[System.__Canon, System.Private.CoreLib]]()
       mov       rdi,rax
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M01_L20
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       mov       r14,[rax]
       jmp       short M01_L11
M01_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M01_L15
M01_L10:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC20695188]; System.Collections.Immutable.ImmutableHashSet`1+Builder[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       test      eax,eax
       mov       rax,[rbp-50]
       je        near ptr M01_L17
M01_L11:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       near ptr M01_L16
       lea       rsi,[rax+8]
       mov       r15,[rsi]
       mov       rcx,r15
       mov       [rbp-60],rcx
       mov       edx,[rsi+14]
       cmp       edx,[rcx+14]
       jne       short M01_L13
       mov       edx,[rsi+10]
       cmp       edx,[rcx+10]
       jae       short M01_L14
       lea       rcx,[rsi+8]
       mov       r8,[rbp-60]
       mov       r8,[r8+8]
       cmp       edx,[r8+8]
       jae       short M01_L12
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rsi+10]
       jmp       near ptr M01_L09
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rax,[rbp-50]
       mov       ecx,[rsi+14]
       cmp       ecx,[r15+14]
       jne       short M01_L18
M01_L14:
       mov       rax,[rbp-50]
       mov       ecx,[r15+10]
       inc       ecx
       mov       [rsi+10],ecx
       xor       ecx,ecx
       mov       [rsi+8],rcx
       jmp       near ptr M01_L21
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFC206AAC60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L16:
       mov       rcx,rax
       mov       r11,7FFC1FC90D08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L09
       mov       rax,[rbp-50]
       jmp       short M01_L21
M01_L17:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M01_L29
M01_L18:
       call      qword ptr [7FFC2000EFB8]
       int       3
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFC206AAB68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L20:
       mov       rcx,rbx
       mov       rdx,7FFC206AAB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L21:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       jne       short M01_L28
M01_L22:
       xor       eax,eax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       eax,[rbp-44]
       add       rsp,58
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
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       rcx,7FFC1FD15120
       mov       edx,66
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FE2F401FB8
       mov       r14,[rcx]
       jmp       near ptr M01_L00
M01_L26:
       mov       rcx,rsi
       mov       r11,7FFC1FC90D18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M01_L00
M01_L27:
       call      qword ptr [7FFC2000EFB8]
       int       3
M01_L28:
       mov       rcx,rax
       mov       r11,7FFC1FC90D10
       call      qword ptr [r11]
       jmp       near ptr M01_L22
M01_L29:
       mov       rcx,rsp
       call      M01_L31
       jmp       short M01_L23
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L31:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-50],0
       je        short M01_L32
       mov       rax,[rbp-50]
       mov       r14,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       r14,rcx
       je        short M01_L32
       mov       rcx,[rbp-50]
       mov       r11,7FFC1FC90D10
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 932
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFC2024C7F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       test      rcx,rcx
       je        near ptr M01_L08
       xor       ebx,ebx
       mov       rax,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
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
       mov       r11,7FFC1FC70CF8
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
       call      qword ptr [7FFC1FFEEFB8]
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
       mov       rcx,7FFC1FCF5120
       mov       edx,65
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27647801F90
       mov       rdi,[rcx]
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFC1FC70D00
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L11:
       mov       r11,7FFC1FC70CF0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.IndexOf()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+190]
       lea       r8,[rsp+30]
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean ByRef)
       call      qword ptr [7FFC20675968]; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
       cmp       byte ptr [rsp+30],0
       je        near ptr M00_L06
       test      rsi,rsi
       je        short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FFC204BC0D8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       test      eax,eax
       setg      bpl
M00_L00:
       movzx     r9d,bpl
       test      r9d,r9d
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       test      r8,r8
       setne     r9b
       test      r9d,r9d
       je        short M00_L02
       mov       r9,202A5801F78
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Collections.Generic.IEqualityComparer`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFC20675AD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       ebp,ebp
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,2433378B588
       mov       rdx,24333780210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24333780008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFC20024F90]
       int       3
M00_L07:
       call      qword ptr [7FFC202AD8F0]
       mov       rbx,rax
       mov       rcx,2433378B6E8
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 553
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L17
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L00
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFC207EE518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L18
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFC207EE708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L04
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFC207EEA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L15
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L06
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFC207EEA48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       lea       edx,[rsi-1]
       mov       rcx,rdi
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L09
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFC207EE838
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC80EA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
M01_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FFC207EE850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC80EA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       [rbp-30],rsi
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L16
M01_L14:
       mov       rcx,rsp
       call      M01_L21
       nop
M01_L15:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L17:
       mov       ecx,10
       call      qword ptr [7FFC20024F30]
       int       3
M01_L18:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L19
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFC207EEA60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L21:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L22
       mov       rcx,[rbp-28]
       mov       r11,7FFC1FC80EB0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFC1FDC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFC1FC80E90
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFC1FC80E88
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFC1FC80E78
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L03
M02_L02:
       add       esi,1
       jo        short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC80E80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M03_L13
M03_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L16
M03_L01:
       mov       rdx,rsi
       mov       r8,24333780008
       mov       r9,2433378B6E8
       call      qword ptr [7FFC204BCFC0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rdx,[r14+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        near ptr M03_L35
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M03_L39
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M03_L17
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M03_L17
M03_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass23_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rdi+18],rcx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M03_L19
       mov       rbp,[rcx+38]
       test      rbp,rbp
       je        near ptr M03_L19
M03_L03:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M03_L21
       mov       r14,[rcx+40]
       test      r14,r14
       je        near ptr M03_L21
M03_L04:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC20675C80]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rsi,rax
       mov       rcx,r14
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M03_L43
M03_L05:
       test      rsi,rsi
       je        near ptr M03_L48
       test      rdx,rdx
       je        near ptr M03_L49
       mov       rcx,rsi
       call      qword ptr [7FFC206760E8]; System.Linq.Enumerable.Where[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L48
       xor       ebp,ebp
       mov       r14,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Int32, System.Private.CoreLib]]
       cmp       [rdi],r14
       jne       near ptr M03_L53
       mov       rax,rdi
       cmp       dword ptr [rax+0C],0
       jne       short M03_L06
       mov       ebx,[rdi+8]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M03_L23
M03_L06:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       r15,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+8],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L07:
       mov       dword ptr [rbx+0C],1
M03_L08:
       cmp       [rbx],r14
       jne       near ptr M03_L24
       mov       rax,rbx
       mov       eax,[rax+0C]
       cmp       eax,1
       je        near ptr M03_L27
       cmp       eax,2
       jne       near ptr M03_L25
M03_L09:
       mov       rcx,[rbx+28]
       mov       r11,7FFC1FC80ED0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M03_L18
M03_L10:
       mov       rcx,[rbx+28]
       mov       rdx,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       cmp       [rcx],rdx
       jne       near ptr M03_L32
       mov       esi,[rcx+34]
       mov       r15,[rbx+20]
       mov       rdx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__23`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__23_1(Int32)
       cmp       [r15+18],rdx
       jne       short M03_L14
       cmp       esi,0FFFFFFFF
       je        short M03_L15
M03_L11:
       mov       [rbx+10],esi
M03_L12:
       add       ebp,1
       jo        near ptr M03_L34
       jmp       short M03_L08
M03_L13:
       mov       rcx,rbx
       mov       rdx,7FFC2065B698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M03_L00
M03_L14:
       mov       edx,esi
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       jne       short M03_L11
M03_L15:
       mov       rcx,[rbx+28]
       mov       r11,7FFC1FC80ED0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L18
M03_L16:
       mov       rcx,rbx
       mov       rdx,7FFC2065B6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L17:
       mov       rcx,rbx
       mov       rdx,7FFC2065B9C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L18:
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M03_L22
       jmp       short M03_L20
M03_L19:
       mov       rcx,rbx
       mov       rdx,7FFC2065BA70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
       jmp       near ptr M03_L03
M03_L20:
       mov       r11,7FFC1FC80EE0
       call      qword ptr [r11]
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M03_L22
M03_L21:
       mov       rcx,rbx
       mov       rdx,7FFC2065BDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
       jmp       near ptr M03_L04
M03_L22:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       dword ptr [rbx+0C],0FFFFFFFF
       jmp       short M03_L25
M03_L23:
       mov       rbx,rdi
       jmp       near ptr M03_L07
M03_L24:
       mov       rcx,rbx
       mov       r11,7FFC1FC80EC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L12
M03_L25:
       mov       ecx,ebp
       test      ecx,ecx
       jle       near ptr M03_L48
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+8],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],0FFFFFFFF
       lea       rdx,[rsp+28]
       mov       rcx,rbx
       call      qword ptr [7FFC20676988]; System.Linq.Enumerable.TryGetFirst[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        near ptr M03_L33
M03_L26:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L27:
       mov       rcx,[rbx+18]
       mov       rsi,rcx
       mov       rax,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       cmp       [rsi],rax
       jne       short M03_L31
       cmp       dword ptr [rsi+30],0FFFFFFFE
       jne       short M03_L30
       mov       r15d,[rsi+38]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       short M03_L30
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       r15,rsi
M03_L28:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
M03_L29:
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+0C],2
       jmp       near ptr M03_L09
M03_L30:
       mov       rcx,offset MT_System.Linq.Enumerable+<SelectIterator>d__229`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       eax,eax
       mov       [r15+30],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+38],eax
       jmp       short M03_L28
M03_L31:
       mov       rcx,rsi
       mov       r11,7FFC1FC80EC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M03_L29
M03_L32:
       mov       r11,7FFC1FC80ED8
       call      qword ptr [r11]
       mov       esi,eax
       mov       r15,[rbx+20]
       jmp       near ptr M03_L14
M03_L33:
       call      qword ptr [7FFC20024F90]
       int       3
M03_L34:
       call      CORINFO_HELP_OVERFLOW
M03_L35:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,2433378B588
       mov       rdx,24333780210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24333780008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M03_L36
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M03_L37
M03_L36:
       mov       ecx,1
M03_L37:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M03_L38
       call      qword ptr [7FFC202ADC98]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFC20026670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L38:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFC20026670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L39:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,24333795660
       mov       rdx,24333780210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24333780008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M03_L40
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M03_L41
M03_L40:
       mov       ecx,1
M03_L41:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M03_L42
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L42:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L43:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L44
       mov       rdi,[rcx+40]
       test      rdi,rdi
       je        short M03_L44
       jmp       short M03_L45
M03_L44:
       mov       rcx,rbx
       mov       rdx,7FFC2065BDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__23`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__23_1(Int32)
       call      qword ptr [7FFC1FDC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L46
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M03_L46
       jmp       short M03_L47
M03_L46:
       mov       rcx,rbx
       mov       rdx,7FFC2065BDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L47:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       jmp       near ptr M03_L05
M03_L48:
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L26
M03_L49:
       call      qword ptr [7FFC202ADB78]
       mov       rcx,243337956B0
       mov       rdx,24333780210
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24333780008
       call      qword ptr [7FFC1FDC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M03_L50
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M03_L51
M03_L50:
       mov       ecx,1
M03_L51:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M03_L52
       call      qword ptr [7FFC202ADC98]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFC201308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFC202AD4A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC202AD890]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC202ADE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC20026670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L52:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC202AD890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC20026670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L53:
       mov       rcx,rdi
       mov       r11,7FFC1FC80EB8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L08
; Total bytes of code 2195
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFC1FFFEF10]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,24333780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M05_L00
       mov       rcx,[rbp+20]
       call      qword ptr [7FFC1FDC6670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       jmp       short M05_L01
M05_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M05_L01
       call      qword ptr [7FFC202ADC98]
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFC202AD4E8]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC202ADEA8]
M05_L01:
       mov       eax,[rbp+18]
       movzx     eax,al
       test      eax,eax
       jne       short M05_L02
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
M05_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FDC7318]; System.String.Trim()
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
       je        short M06_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L00
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,[7FFC7F77E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFC7F765308]
       test      eax,eax
       jne       short M06_L04
M06_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC7F761470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.IsNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,303899244F0
       mov       [rax+8],rcx
       mov       rcx,rax
       call      qword ptr [7FFC1FF11C58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M00_L01
       mov       rcx,rax
       call      qword ptr [7FFC200FB0C8]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L00:
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       r11,[rbx+18]
       mov       [r11+4C],cl
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rcx,rax
       mov       r11,7FFC1FC60CD8
       call      qword ptr [r11]
       jmp       short M00_L00
; Total bytes of code 109
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       cmp       dword ptr [rbx+10],0
       jne       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFC207FBA00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFC207FBA10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 156
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       edx,[rcx+8]
       inc       edx
       mov       eax,[rcx+0C]
       cmp       edx,eax
       jb        short M02_L00
       mov       [rcx+8],eax
       xor       eax,eax
       ret
M02_L00:
       mov       [rcx+8],edx
       mov       eax,1
       ret
; Total bytes of code 27
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Join()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rdx,20A1A3E90D8
       call      qword ptr [7FFC2024C9A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Join(System.Collections.Generic.IEnumerable`1<System.Object>, System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Join(System.Collections.Generic.IEnumerable`1<System.Object>, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L24
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFC1FDB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L26
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L25
       mov       rcx,[rax+8]
       mov       r11,7FFC1FC710E0
       call      qword ptr [r11]
M01_L00:
       xor       edi,edi
       test      eax,eax
       setg      dil
M01_L01:
       movzx     ecx,dil
       test      ecx,ecx
       je        near ptr M01_L29
       test      rsi,rsi
       je        near ptr M01_L30
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        near ptr M01_L30
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M01_L31
M01_L02:
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFC7ED02BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L06
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFC207AC0F0]
       test      eax,eax
       jne       short M01_L06
M01_L04:
       lea       edi,[rbp-1]
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFC7ED02BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L06
       jmp       near ptr M01_L31
M01_L05:
       call      qword ptr [7FFC207AC0F0]
       test      eax,eax
       je        near ptr M01_L31
M01_L06:
       xor       r14d,r14d
       test      ebp,ebp
       jle       short M01_L10
M01_L07:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       mov       rax,7FFC7ED02BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFC207AC0F0]
       test      eax,eax
       je        short M01_L10
M01_L09:
       inc       r14d
       cmp       ebp,r14d
       jg        short M01_L07
M01_L10:
       lea       edi,[rbp-1]
       cmp       edi,r14d
       jl        short M01_L17
       mov       ecx,edi
       or        ecx,r14d
       jl        short M01_L14
       cmp       ebp,edi
       jle       short M01_L14
M01_L11:
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFC7ED02BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L17
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFC207AC0F0]
       test      eax,eax
       je        short M01_L17
M01_L13:
       dec       edi
       cmp       edi,r14d
       jge       short M01_L11
       jmp       short M01_L17
M01_L14:
       cmp       edi,ebp
       jae       near ptr M01_L32
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFC7ED02BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L17
       jmp       short M01_L16
M01_L15:
       call      qword ptr [7FFC207AC0F0]
       test      eax,eax
       je        short M01_L17
M01_L16:
       dec       edi
       cmp       edi,r14d
       jge       short M01_L14
M01_L17:
       sub       edi,r14d
       inc       edi
       cmp       ebp,edi
       jne       short M01_L19
       mov       rbp,rsi
M01_L18:
       test      rbp,rbp
       jne       short M01_L20
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L21
M01_L19:
       test      edi,edi
       je        short M01_L22
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,edi
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,r14d
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L18
M01_L20:
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
M01_L21:
       mov       [rsp+20],rdx
       mov       [rsp+28],r8d
       lea       rdx,[rsp+20]
       mov       r8,rbx
       mov       rcx,offset MD_System.String.JoinCore[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.Object>)
       call      qword ptr [7FFC206669E8]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       mov       rbp,20A1A3E0008
       jmp       short M01_L18
M01_L23:
       call      CORINFO_HELP_OVERFLOW
M01_L24:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L25:
       mov       rcx,rax
       mov       r11,7FFC1FC710D8
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L26:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFC1FC710C8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M01_L28
M01_L27:
       add       edi,1
       jo        short M01_L23
M01_L28:
       mov       rcx,rbp
       mov       r11,7FFC1FC710D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L27
       mov       eax,edi
       jmp       near ptr M01_L00
M01_L29:
       mov       rax,20A1A3E0008
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L30:
       mov       rsi,20A1A3E90D8
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       near ptr M01_L02
M01_L31:
       mov       rbp,rsi
       jmp       near ptr M01_L18
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 706
```

