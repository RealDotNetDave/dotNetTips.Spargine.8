## DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark-20240229-202539
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,225B54CB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,225B54C0008
+       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,225B54CB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,225B54C0008
+       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,225B54C0008
+       mov       r9,225B54CB718
+       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FFE38508900
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE388BBA80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,2D75CDAB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2D75CDA0008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,2D75CDAB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2D75CDA0008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2D75CDA0008
+       mov       r9,2D75CDAB718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FFE38518900
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE388CBA80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,220E4ACB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,220E4ACB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,220E4AC0008
+       mov       r9,220E4ACB718
+       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE3898A3B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,24A2A08B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,24A2A08B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,24A2A080008
+       mov       r9,24A2A08B718
+       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE389D8DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,29015F9B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,29015F9B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29015F90008
+       mov       r9,29015F9B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE389E99C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38535BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE38904840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384ED6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38581310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3853C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385818E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2B8E2E6B6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385819C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2B8E2E6B6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2B8E2E60008
-       call      qword ptr [7FFE3853CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2B8E2E60008
-       mov       r9,2B8E2E6B718
-       call      qword ptr [7FFE3853CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384BD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38538900
-       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3849F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38581DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F10368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F10358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388EBA80
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38551310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385518E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,2D75CDAB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2D75CDA0008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385519C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,2D75CDAB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2D75CDA0008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2D75CDA0008
+       mov       r9,2D75CDAB718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
-       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FFE38518900
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE388CBA80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38551310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385518E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,220E4ACB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385519C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,220E4ACB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,220E4AC0008
+       mov       r9,220E4ACB718
+       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
-       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE3898A3B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38551310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385518E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,24A2A08B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385519C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,24A2A08B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,24A2A080008
+       mov       r9,24A2A08B718
+       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
-       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE389D8DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38551310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385518E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,29015F9B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385519C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,29015F9B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29015F90008
+       mov       r9,29015F9B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
-       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE389E99C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38551310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385518E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385519C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
-       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38551DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EE0368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EE0358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38505BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388D4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3850C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,225B54CB6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,225B54CB6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,225B54C0008
-       call      qword ptr [7FFE3850CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,225B54C0008
-       mov       r9,225B54CB718
-       call      qword ptr [7FFE3850CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3848D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38508900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3846F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388BBA80
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38561310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385618E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2D75CDAB6C8
+       mov       rcx,220E4ACB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385619C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2D75CDAB6E8
+       mov       rdx,220E4ACB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,220E4AC0008
+       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2D75CDA0008
-       mov       r9,2D75CDAB718
-       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,220E4AC0008
+       mov       r9,220E4ACB718
+       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38518900
-       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388CBA80
+       mov       rdx,7FFE3898A3B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38561310
+       mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385618E0
+       mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2D75CDAB6C8
+       mov       rcx,24A2A08B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385619C8
+       mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2D75CDAB6E8
+       mov       rdx,24A2A08B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561A80
+       mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2D75CDA0008
-       mov       r9,2D75CDAB718
-       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,24A2A080008
+       mov       r9,24A2A08B718
+       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0360
+       mov       r11,7FFE37F00360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561B58
+       mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561EE8
+       mov       rdx,7FFE38571EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38518900
-       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BA8
+       mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38571BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38571BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38571DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0350
+       mov       r11,7FFE37F00350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0368
+       mov       r11,7FFE37F00368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0358
+       mov       r11,7FFE37F00358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388CBA80
+       mov       rdx,7FFE389D8DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2D75CDAB6C8
+       mov       rcx,29015F9B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
+       mov       r9,29015F90008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2D75CDAB6E8
+       mov       rdx,29015F9B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
+       mov       r9,29015F90008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2D75CDA0008
-       mov       r9,2D75CDAB718
+       mov       r8,29015F90008
+       mov       r9,29015F9B718
        call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38518900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388CBA80
+       mov       rdx,7FFE389E99C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2D75CDAB6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
+       mov       r9,2531D740008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2D75CDAB6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
+       mov       r9,2531D740008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2D75CDA0008
-       mov       r9,2D75CDAB718
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
        call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38518900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388CBA80
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE388E4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38561310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385618E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2D75CDAB6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385619C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2D75CDAB6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2D75CDA0008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2D75CDA0008
-       mov       r9,2D75CDAB718
-       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FFE38518900
-       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE388CBA80
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4E28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38571310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385718E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,220E4ACB6C8
+       mov       rcx,24A2A08B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385719C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,220E4ACB6E8
+       mov       rdx,24A2A08B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,24A2A080008
+       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38571A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,220E4AC0008
-       mov       r9,220E4ACB718
-       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,24A2A080008
+       mov       r9,24A2A08B718
+       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38571B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38571BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE3898A3B0
+       mov       rdx,7FFE389D8DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,220E4ACB6C8
+       mov       rcx,29015F9B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,220E4ACB6E8
+       mov       rdx,29015F9B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,220E4AC0008
-       mov       r9,220E4ACB718
-       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29015F90008
+       mov       r9,29015F9B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE3898A3B0
+       mov       rdx,7FFE389E99C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,220E4ACB6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,220E4ACB6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,220E4AC0008
-       mov       r9,220E4ACB718
-       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE3898A3B0
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38525BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389AC0C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3852C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,220E4ACB6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,220E4ACB6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,220E4AC0008
-       call      qword ptr [7FFE3852CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,220E4AC0008
-       mov       r9,220E4ACB718
-       call      qword ptr [7FFE3852CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384AD200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE3898A3B0
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389AC558]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,24A2A08B6C8
+       mov       rcx,29015F9B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,24A2A08B6E8
+       mov       rdx,29015F9B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29015F90008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,24A2A080008
-       mov       r9,24A2A08B718
-       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29015F90008
+       mov       r9,29015F9B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389D8DB0
+       mov       rdx,7FFE389E99C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38561310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,24A2A08B6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,24A2A08B6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2531D740008
+       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,24A2A080008
-       mov       r9,24A2A08B718
-       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
+       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EF0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38561B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38561EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38561BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38561BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38561BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38561DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EF0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EF0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EF0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389D8DB0
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE385253F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389CFAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38571310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE38527D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385718E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,24A2A08B6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385719C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,24A2A08B6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,24A2A080008
-       call      qword ptr [7FFE3852C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,24A2A080008
-       mov       r9,24A2A08B718
-       call      qword ptr [7FFE3852C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE384ACA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3848EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38571DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37F00368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37F00358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389D8DB0
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rdx,7FFE385618E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29015F9B6C8
+       mov       rcx,2531D74B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29015F90008
+       mov       r9,2531D740008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFE385619C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29015F9B6E8
+       mov       rdx,2531D74B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29015F90008
+       mov       r9,2531D740008
        call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
        mov       rcx,[rbp+10]
        mov       rdx,7FFE38561A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29015F90008
-       mov       r9,29015F9B718
+       mov       r8,2531D740008
+       mov       r9,2531D74B718
        call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389E99C0
+       mov       rdx,7FFE389E80E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38561310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385618E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29015F9B6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29015F90008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385619C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29015F9B6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29015F90008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29015F90008
-       mov       r9,29015F9B718
-       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389E99C0
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+48]
        call      qword ptr [rax+18]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FFE38515BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FFE385053F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFE389F6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFE389E5EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 85
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        push      rbp
        sub       rsp,1E0
        lea       rbp,[rsp+1E0]
        xor       eax,eax
        mov       [rbp-158],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-150],xmm4
        vmovdqa   xmmword ptr [rbp-140],xmm4
        mov       rax,0FFFFFFFFFFFFFEE0
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-10],rax
        mov       [rbp-1B8],rsp
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
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
-       mov       rdx,7FFE38561310
+       mov       rdx,7FFE38551310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FFE3851C8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE38507D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp+18]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-60],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385618E0
+       mov       rdx,7FFE385518E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2531D74B6C8
+       mov       rcx,21A3E14B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2531D740008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+20],0
        je        short M01_L06
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+10]
        mov       rdx,[rdx+20]
        mov       [rbp-70],rdx
        jmp       short M01_L07
 M01_L06:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE385619C8
+       mov       rdx,7FFE385519C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2531D74B6E8
+       mov       rdx,21A3E14B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2531D740008
-       call      qword ptr [7FFE3851CDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,21A3E140008
+       call      qword ptr [7FFE3850C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-80],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+28],0
        je        short M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+28]
        mov       [rbp-88],rcx
        jmp       short M01_L09
 M01_L08:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561A80
+       mov       rdx,7FFE38551A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2531D740008
-       mov       r9,2531D74B718
-       call      qword ptr [7FFE3851CE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,21A3E140008
+       mov       r9,21A3E14B718
+       call      qword ptr [7FFE3850C528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
        mov       [rbp-90],rax
        mov       rcx,[rbp-78]
        lea       rcx,[rcx+8]
        mov       rdx,[rbp-90]
        call      CORINFO_HELP_ASSIGN_REF
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        sete      cl
        movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        near ptr M01_L18
        nop
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-170],rcx
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L10
        mov       rcx,[rbp-170]
        cmp       qword ptr [rcx+40],0
        je        short M01_L10
        mov       rcx,[rbp-170]
        mov       rcx,[rcx+40]
        mov       [rbp-128],rcx
        jmp       short M01_L11
 M01_L10:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-128],rax
 M01_L11:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-178],rcx
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L13
        mov       rcx,[rbp-178]
        cmp       qword ptr [rcx+48],0
        je        short M01_L13
        mov       rcx,[rbp-178]
        mov       rcx,[rcx+48]
        mov       [rbp-148],rcx
        jmp       short M01_L14
 M01_L13:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-148],rax
 M01_L14:
        mov       rcx,[rbp-148]
        mov       [rbp-150],rcx
        mov       rcx,[rbp-20]
        mov       r11,[rbp-150]
        mov       rax,[rbp-150]
        call      qword ptr [rax]
        mov       [rbp-158],rax
        mov       rcx,[rbp-158]
        mov       [rbp-28],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-180],rcx
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L15
        mov       rcx,[rbp-180]
        cmp       qword ptr [rcx+50],0
        je        short M01_L15
        mov       rcx,[rbp-180]
        mov       rcx,[rcx+50]
        mov       [rbp-160],rcx
        jmp       short M01_L16
 M01_L15:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-160],rax
 M01_L16:
        mov       rcx,[rbp-160]
        mov       [rbp-168],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-168]
        mov       rdx,[rbp-28]
        mov       rax,[rbp-168]
        call      qword ptr [rax]
        nop
        nop
 M01_L17:
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0360
+       mov       r11,7FFE37EE0360
        call      qword ptr [r11]
        mov       [rbp-13C],eax
        cmp       dword ptr [rbp-13C],0
        jne       near ptr M01_L12
        nop
        mov       rcx,rsp
        call      M01_L35
        nop
        mov       dword ptr [rbp-2C],1
        nop
        jmp       near ptr M01_L34
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-188],rcx
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L19
        mov       rcx,[rbp-188]
        cmp       qword ptr [rcx+30],0
        je        short M01_L19
        mov       rcx,[rbp-188]
        mov       rcx,[rcx+30]
        mov       [rbp-98],rcx
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561B58
+       mov       rdx,7FFE38551B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FFE3849D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3848CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-0A0],rax
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+10]
        mov       [rbp-0A8],rcx
        mov       rcx,[rbp-0A0]
        mov       [rbp-0B0],rcx
        mov       rcx,[rbp-0A8]
        mov       [rbp-0B8],rcx
        cmp       qword ptr [rbp-0A8],0
        jne       near ptr M01_L23
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-190],rcx
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+8],58
        jle       short M01_L21
        mov       rcx,[rbp-190]
        cmp       qword ptr [rcx+58],0
        je        short M01_L21
        mov       rcx,[rbp-190]
        mov       rcx,[rcx+58]
        mov       [rbp-120],rcx
        jmp       short M01_L22
 M01_L21:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561EE8
+       mov       rdx,7FFE38551EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-198],rcx
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+8],38
        jle       short M01_L24
        mov       rcx,[rbp-198]
        cmp       qword ptr [rcx+38],0
        je        short M01_L24
        mov       rcx,[rbp-198]
        mov       rcx,[rcx+38]
        mov       [rbp-0C0],rcx
        jmp       short M01_L25
 M01_L24:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BA8
+       mov       rdx,7FFE38551BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FFE3847F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3846EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-0C8],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A0],rcx
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+8],40
        jle       short M01_L26
        mov       rcx,[rbp-1A0]
        cmp       qword ptr [rcx+40],0
        je        short M01_L26
        mov       rcx,[rbp-1A0]
        mov       rcx,[rcx+40]
        mov       [rbp-0D0],rcx
        jmp       short M01_L27
 M01_L26:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BC8
+       mov       rdx,7FFE38551BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0D0],rax
 M01_L27:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1A8],rcx
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+8],48
        jle       short M01_L29
        mov       rcx,[rbp-1A8]
        cmp       qword ptr [rcx+48],0
        je        short M01_L29
        mov       rcx,[rbp-1A8]
        mov       rcx,[rcx+48]
        mov       [rbp-0F0],rcx
        jmp       short M01_L30
 M01_L29:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561BE0
+       mov       rdx,7FFE38551BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0F0],rax
 M01_L30:
        mov       rcx,[rbp-0F0]
        mov       [rbp-0F8],rcx
        mov       rcx,[rbp-38]
        mov       r11,[rbp-0F8]
        mov       rax,[rbp-0F8]
        call      qword ptr [rax]
        mov       [rbp-100],rax
        mov       rcx,[rbp-100]
        mov       [rbp-48],rcx
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       [rbp-1B0],rcx
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+8],50
        jle       short M01_L31
        mov       rcx,[rbp-1B0]
        cmp       qword ptr [rcx+50],0
        je        short M01_L31
        mov       rcx,[rbp-1B0]
        mov       rcx,[rcx+50]
        mov       [rbp-108],rcx
        jmp       short M01_L32
 M01_L31:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38561DC0
+       mov       rdx,7FFE38551DC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-108],rax
 M01_L32:
        mov       rcx,[rbp-108]
        mov       [rbp-110],rcx
        mov       rcx,[rbp-10]
        mov       rcx,[rcx+8]
        mov       r11,[rbp-110]
        mov       rdx,[rbp-48]
        mov       rax,[rbp-110]
        call      qword ptr [rax]
        nop
        mov       dword ptr [rbp-14],1
        nop
 M01_L33:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0350
+       mov       r11,7FFE37EE0350
        call      qword ptr [r11]
        mov       [rbp-0E4],eax
        cmp       dword ptr [rbp-0E4],0
        jne       near ptr M01_L28
        nop
        mov       rcx,rsp
        call      M01_L37
        nop
        mov       ecx,[rbp-14]
        mov       [rbp-2C],ecx
        nop
        mov       eax,[rbp-2C]
        add       rsp,1E0
        pop       rbp
        ret
 M01_L35:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-20],0
        je        short M01_L36
        mov       rcx,[rbp-20]
-       mov       r11,7FFE37EF0368
+       mov       r11,7FFE37EE0368
        call      qword ptr [r11]
        nop
 M01_L36:
        nop
        add       rsp,30
        pop       rbp
        ret
 M01_L37:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
-       mov       r11,7FFE37EF0358
+       mov       r11,7FFE37EE0358
        call      qword ptr [r11]
        nop
 M01_L38:
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 2167
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
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FFE389E80E0
+       mov       rdx,7FFE389C87E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFE389E6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37EF0A88
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3837F438],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37F00A88
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37EE0AB8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37EF0C10
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3837F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0A88
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37F00A88
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37EE0AB8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384CE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37EF0C10
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE3837F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0A88
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F438],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00A88
+       mov       r11,7FFE37EE0AB8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00A88
+       mov       r11,7FFE37EF0C10
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00A88
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38525B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00A88
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0AB8
+       mov       r11,7FFE37EF0C10
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3837F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0AB8
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0AB8
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38505B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38987FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0AB8
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38987FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
        call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CE0E8],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0C10
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F9A8],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
        call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CE0E8],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0C10
+       mov       r11,7FFE37EF0C98
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F9A8],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CE0E8],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0C10
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F9A8],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0C98
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        mov       edx,5
-       call      qword ptr [7FFE38515B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FFE38535350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A15ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 42
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384ED6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0C98
+       mov       r11,7FFE37F10CD8
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 114
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389F6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A15EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37EE0578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37EF0578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F380],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37EE0568
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F500],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F4678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00558
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F4690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37EF0578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F380],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37EE0568
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F500],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388BF378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0578
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384CD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0538
+       mov       r11,7FFE37EF0578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F380],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0538
+       mov       r11,7FFE37EE0568
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0538
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F500],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0538
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388D4828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388D4840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0578
+       mov       r11,7FFE37EE0568
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F380],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0578
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F380],0
+       cmp       dword ptr [7FFE3838F500],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0578
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F380],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38515338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38997FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384CD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EF0578
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F380],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38997FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0568
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F500],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384BD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0568
+       mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38505338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37EE0568
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384DE0E8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       r11,7FFE37F00578
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F500],0
+       cmp       dword ptr [7FFE3838F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A05ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DD6F0],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00578
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F500],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A05EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
-       call      qword ptr [7FFE38525B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FFE38505B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFE384DE0E8],0
+       cmp       dword ptr [7FFE384BD6F0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+10],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       mov       r11,7FFE37F00578
+       mov       r11,7FFE37EE0538
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 108
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F9A8],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E6A90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
