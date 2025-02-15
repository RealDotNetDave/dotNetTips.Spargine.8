## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesSeparator()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       dword ptr [rsp+28],3A
       lea       rdx,[rsp+28]
       call      qword ptr [7FF959167DC8]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char ByRef)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,rdx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L03
       mov       rcx,206BE805D38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,206BE8074D8
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M01_L06
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
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
       mov       r8,206BE805D40
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF958CF57E8]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,word ptr [rbx]
       mov       [rsp+3C],dx
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF95916C708]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FF958D7FB58]
       mov       ecx,35B
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF958D7F948]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF958AE6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,206BE805D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF959163ED0
       call      qword ptr [7FF958924210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,206BE805D38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FF958D7FB58]
       mov       ecx,2C1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958D7F948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958AE6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,206BE8074D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,7FF9591680F0
       call      qword ptr [7FF958924210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,206BE8074D8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,206BE805D30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF959163EE8
       call      qword ptr [7FF958924210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,206BE805D40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 778
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       dword ptr [rsp+28],2C
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9591CF138]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char ByRef)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,rdx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L03
       mov       rcx,173D3405D38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,173D34074D8
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M01_L06
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
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
       mov       r8,173D3405D40
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF958D4E910]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,word ptr [rbx]
       mov       [rsp+3C],dx
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF9591CFA50]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FF958E4DA10]
       mov       ecx,35B
       mov       rdx,7FF958DC0780
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958C6BDF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958956B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF958DC0780
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF958956B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF958E4D800]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF958B16670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,173D3405D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF9591CB240
       call      qword ptr [7FF958954210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,173D3405D38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FF958E4DA10]
       mov       ecx,2C1
       mov       rdx,7FF958DC0780
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958C6BDF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958956B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF958DC0780
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958956B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958E4D800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958B16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,173D34074D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,7FF9591CB438
       call      qword ptr [7FF958954210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,173D34074D8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,173D3405D30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF9591CB258
       call      qword ptr [7FF958954210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,173D3405D40
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 778
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesWithStackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       call      qword ptr [7FF95916DE78]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessagesWithStackTrace(System.Exception)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessagesWithStackTrace(System.Exception)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L27
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1995E001FC0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1995C003D50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L03
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L28
       mov       rcx,1995C0054E0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L29
M01_L01:
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+40],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+44],eax
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+38]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [r13+40],0FFFFFFFE
       jne       near ptr M01_L04
       mov       ebx,[r13+44]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       near ptr M01_L04
       xor       ecx,ecx
       mov       [r13+40],ecx
       mov       rdi,r13
M01_L02:
       mov       rdx,[r13+18]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r13+28]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r13+38]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rdi
       jmp       short M01_L05
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1995C003D38
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF95916AB38
       mov       [rdi+18],rcx
       mov       rcx,1995C003D50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       eax,eax
       mov       [rdi+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+44],eax
       jmp       near ptr M01_L02
M01_L05:
       cmp       [rdi],r15
       jne       near ptr M01_L12
       mov       rbx,rdi
       mov       ecx,[rbx+40]
       test      ecx,ecx
       je        near ptr M01_L13
       cmp       ecx,1
       jne       near ptr M01_L25
       mov       dword ptr [rbx+40],0FFFFFFFF
       mov       r14,[rbx+20]
       mov       rdx,[rbx+10]
       mov       rcx,7FF95916AB38
       cmp       [r14+18],rcx
       jne       near ptr M01_L15
       mov       rdx,[rdx+20]
M01_L06:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L25
       mov       rax,[rbx+30]
       mov       rdx,[rbx+10]
       mov       rcx,7FF95916AD18
       cmp       [rax+18],rcx
       je        near ptr M01_L14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L14
       jmp       near ptr M01_L25
M01_L08:
       mov       r14,[rdi+8]
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [r14],rcx
       jne       near ptr M01_L24
       mov       rcx,r14
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M01_L22
M01_L09:
       mov       rdx,[r14+40]
       mov       r13,[r14+48]
       test      rdx,rdx
       jne       near ptr M01_L20
       cmp       qword ptr [r14+30],0
       jne       near ptr M01_L21
M01_L10:
       test      r13,r13
       jne       short M01_L11
       mov       r13,1D9EDE74428
M01_L11:
       mov       rdx,rbx
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       r12d,[rsi+10]
       cmp       [rbx+8],r12d
       ja        near ptr M01_L19
       mov       [rbp-48],rdx
       mov       [rbp-40],r13
       mov       rcx,rsi
       lea       rdx,[rbp-48]
       call      qword ptr [7FF95916E550]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,System.__Canon>)
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rdi
       mov       r11,7FF9587E0A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L23
       jmp       near ptr M01_L25
M01_L13:
       mov       dword ptr [rbx+40],0FFFFFFFF
       mov       rdx,[rbx+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M01_L16
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        near ptr M01_L17
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        near ptr M01_L18
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L07
M01_L14:
       mov       rdx,[rbx+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+40],1
       jmp       near ptr M01_L08
M01_L15:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rdx,rax
       jmp       near ptr M01_L06
M01_L16:
       call      qword ptr [7FF958DD44C8]
       mov       ecx,2E9
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958DD42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958AE6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       call      qword ptr [7FF958DD44C8]
       mov       ecx,109E
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958DD42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958AE6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       call      qword ptr [7FF958DD44C8]
       mov       ecx,10B0
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958DD42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958AE6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       lea       ecx,[r12+1]
       mov       [rsi+10],ecx
       mov       ecx,r12d
       shl       rcx,4
       lea       rbx,[rbx+rcx+10]
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L20:
       mov       rcx,r13
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M01_L10
M01_L21:
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       r9,r14
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FF95916F228]
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF95916F390]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M01_L10
M01_L22:
       mov       rcx,1D9EDE74518
       call      qword ptr [7FF958E0C030]
       mov       rbx,rax
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FF95886A418]; Precode of System.RuntimeType.ToString()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF958E0C048]
       mov       rbx,rax
       jmp       near ptr M01_L09
M01_L23:
       mov       rcx,rdi
       mov       r11,7FF9587E0A70
       call      qword ptr [r11]
       mov       r14,rax
M01_L24:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r13,rax
       jmp       near ptr M01_L10
M01_L25:
       cmp       [rdi],r15
       jne       near ptr M01_L30
       mov       dword ptr [rdi+40],0FFFFFFFE
M01_L26:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       call      qword ptr [7FF958DD44C8]
       mov       ecx,35B
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF958DD42B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF958AE6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       call      qword ptr [7FF958DD44C8]
       mov       ecx,2C1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,149C
       mov       rdx,7FF958BE5A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FF958D293A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF958926B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF958DD42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF958AE6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1995C0054D8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,7FF95916AD18
       call      qword ptr [7FF958924210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1995C0054E0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L30:
       mov       rcx,rdi
       mov       r11,7FF9587E0A78
       call      qword ptr [r11]
       jmp       near ptr M01_L26
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L32
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
       mov       rdi,[rbp-50]
       cmp       [rdi],r15
       jne       short M01_L31
       mov       dword ptr [rdi+40],0FFFFFFFE
       jmp       short M01_L32
M01_L31:
       mov       rcx,rdi
       mov       r11,7FF9587E0A78
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
; Total bytes of code 2061
```

