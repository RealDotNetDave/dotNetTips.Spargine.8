## DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark-20240224-225454
**Diff for AddRange01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF8150118E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,1F970A1B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
+       mov       r9,1F970A10008
        call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF8150119C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,1F970A1B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
+       mov       r9,1F970A10008
        call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF815011A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
+       mov       r8,1F970A10008
+       mov       r9,1F970A1B718
        call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+1E0]
        cmp       qword ptr [rbp-38],0
        je        short M01_L38
        mov       rcx,[rbp-38]
        mov       r11,7FF8149A0358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F4B8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF815378EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,29AB1C0B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29AB1C00008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,29AB1C0B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29AB1C00008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29AB1C00008
+       mov       r9,29AB1C0B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF814FA8900
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF815358EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,284EA25B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,284EA25B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,284EA250008
+       mov       r9,284EA25B718
+       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF814FA3D98
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF815368EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF815001310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF8150018E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,1FDFB4CB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF8150019C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,1FDFB4CB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF815001A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1FDFB4C0008
+       mov       r9,1FDFB4CB718
+       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814990360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF815001B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF815001EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF815001BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814990350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814990368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814990358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F528],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF8154373B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,23CD41EB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,23CD41EB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,23CD41E0008
+       mov       r9,23CD41EB718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF8154668C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,2722B04B6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,2722B04B6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,2722B040008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,2722B040008
-       mov       r9,2722B04B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378CD8
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,29AB1C0B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29AB1C00008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,29AB1C0B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,29AB1C00008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,29AB1C00008
+       mov       r9,29AB1C0B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF814FA8900
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF815358EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,284EA25B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,284EA25B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,284EA250008
+       mov       r9,284EA25B718
+       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,7FF814FA3D98
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF815368EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF815001310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF8150018E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,1FDFB4CB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF8150019C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,1FDFB4CB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF815001A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1FDFB4C0008
+       mov       r9,1FDFB4CB718
+       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814990360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF815001B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF815001EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF815001BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814990350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814990368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814990358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E2F528],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF8154373B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,23CD41EB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,23CD41EB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,23CD41E0008
+       mov       r9,23CD41EB718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF8154668C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FC5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81536F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815011310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FCC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150118E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1F970A1B6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150119C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1F970A1B6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1F970A10008
-       call      qword ptr [7FF814FCCDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815011A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1F970A10008
-       mov       r9,1F970A1B718
-       call      qword ptr [7FF814FCCE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815011B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F4D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815011EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FC8900
-       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815011BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F2F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815011BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815011BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815011DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF8149A0350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF8149A0368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF8149A0358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F4B8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815378EE0
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29AB1C0B6C8
+       mov       rcx,284EA25B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
-       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29AB1C0B6E8
+       mov       rdx,284EA25B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
-       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,284EA250008
+       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29AB1C00008
-       mov       r9,29AB1C0B718
-       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,284EA250008
+       mov       r9,284EA25B718
+       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA8900
+       mov       r8,7FF814FA3D98
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815358EE0
+       mov       rdx,7FF815368EE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       rdx,7FF814FF1310
+       mov       rdx,7FF815001310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF814FF18E0
+       mov       rdx,7FF8150018E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29AB1C0B6C8
+       mov       rcx,1FDFB4CB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
-       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF814FF19C8
+       mov       rdx,7FF8150019C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29AB1C0B6E8
+       mov       rdx,1FDFB4CB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
-       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF814FF1A80
+       mov       rdx,7FF815001A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29AB1C00008
-       mov       r9,29AB1C0B718
-       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1FDFB4C0008
+       mov       r9,1FDFB4CB718
+       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF814FF1BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF814FF1BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF814FF1DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF814980360
+       mov       r11,7FF814990360
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
-       mov       rdx,7FF814FF1B58
+       mov       rdx,7FF815001B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF814FF1EE8
+       mov       rdx,7FF815001EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA8900
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF814FF1BA8
+       mov       rdx,7FF815001BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF814FF1BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF814FF1BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF814FF1DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF814980350
+       mov       r11,7FF814990350
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
-       mov       r11,7FF814980368
+       mov       r11,7FF814990368
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
-       mov       r11,7FF814980358
+       mov       r11,7FF814990358
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F528],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815358EE0
+       mov       rdx,7FF8154373B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29AB1C0B6C8
+       mov       rcx,23CD41EB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,23CD41E0008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29AB1C0B6E8
+       mov       rdx,23CD41EB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,23CD41E0008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29AB1C00008
-       mov       r9,29AB1C0B718
+       mov       r8,23CD41E0008
+       mov       r9,23CD41EB718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA8900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815358EE0
+       mov       rdx,7FF8154668C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29AB1C0B6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,1B9FA750008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29AB1C0B6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,1B9FA750008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29AB1C00008
-       mov       r9,29AB1C0B718
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA8900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815358EE0
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81534EC40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,29AB1C0B6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,29AB1C0B6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,29AB1C00008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,29AB1C00008
-       mov       r9,29AB1C0B718
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA8900
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815358EE0
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534F0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       rdx,7FF814FF1310
+       mov       rdx,7FF815001310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF814FF18E0
+       mov       rdx,7FF8150018E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,284EA25B6C8
+       mov       rcx,1FDFB4CB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF814FF19C8
+       mov       rdx,7FF8150019C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,284EA25B6E8
+       mov       rdx,1FDFB4CB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FDFB4C0008
+       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF814FF1A80
+       mov       rdx,7FF815001A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,284EA250008
-       mov       r9,284EA25B718
-       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1FDFB4C0008
+       mov       r9,1FDFB4CB718
+       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF814FF1BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF814FF1BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF814FF1DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF814980360
+       mov       r11,7FF814990360
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
-       mov       rdx,7FF814FF1B58
+       mov       rdx,7FF815001B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF814FF1EE8
+       mov       rdx,7FF815001EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA3D98
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF814FF1BA8
+       mov       rdx,7FF815001BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF814FF1BC8
+       mov       rdx,7FF815001BC8
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
-       mov       rdx,7FF814FF1BE0
+       mov       rdx,7FF815001BE0
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
-       mov       rdx,7FF814FF1DC0
+       mov       rdx,7FF815001DC0
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
-       mov       r11,7FF814980350
+       mov       r11,7FF814990350
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
-       mov       r11,7FF814980368
+       mov       r11,7FF814990368
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
-       mov       r11,7FF814980358
+       mov       r11,7FF814990358
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F528],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815368EE0
+       mov       rdx,7FF8154373B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,284EA25B6C8
+       mov       rcx,23CD41EB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,284EA25B6E8
+       mov       rdx,23CD41EB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,284EA250008
-       mov       r9,284EA25B718
-       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,23CD41E0008
+       mov       r9,23CD41EB718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA3D98
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815368EE0
+       mov       rdx,7FF8154668C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,284EA25B6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,284EA25B6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,284EA250008
-       mov       r9,284EA25B718
-       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA3D98
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815368EE0
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FA53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81535FAB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FA7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,284EA25B6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,284EA25B6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,284EA250008
-       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,284EA250008
-       mov       r9,284EA25B718
-       call      qword ptr [7FF814FAC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F2CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
        mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
-       mov       r8,7FF814FA3D98
+       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        mov       rcx,[rbp-118]
        mov       [rbp-40],rcx
        mov       rcx,[rbp-10]
        lea       rcx,[rcx+10]
        mov       rdx,[rbp-118]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp-40]
        mov       [rbp-0B8],rcx
        mov       rcx,[rbp+10]
        mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F0EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815368EE0
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535FF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815001310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150018E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1FDFB4CB6C8
+       mov       rcx,23CD41EB6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150019C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1FDFB4CB6E8
+       mov       rdx,23CD41EB6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,23CD41E0008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815001A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1FDFB4C0008
-       mov       r9,1FDFB4CB718
-       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,23CD41E0008
+       mov       r9,23CD41EB718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815001B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815001EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815001BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF814990368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF814990358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F528],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF8154373B0
+       mov       rdx,7FF8154668C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815001310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150018E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1FDFB4CB6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150019C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1FDFB4CB6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1B9FA750008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815001A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1FDFB4C0008
-       mov       r9,1FDFB4CB718
-       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815001B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815001EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815001BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF814990368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF814990358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F528],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF8154373B0
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
-       call      qword ptr [7FF814FB53F8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
+       call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81541E9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       rdx,7FF815001310
+       mov       rdx,7FF814FF1310
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-58],rax
 M01_L03:
        mov       rcx,[rbp-58]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF814FB7D80]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF814FAC8E8]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       mov       rdx,7FF8150018E0
+       mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1FDFB4CB6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF8150019C8
+       mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1FDFB4CB6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1FDFB4C0008
-       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,26512C50008
+       call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
-       mov       rdx,7FF815001A80
+       mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1FDFB4C0008
-       mov       r9,1FDFB4CB718
-       call      qword ptr [7FF814FBC528]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
+       call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990360
+       mov       r11,7FF814980360
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
-       mov       rdx,7FF815001B58
+       mov       rdx,7FF814FF1B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-98],rax
 M01_L20:
        mov       rcx,[rbp-98]
        mov       rdx,[rbp+20]
-       call      qword ptr [7FF814F3CA20]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF814F2D200]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF815001EE8
+       mov       rdx,7FF814FF1EE8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-120],rax
 M01_L22:
        mov       rcx,[rbp-120]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-118],rax
        mov       rcx,[rbp-118]
        mov       rdx,[rbp-10]
        mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
-       mov       rdx,7FF815001BA8
+       mov       rdx,7FF814FF1BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-0C0],rax
 M01_L25:
        mov       rcx,[rbp-0C0]
        mov       rdx,[rbp-0B0]
        mov       r8,[rbp-0B8]
-       call      qword ptr [7FF814F1EBF8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF814F0F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,7FF815001BC8
+       mov       rdx,7FF814FF1BC8
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
-       mov       rdx,7FF815001BE0
+       mov       rdx,7FF814FF1BE0
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
-       mov       rdx,7FF815001DC0
+       mov       rdx,7FF814FF1DC0
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
-       mov       r11,7FF814990350
+       mov       r11,7FF814980350
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
-       mov       r11,7FF814990368
+       mov       r11,7FF814980368
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
-       mov       r11,7FF814990358
+       mov       r11,7FF814980358
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
-       cmp       dword ptr [7FF814E2F528],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF8154373B0
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81541EE80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,23CD41EB6C8
+       mov       rcx,1B9FA75B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,23CD41E0008
+       mov       r9,1B9FA750008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,23CD41EB6E8
+       mov       rdx,1B9FA75B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,23CD41E0008
+       mov       r9,1B9FA750008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,23CD41E0008
-       mov       r9,23CD41EB718
+       mov       r8,1B9FA750008
+       mov       r9,1B9FA75B718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF8154668C8
+       mov       rdx,7FF815466958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815475398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,23CD41EB6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,23CD41E0008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,23CD41EB6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,23CD41E0008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,23CD41E0008
-       mov       r9,23CD41EB718
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF8154668C8
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815475830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rsi,[rbx+190]
        mov       rcx,rbx
        mov       rax,[rbx]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean)
        mov       r9d,1
        call      qword ptr [7FF814FA5BC0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
        mov       rcx,rbx
        mov       r8,rsi
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815475938]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FF8154851E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rdx,7FF814FF18E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-60],rax
 M01_L05:
-       mov       rcx,1B9FA75B6C8
+       mov       rcx,26512C5B6C8
        mov       [rsp+20],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       mov       r9,1B9FA750008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF19C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-70],rax
 M01_L07:
        mov       rdx,[rbp-10]
        mov       [rbp-78],rdx
-       mov       rdx,1B9FA75B6E8
+       mov       rdx,26512C5B6E8
        mov       [rsp+20],rdx
        mov       rdx,[rbp-10]
        mov       rdx,[rdx+8]
        mov       rcx,[rbp-70]
        xor       r8d,r8d
-       mov       r9,1B9FA750008
+       mov       r9,26512C50008
        call      qword ptr [7FF814FACDF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
        mov       rdx,7FF814FF1A80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-88],rax
 M01_L09:
        mov       rcx,[rbp-88]
        mov       rdx,[rbp-80]
-       mov       r8,1B9FA750008
-       mov       r9,1B9FA75B718
+       mov       r8,26512C50008
+       mov       r9,26512C5B718
        call      qword ptr [7FF814FACE70]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
-       mov       rdx,7FF815466958
+       mov       rdx,7FF815467FF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815475DD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF815485680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF8149709F8
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F3E0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF8149909F8
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F8D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF8149B09F8
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF814980B10
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF814990C10
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F3E8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF814980C08
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FC5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536F378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF8149A09F8
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F4D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF8149909F8
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F4D648],0
+       cmp       dword ptr [7FF814F8D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF8149B09F8
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F4D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF814980B10
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F4D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF814990C10
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E2F3E8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F4D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF814980C08
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
        call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81533E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF8149709F8
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E0F3E0],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81533E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F8D648],0
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
-       mov       r11,7FF8149909F8
+       mov       r11,7FF8149B09F8
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149909F8
+       mov       r11,7FF814980B10
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149909F8
+       mov       r11,7FF814990C10
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E2F3E8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149909F8
+       mov       r11,7FF814980C08
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF8149909F8
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F8D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149B09F8
+       mov       r11,7FF814980B10
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F8D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF8149B09F8
+       mov       r11,7FF814990C10
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F3E8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F8D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149B09F8
+       mov       r11,7FF814980C08
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FD5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153C6F58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F8D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF8149B09F8
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153C6F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF814980B10
+       mov       r11,7FF814990C10
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F3E8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814980B10
+       mov       r11,7FF814980C08
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FA5B18]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81543FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF814980B10
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81543FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814990C10
+       mov       r11,7FF814980C08
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
-       cmp       dword ptr [7FF814E2F3E8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FB5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF814990C10
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E2F3E8],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        mov       edx,5
-       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
+       call      qword ptr [7FF814F95350]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815475380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815465ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F4D648],0
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
-       mov       r11,7FF814980C08
+       mov       r11,7FF814970C08
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815475398]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815465EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF814990578
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       mov       r11,7FF814980558
+       mov       r11,7FF814980548
        call      qword ptr [r11]
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setg      al
        mov       [rbp-8],eax
        nop
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF814990568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF8149A0568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980558
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF814980548
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF814990568
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
        cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF8149A0568
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990578
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535EDC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
-       mov       r11,7FF814980548
+       mov       r11,7FF814990568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980548
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980548
+       mov       r11,7FF8149A0568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814980548
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81534EC28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980548
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990568
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990568
+       mov       r11,7FF8149A0568
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF814990568
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FB5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814990568
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535E9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF8149A0578
+       mov       r11,7FF8149A0568
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
        cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149A0578
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815484CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F7D648],0
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
        cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
-       mov       r11,7FF8149A0568
+       mov       r11,7FF814980568
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
        call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154A5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF8149A0568
+       mov       r11,7FF8149A0578
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
        cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154A5EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rcx,[rbx+188]
-       call      qword ptr [7FF814FA5338]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
+       call      qword ptr [7FF814FC5B00]; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815474CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A5920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 37
 ; DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
-       mov       r11,7FF814980568
+       mov       r11,7FF8149A0578
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
-       cmp       dword ptr [7FF814E0F388],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815474D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
