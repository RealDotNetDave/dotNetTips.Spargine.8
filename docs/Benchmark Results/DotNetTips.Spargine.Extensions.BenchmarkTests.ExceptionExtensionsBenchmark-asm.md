## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       edx,2C
       call      qword ptr [7FF81523F3A8]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81523F438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814F42150],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,223A0EE2F60
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Exception, System.Private.CoreLib]](System.Exception, System.Exception, System.String, System.String)
       xor       r8d,r8d
       mov       r9,223A0ED0008
       call      qword ptr [7FF814FC7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       [rbp+10],rcx
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E3110031B8
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1E3110031B0
       mov       rdx,[rdx]
       mov       [rbp-78],rdx
       mov       rdx,[rbp-78]
       mov       rcx,[rbp-70]
       mov       r8,7FF81523B4B0
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-70]
       mov       rcx,1E3110031B8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       mov       [rbp-30],r8
M01_L02:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      qword ptr [7FF81523F528]; DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E3110031C0
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1E3110031B0
       mov       rdx,[rdx]
       mov       [rbp-80],rdx
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-68]
       mov       r8,7FF81523B4C8
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F42638
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-68]
       mov       rcx,1E3110031C0
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-68]
       mov       [rbp-50],r8
M01_L03:
       mov       r8,[rbp-50]
       mov       rdx,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF814F24870]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-58],rax
       mov       rdx,[rbp-58]
       mov       [rbp-8],rdx
       mov       edx,[rbp+18]
       movzx     edx,dx
       mov       r8,[rbp-8]
       mov       rcx,offset MD_System.String.Join[[System.String, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF81523F570]; System.String.Join[[System.__Canon, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 643
```
```assembly
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815258D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81523FE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

