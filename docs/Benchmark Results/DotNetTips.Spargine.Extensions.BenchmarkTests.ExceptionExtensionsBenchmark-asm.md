## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,2C
       call      qword ptr [7FFBF9DAC828]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       ebx,edx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L03
       mov       rcx,23DB5C0C758
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,23DB5C0DE38
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
       mov       r8,23DB5C0C760
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FFBF9A04870]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       [rsp+3C],bx
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFBF9DAD140]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FFBF9B5CCD8]
       mov       ecx,31F
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFBF9B5CAC8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFBF97E6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,23DB5C0C750
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9DA8930
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23DB5C0C758
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FFBF9B5CCD8]
       mov       ecx,30D
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23DB5C0DE30
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,7FFBF9DA8B28
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23DB5C0DE38
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23DB5C0C750
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFBF9DA8948
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23DB5C0C760
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 774
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesWithStackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       call      qword ptr [7FFBF9D9D248]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessagesWithStackTrace(System.Exception)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L27
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2D743401F38
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2D74340E760
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L03
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L28
       mov       rcx,2D74340FE30
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
       mov       rcx,rdi
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2D74340E748
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFBF9D99F08
       mov       [rdi+18],rcx
       mov       rcx,2D74340E760
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
       cmp       [rcx],r15
       jne       near ptr M01_L12
       mov       rbx,rcx
       mov       edx,[rbx+40]
       test      edx,edx
       je        near ptr M01_L19
       cmp       edx,1
       jne       near ptr M01_L25
       mov       dword ptr [rbx+40],0FFFFFFFF
       mov       rdi,[rbx+20]
       mov       rdx,[rbx+10]
       mov       rax,7FFBF9D99F08
       cmp       [rdi+18],rax
       jne       near ptr M01_L21
       mov       rdx,[rdx+20]
M01_L06:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L25
       mov       rax,[rbx+30]
       mov       rdx,[rbx+10]
       mov       rcx,7FFBF9D9A0E8
       cmp       [rax+18],rcx
       je        near ptr M01_L20
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L20
       jmp       near ptr M01_L25
M01_L08:
       mov       rcx,[rbp-48]
       mov       rdi,[rcx+8]
       mov       rdx,offset MT_System.Security.SecurityException
       cmp       [rdi],rdx
       jne       near ptr M01_L18
       mov       rdx,rdi
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M01_L16
M01_L09:
       mov       rdx,[rdi+40]
       mov       r14,[rdi+48]
       test      rdx,rdx
       jne       near ptr M01_L14
       cmp       qword ptr [rdi+30],0
       jne       near ptr M01_L15
M01_L10:
       test      r14,r14
       jne       short M01_L11
       mov       r14,317D124ABD8
M01_L11:
       mov       rdx,rbx
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       r13d,[rsi+10]
       cmp       [rbx+8],r13d
       ja        short M01_L13
       mov       [rbp-40],rdx
       mov       [rbp-38],r14
       mov       rcx,rsi
       lea       rdx,[rbp-40]
       call      qword ptr [7FFBF9D9D920]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,System.__Canon>)
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L05
M01_L12:
       mov       r11,7FFBF9410968
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L17
       jmp       near ptr M01_L25
M01_L13:
       lea       eax,[r13+1]
       mov       [rsi+10],eax
       mov       eax,r13d
       shl       rax,4
       lea       rbx,[rbx+rax+10]
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,r14
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L10
M01_L15:
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       r9,rdi
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFBF9D9E5F8]
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFBF9D9E760]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L10
M01_L16:
       mov       rcx,317D124AC78
       call      qword ptr [7FFBF9B0C030]
       mov       rbx,rax
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFBF949A418]; Precode of System.RuntimeType.ToString()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9B0C048]
       mov       rbx,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rcx,[rbp-48]
       mov       r11,7FFBF9410970
       call      qword ptr [r11]
       mov       rdi,rax
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L10
M01_L19:
       mov       dword ptr [rbx+40],0FFFFFFFF
       mov       rdx,[rbx+10]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L22
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        near ptr M01_L23
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        near ptr M01_L24
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L07
M01_L20:
       mov       rdx,[rbx+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+40],1
       jmp       near ptr M01_L08
M01_L21:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rdx,rax
       jmp       near ptr M01_L06
M01_L22:
       call      qword ptr [7FFBF9B4CCD8]
       mov       ecx,2FF
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       call      qword ptr [7FFBF9B4CCD8]
       mov       ecx,30D
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       call      qword ptr [7FFBF9B4CCD8]
       mov       ecx,1355
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       mov       rcx,[rbp-48]
       cmp       [rcx],r15
       jne       near ptr M01_L30
M01_L26:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
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
M01_L27:
       call      qword ptr [7FFBF9B4CCD8]
       mov       ecx,31F
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFBF9B4CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFBF97D6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L28:
       call      qword ptr [7FFBF9B4CCD8]
       mov       ecx,30D
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A165B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4CAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2D74340FE28
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,7FFBF9D9A0E8
       call      qword ptr [7FFBF9554210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2D74340FE30
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L30:
       mov       r11,7FFBF9410978
       call      qword ptr [r11]
       jmp       near ptr M01_L26
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
       mov       rcx,[rbp-48]
       cmp       [rcx],r15
       je        short M01_L31
       mov       r11,7FFBF9410978
       call      qword ptr [r11]
M01_L31:
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
; Total bytes of code 2037
```

