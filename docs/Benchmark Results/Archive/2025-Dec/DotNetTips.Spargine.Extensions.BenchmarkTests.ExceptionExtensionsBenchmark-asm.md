## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesSeparator()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       edx,3A
       call      qword ptr [7FF90090E418]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
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
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return FastStringBuilder.Join(messages, delimiter);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L03
       mov       rcx,14241403F70
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,14241405588
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M01_L06
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+40],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+44],eax
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+38]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,14241403F78
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,7FF90091FDC8
       call      qword ptr [7FF9004A5008]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       movzx     edx,bx
       lea       rcx,[rsp+28]
       call      qword ptr [7FF90090E658]; DotNetTips.Spargine.Core.FastStringBuilder.Join(System.Collections.Generic.IEnumerable`1<System.String> ByRef, Char)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FF9005357A0]
       mov       ecx,357
       mov       rdx,7FF9004DACE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9004DACE8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF900535590]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9001F6718]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,14241403F68
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14241403F70
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FF9005357A0]
       mov       ecx,2BD
       mov       rdx,7FF9004DACE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004DACE8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF900535590]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,14241405580
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c__0`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__0_0(System.__Canon)
       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14241405588
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,14241403F68
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14241403F78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 741
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       edx,2C
       call      qword ptr [7FF90093E418]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
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
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return FastStringBuilder.Join(messages, delimiter);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L03
       mov       rcx,19AE0803F70
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,19AE0805588
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M01_L06
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+40],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+44],eax
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+38]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,19AE0803F78
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,7FF90094FDC8
       call      qword ptr [7FF9004D5008]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       movzx     edx,bx
       lea       rcx,[rsp+28]
       call      qword ptr [7FF90093E658]; DotNetTips.Spargine.Core.FastStringBuilder.Join(System.Collections.Generic.IEnumerable`1<System.String> ByRef, Char)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FF9005657A0]
       mov       ecx,357
       mov       rdx,7FF90050ACE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF90050ACE8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF900565590]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF900226718]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,19AE0803F68
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19AE0803F70
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FF9005657A0]
       mov       ecx,2BD
       mov       rdx,7FF90050ACE8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF90050ACE8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF900565590]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,19AE0805580
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c__0`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__0_0(System.__Canon)
       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19AE0805588
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,19AE0803F68
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19AE0803F78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 741
```

