## DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark-20240229-164552
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF05EB570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,2348CF573B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2348CF50008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF05EB620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0607EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF05EB7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,2104D7E73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2104D7E0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF05EB570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,238A69E73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,238A69E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF05EB620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0607B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF05EB7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF05EB610
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,2AF553773B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2AF55370008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF05EB6C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0607EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF05EB850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,1E3414D73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1E3414D0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0637EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25581560008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0204DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0617A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0617AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB570
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,23CF6B973B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,23CF6B90008
-       call      qword ptr [7FFDF0397078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05FB620
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0617B88]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01D6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FB7B0
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0617BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,2104D7E73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2104D7E0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
        call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rdx,7FFDF05EB570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,238A69E73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
+       mov       r9,238A69E0008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFDF05EB620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0607B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp+18]
        mov       rdx,7FFDF05EB7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF05EB610
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,2AF553773B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
+       mov       r9,2AF55370008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF05EB6C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF05EB850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,1E3414D73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1E3414D0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0637EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25581560008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2348CF573B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2348CF50008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF035B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF05EB570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2104D7E73B0
+       mov       rcx,238A69E73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2104D7E0008
-       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,238A69E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF05EB620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637B88]
+       call      qword ptr [7FFDF0607B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF05EB7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF035B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF05EB610
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2104D7E73B0
+       mov       rcx,2AF553773B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2104D7E0008
-       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2AF55370008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF05EB6C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637B88]
+       call      qword ptr [7FFDF0607EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF05EB850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
        call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2104D7E73B0
+       mov       rcx,1E3414D73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2104D7E0008
+       mov       r9,1E3414D0008
        call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637B88]
+       call      qword ptr [7FFDF0637EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp+18]
        mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2104D7E73B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2104D7E0008
+       mov       r9,25581560008
        call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp+10]
        call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF035B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2104D7E73B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2104D7E0008
-       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637B88]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
        call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF05EB610
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,238A69E73B0
+       mov       rcx,2AF553773B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,238A69E0008
+       mov       r9,2AF55370008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF05EB6C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607B88]
+       call      qword ptr [7FFDF0607EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp+10]
        call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF05EB850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,238A69E73B0
+       mov       rcx,1E3414D73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,238A69E0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1E3414D0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607B88]
+       call      qword ptr [7FFDF0637EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,238A69E73B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,238A69E0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25581560008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607B88]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB570
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,238A69E73B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,238A69E0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB620
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607B88]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB7B0
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB610
+       mov       rdx,7FFDF061B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2AF553773B0
+       mov       rcx,1E3414D73B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2AF55370008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1E3414D0008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB6C0
+       mov       rdx,7FFDF061B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0637EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB850
+       mov       rdx,7FFDF061B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF035B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB610
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2AF553773B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2AF55370008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25581560008
+       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB6C0
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01F6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB850
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB610
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,2AF553773B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,2AF55370008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF05EB6C0
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0607EB8]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EB850
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
        call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FFDF01F6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF061B420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,1E3414D73B0
+       mov       rcx,255815673B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,1E3414D0008
+       mov       r9,25581560008
        call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF061B4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637EB8]
+       call      qword ptr [7FFDF0637B88]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp+10]
        call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF061B660
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF035B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B570
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,1E3414D73B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,1E3414D0008
-       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B620
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637EB8]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B7B0
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf01 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+180]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0224DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FFDF0214DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       r8,rax
        mov       rdx,rsi
        mov       r9,[rbx+180]
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Boolean)
-       call      qword ptr [7FFDF0637A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FFDF0627DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0637AC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 95
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       rax,[rax+40]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 44
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        xor       eax,eax
        mov       [rbp-38],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        mov       [rbp-10],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FFDF035B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M02_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M02_L03
 M02_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B420
+       mov       rdx,7FFDF060B570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M02_L03:
-       mov       rcx,255815673B0
+       mov       rcx,25F1EE473B0
        mov       [rsp+20],rcx
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       mov       r9,25581560008
-       call      qword ptr [7FFDF03B7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25F1EE40008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M02_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M02_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M02_L06
 M02_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFDF061B4D0
+       mov       rdx,7FFDF060B620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M02_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFDF0637B88]
+       call      qword ptr [7FFDF0627EB8]
        mov       [rbp-38],rax
 M02_L07:
        mov       rcx,[rbp-38]
        mov       rcx,[rbp-38]
        mov       [rbp-18],rcx
        nop
 M02_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 330
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
-       cmp       dword ptr [7FFDF01F6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF061B660
+       mov       rdx,7FFDF060B7B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0637BD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01D6880],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF033B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,1EA13BF73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1EA13BF0008
+       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01D6880],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF05FBAB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01D6C00],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF033B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,2C8FD0A73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,2C8FD0A0008
+       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01D6C00],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF05FBAB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF031B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,20006A573B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,20006A50008
+       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF05DBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
        call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,224790973B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
+       mov       r9,22479090008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rcx,[rbp+18]
        mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,257003173B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25700310008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,33DE9340008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,22F14ED73B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22F14ED0008
+       mov       r9,30F264E0008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
        call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
        call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
        jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01D6C00],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,2C8FD0A73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
+       mov       r9,2C8FD0A0008
        call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01D6C00],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF031B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,20006A573B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,20006A50008
+       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05DBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,224790973B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,22479090008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,257003173B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25700310008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,33DE9340008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,1EA13BF73B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,1EA13BF0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,30F264E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6880],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF031B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,2C8FD0A73B0
+       mov       rdx,20006A573B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,2C8FD0A0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,20006A50008
+       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01B68C0],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05DBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,2C8FD0A73B0
+       mov       rdx,224790973B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,2C8FD0A0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,22479090008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,2C8FD0A73B0
+       mov       rdx,257003173B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,2C8FD0A0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25700310008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,2C8FD0A73B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,2C8FD0A0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,33DE9340008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF02048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0615ED8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0615EF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF033B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,2C8FD0A73B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,2C8FD0A0008
-       call      qword ptr [7FFDF03A6550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,30F264E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0615FB0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01D6C00],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05FBAB0
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF06160E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF031B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,20006A573B0
+       mov       rdx,224790973B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,20006A50008
-       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,22479090008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05DBA10
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF031B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,20006A573B0
+       mov       rdx,257003173B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,20006A50008
-       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25700310008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05DBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF031B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,20006A573B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,20006A50008
-       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,33DE9340008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05DBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01E48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF05F5F80]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF05F5F98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF031B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,20006A573B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,20006A50008
-       call      qword ptr [7FFDF0386550]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,30F264E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF05F6058]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01B68C0],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05DBA10
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF05F6190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,224790973B0
+       mov       rdx,257003173B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22479090008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25700310008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF032B310],0
+       cmp       dword ptr [7FFDF034B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,224790973B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22479090008
-       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,33DE9340008
+       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01C6918],0
+       cmp       dword ptr [7FFDF01E6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF05EBA10
+       mov       rdx,7FFDF060BA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
        call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0607A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0607AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,224790973B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,22479090008
+       mov       r9,30F264E0008
        call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0607B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rcx,[rbp+18]
        mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0607CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,257003173B0
+       mov       rdx,33DE93473B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,25700310008
+       mov       r9,33DE9340008
        call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01E6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF034B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,257003173B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,25700310008
-       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,30F264E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01E6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF060BA10
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
**Diff for AddIf02 method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      rsi
        push      rbx
        sub       rsp,68
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        vmovdqa   xmmword ptr [rsp+50],xmm4
        xor       eax,eax
        mov       [rsp+60],rax
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        lea       rdx,[rsp+20]
        mov       rcx,rbx
-       call      qword ptr [7FFDF0214E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
+       call      qword ptr [7FFDF01F4E40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        mov       r8,[rbx+188]
        cmp       dword ptr [r8+8],1
        setg      r8b
        movzx     r8d,r8b
        lea       rdx,[rsp+20]
        mov       rcx,rsi
-       call      qword ptr [7FFDF0627A98]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
+       call      qword ptr [7FFDF0607DC8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        mov       r8,rax
        mov       rcx,rbx
        mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[])
        add       rsp,68
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FFDF0627AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       jmp       qword ptr [7FFDF0607DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
 ; Total bytes of code 127
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonVal01()
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,20
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFDF01E6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rsi,[rbp+10]
        add       rsi,78
        mov       rdi,[rbp+18]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        movsq
        mov       rax,[rbp+18]
        add       rsp,20
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0A0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M02_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M02_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFDF034B310],0
+       cmp       dword ptr [7FFDF032B310],0
        je        short M02_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_BOX
        xor       edx,edx
        test      rax,rax
        sete      dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        je        short M02_L02
        nop
        mov       rdx,[rbp+10]
        mov       [rbp-20],rdx
        nop
        jmp       near ptr M02_L05
 M02_L02:
-       mov       rdx,33DE93473B0
+       mov       rdx,30F264E73B0
        mov       [rsp+20],rdx
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], System.String, System.String)
        xor       r8d,r8d
-       mov       r9,33DE9340008
-       call      qword ptr [7FFDF03A7078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,30F264E0008
+       call      qword ptr [7FFDF0387078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M02_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M02_L04
 M02_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-80],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-78]
        mov       ecx,9
        rep movsq
        mov       rcx,[rbp-80]
        lea       rdx,[rbp-78]
-       call      qword ptr [7FFDF0627B70]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
+       call      qword ptr [7FFDF0607EA0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
        mov       [rbp-30],rax
 M02_L04:
        mov       rax,[rbp-30]
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
 M02_L05:
        mov       rax,[rbp-20]
        add       rsp,0A0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 284
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
-       cmp       dword ptr [7FFDF01E6918],0
+       cmp       dword ptr [7FFDF01C6918],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp+18]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M03_L01
        mov       r8,[rbp+18]
        mov       r8,[r8+10]
        mov       r8,[r8+10]
        mov       [rbp-20],r8
        jmp       short M03_L02
 M03_L01:
        mov       rcx,[rbp+18]
-       mov       rdx,7FFDF060BA10
+       mov       rdx,7FFDF05EBA10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M03_L02:
        lea       r8,[rbp+20]
        mov       rcx,[rbp-18]
        mov       rdx,[rbp-20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFDF0627CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFDF0607FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        nop
        add       rsp,38
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 146
```
