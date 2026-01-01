## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFEBE7A74B0]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFEBE73DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rsi
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
; Total bytes of code 138
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FFEBE7A7498]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L21
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE684348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M02_L22
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L04
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-30],rbx
       jmp       short M02_L06
M02_L03:
       mov       rcx,rdx
       mov       rdx,7FFEBEF727D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBED5D368
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M02_L01
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBEF727E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       test      rbx,rbx
       je        near ptr M02_L14
       mov       r14,[rbx]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       cmp       r14,rcx
       jne       near ptr M02_L14
       jmp       short M02_L10
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L09
M02_L08:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       edi,[rcx+10]
       cmp       [r10+8],edi
       jbe       near ptr M02_L16
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBEF727F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L08
M02_L10:
       mov       rcx,rbx
       call      qword ptr [7FFEBEEF62A8]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M02_L07
       jmp       near ptr M02_L19
M02_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L13
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       edi,[rcx+10]
       cmp       [r10+8],edi
       jbe       short M02_L15
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFEBEF727F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L12
M02_L14:
       mov       r14,[rbx]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       cmp       r14,rcx
       jne       short M02_L17
       mov       rcx,rbx
       call      qword ptr [7FFEBEEF62A8]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M02_L18
M02_L15:
       mov       rdx,rax
       call      qword ptr [7FFEBE73E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L14
M02_L16:
       mov       rdx,rax
       call      qword ptr [7FFEBE73E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L10
M02_L17:
       mov       rcx,rbx
       mov       r11,7FFEBE540A08
       call      qword ptr [r11]
M02_L18:
       test      eax,eax
       jne       near ptr M02_L11
M02_L19:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       cmp       r14,rcx
       jne       near ptr M02_L32
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       dword ptr [rbx+30],0FFFFFFFE
M02_L20:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L21:
       mov       ecx,17
       call      qword ptr [7FFEBE925B18]
       int       3
M02_L22:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFEBEF72810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L24:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M02_L27
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFEBED5D368
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L26:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L27:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L28
       jmp       short M02_L29
M02_L28:
       mov       rcx,rsi
       mov       rdx,7FFEBED5D378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L29:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M02_L30
       jmp       short M02_L31
M02_L30:
       mov       rcx,rsi
       mov       rdx,7FFEBEF72828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L31:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],r14d
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L32:
       mov       rcx,rbx
       mov       r11,7FFEBE540A10
       call      qword ptr [r11]
       jmp       near ptr M02_L20
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-30],0
       je        short M02_L34
       mov       rbx,[rbp-30]
       mov       r14,[rbx]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       cmp       r14,rcx
       jne       short M02_L33
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       dword ptr [rbx+30],0FFFFFFFE
       jmp       short M02_L34
M02_L33:
       mov       rcx,rbx
       mov       r11,7FFEBE540A10
       call      qword ptr [r11]
M02_L34:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 980
```

