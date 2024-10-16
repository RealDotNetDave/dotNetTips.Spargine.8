## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,2C
       call      qword ptr [7FFE8C5053B0]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
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
       mov       rcx,1D42E403318
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L04
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L05
       mov       rcx,1D42E4049E8
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
       mov       r8,1D42E403320
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L07
M01_L02:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FFE8C114870]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       [rsp+3C],bx
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE8C505CC8]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      qword ptr [7FFE8C27DE30]
       mov       ecx,33D
       mov       rdx,7FFE8C144668
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C144668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C27DC20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D42E403310
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       call      qword ptr [7FFE8BC84210]
       mov       rcx,1D42E403318
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FFE8C27DE30]
       mov       ecx,32B
       mov       rdx,7FFE8C144668
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C144668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D42E4049E0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c__0`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__0_0(System.__Canon)
       call      qword ptr [7FFE8BC84210]
       mov       rcx,1D42E4049E8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D42E403310
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       call      qword ptr [7FFE8BC84210]
       mov       rcx,1D42E403320
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L02
; Total bytes of code 774
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesWithStackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       call      qword ptr [7FFE8C4DE9B8]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessagesWithStackTrace(System.Exception)
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
       je        near ptr M01_L46
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1387A401F30
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1387640BED0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L03
M01_L00:
       test      rdi,rdi
       je        near ptr M01_L47
       mov       rcx,1387640D590
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L48
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
       mov       [rbp-50],rcx
       jmp       short M01_L05
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1387640BEB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C4DB678
       mov       [rdi+18],rcx
       mov       rcx,1387640BED0
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
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rbx,[rcx]
       cmp       rbx,r15
       jne       near ptr M01_L20
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,[rbp-50]
       mov       r12,[rcx+8]
       mov       rdx,offset MT_System.Security.SecurityException
       cmp       [r12],rdx
       jne       near ptr M01_L38
       mov       rax,r12
       mov       r13,[rax+10]
       test      r13,r13
       je        near ptr M01_L36
M01_L07:
       mov       rdx,[r12+40]
       mov       r14,[r12+48]
       test      rdx,rdx
       jne       near ptr M01_L34
       cmp       qword ptr [r12+30],0
       jne       near ptr M01_L35
M01_L08:
       test      r14,r14
       jne       short M01_L09
       mov       r14,1790814AB70
M01_L09:
       mov       rdx,r13
       inc       dword ptr [rsi+14]
       mov       r8,[rsi+8]
       mov       r10d,[rsi+10]
       cmp       [r8+8],r10d
       ja        near ptr M01_L33
       mov       [rbp-48],rdx
       mov       [rbp-40],r14
       mov       rcx,rsi
       lea       rdx,[rbp-48]
       call      qword ptr [7FFE8C4DF090]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,System.__Canon>)
       mov       rcx,[rbp-50]
M01_L10:
       cmp       rbx,r15
       jne       near ptr M01_L14
       mov       rdi,rcx
       mov       r14d,[rdi+40]
       test      r14d,r14d
       je        short M01_L13
       cmp       r14d,1
       jne       near ptr M01_L44
       mov       dword ptr [rdi+40],0FFFFFFFF
       mov       r13,[rdi+20]
       mov       rdx,[rdi+10]
       mov       rax,7FFE8C4DB678
       cmp       [r13+18],rax
       jne       near ptr M01_L39
       mov       rdx,[rdx+20]
M01_L11:
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rdi+10],0
       je        near ptr M01_L44
       mov       rax,[rdi+30]
       mov       rdx,[rdi+10]
       mov       rcx,7FFE8C4DB858
       cmp       [rax+18],rcx
       je        near ptr M01_L15
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L15
       jmp       near ptr M01_L44
M01_L13:
       mov       dword ptr [rdi+40],0FFFFFFFF
       mov       rdx,[rdi+10]
       xor       r12d,r12d
       test      rdx,rdx
       setne     r12b
       test      r12d,r12d
       je        near ptr M01_L29
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       test      rdx,rdx
       je        near ptr M01_L31
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       test      rdx,rdx
       je        near ptr M01_L32
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L14:
       mov       r11,7FFE8BB60968
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L37
       jmp       near ptr M01_L44
M01_L15:
       mov       rdx,[rdi+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+40],1
       jmp       near ptr M01_L06
M01_L16:
       mov       rcx,[rbp-50]
       mov       r12,[rcx+8]
       mov       rdx,offset MT_System.Security.SecurityException
       cmp       [r12],rdx
       jne       near ptr M01_L28
       mov       rax,r12
       mov       r13,[rax+10]
       test      r13,r13
       je        near ptr M01_L26
M01_L17:
       mov       rdx,[r12+40]
       mov       r14,[r12+48]
       test      rdx,rdx
       jne       near ptr M01_L24
       cmp       qword ptr [r12+30],0
       jne       near ptr M01_L25
M01_L18:
       test      r14,r14
       jne       short M01_L19
       mov       r14,1790814AB70
M01_L19:
       mov       rdx,r13
       inc       dword ptr [rsi+14]
       mov       r8,[rsi+8]
       mov       r10d,[rsi+10]
       cmp       [r8+8],r10d
       ja        near ptr M01_L23
       mov       [rbp-48],rdx
       mov       [rbp-40],r14
       mov       rcx,rsi
       lea       rdx,[rbp-48]
       call      qword ptr [7FFE8C4DF090]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,System.__Canon>)
       mov       rcx,[rbp-50]
M01_L20:
       mov       rbx,[rcx]
       cmp       rbx,r15
       jne       near ptr M01_L41
       mov       rdi,rcx
       mov       r14d,[rdi+40]
       test      r14d,r14d
       je        near ptr M01_L40
       cmp       r14d,1
       jne       near ptr M01_L44
       mov       dword ptr [rdi+40],0FFFFFFFF
       mov       r13,[rdi+20]
       mov       rdx,[rdi+10]
       mov       rax,7FFE8C4DB678
       cmp       [r13+18],rax
       jne       near ptr M01_L30
       mov       eax,[r13+8]
       mov       rdx,[rdx+20]
M01_L21:
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L22:
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L44
       mov       rax,[rdi+30]
       mov       rcx,7FFE8C4DB858
       cmp       [rax+18],rcx
       jne       near ptr M01_L43
       mov       edx,[rax+8]
       jmp       near ptr M01_L42
M01_L23:
       lea       eax,[r10+1]
       mov       [rsi+10],eax
       mov       eax,r10d
       shl       rax,4
       lea       rdi,[r8+rax+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp-50]
       jmp       near ptr M01_L20
M01_L24:
       mov       rcx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       r9,r12
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE8C4DFD68]
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE8C4DFED0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L18
M01_L26:
       mov       rcx,1790814AC10
       call      qword ptr [7FFE8C24C030]
       mov       rdi,rax
       mov       rcx,r12
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFE8BBEA418]; Precode of System.RuntimeType.ToString()
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE8C24C048]
       mov       r13,rax
       jmp       near ptr M01_L17
M01_L27:
       mov       rcx,[rbp-50]
       mov       r11,7FFE8BB60970
       call      qword ptr [r11]
       mov       r12,rax
M01_L28:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L18
M01_L29:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,31D
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       rdx,rax
       jmp       near ptr M01_L21
M01_L31:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,32B
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,1389
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L33:
       lea       eax,[r10+1]
       mov       [rsi+10],eax
       mov       eax,r10d
       shl       rax,4
       lea       rdi,[r8+rax+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp-50]
       jmp       near ptr M01_L10
M01_L34:
       mov       rcx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L08
M01_L35:
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       r9,r12
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE8C4DFD68]
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE8C4DFED0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L08
M01_L36:
       mov       rcx,1790814AC10
       call      qword ptr [7FFE8C24C030]
       mov       rdi,rax
       mov       rcx,r12
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFE8BBEA418]; Precode of System.RuntimeType.ToString()
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE8C24C048]
       mov       r13,rax
       jmp       near ptr M01_L07
M01_L37:
       mov       rcx,[rbp-50]
       mov       r11,7FFE8BB60970
       call      qword ptr [r11]
       mov       r12,rax
M01_L38:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       rdx,rax
       jmp       near ptr M01_L11
M01_L40:
       mov       dword ptr [rdi+40],0FFFFFFFF
       mov       rdx,[rdi+10]
       xor       r12d,r12d
       test      rdx,rdx
       setne     r12b
       test      r12d,r12d
       je        near ptr M01_L29
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+20]
       test      rdx,rdx
       je        near ptr M01_L31
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+30]
       test      rdx,rdx
       je        near ptr M01_L32
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L22
M01_L41:
       mov       r11,7FFE8BB60968
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L27
       jmp       short M01_L44
M01_L42:
       mov       rdx,[rdi+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+40],1
       jmp       near ptr M01_L16
M01_L43:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L42
M01_L44:
       cmp       rbx,r15
       jne       near ptr M01_L49
M01_L45:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L46:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,33D
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L47:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,32B
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFE8C164668
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L48:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1387640D588
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,7FFE8C4DB858
       call      qword ptr [7FFE8BCA4210]
       mov       rcx,1387640D590
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L49:
       mov       rcx,[rbp-50]
       mov       r11,7FFE8BB60978
       call      qword ptr [r11]
       jmp       near ptr M01_L45
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
       je        short M01_L50
       mov       rcx,[rbp-50]
       mov       rbx,[rcx]
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.ExceptionExtensions+<FromHierarchy>d__1`1[[System.Exception, System.Private.CoreLib]]
       cmp       rbx,r15
       je        short M01_L50
       mov       r11,7FFE8BB60978
       call      qword ptr [r11]
M01_L50:
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
; Total bytes of code 2773
```

