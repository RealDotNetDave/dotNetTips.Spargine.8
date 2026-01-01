## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredFields()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredFields>d__1
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,20A097E4C60
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.FieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE74DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rdi
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
; Total bytes of code 131
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L57
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE694348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L58
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2CED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2CEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       jmp       short M01_L09
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       je        near ptr M01_L12
M01_L08:
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       near ptr M01_L36
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-78]
M01_L09:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredFields>d__1
       cmp       [rax],rcx
       jne       near ptr M01_L32
       mov       rbx,rax
       mov       ecx,[rbx+20]
       test      ecx,ecx
       je        near ptr M01_L18
       cmp       ecx,1
       jne       near ptr M01_L55
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       ecx,[rbx+28]
       add       ecx,1
       jo        near ptr M01_L33
       mov       [rbx+28],ecx
M01_L10:
       movsxd    rdi,dword ptr [rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L54
       cmp       qword ptr [rcx+10],0
       je        near ptr M01_L28
       mov       rax,[rbp-78]
       jmp       near ptr M01_L31
M01_L11:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L22
       mov       rcx,rdi
       jmp       near ptr M01_L22
M01_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2CF00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L13:
       mov       r14d,[r13+8]
       mov       ecx,r14d
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8
       mov       [rbp-60],r8d
       mov       [rbp-5C],ecx
       xor       esi,esi
       test      r14d,r14d
       jle       short M01_L16
M01_L14:
       mov       ecx,esi
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,3C
       cmp       edx,ecx
       jne       short M01_L15
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFEBE8A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L15:
       inc       esi
       cmp       r14d,esi
       jg        short M01_L14
M01_L16:
       mov       rsi,[rbp-70]
       mov       r14,[rbp-68]
       mov       r13d,[rbp-60]
       test      r13d,r13d
       je        near ptr M01_L48
       cmp       r13d,1
       je        near ptr M01_L49
       test      r13d,r13d
       jl        near ptr M01_L35
       mov       r12,rsi
       test      r12,r12
       je        near ptr M01_L50
       cmp       [rsi+8],r13d
       jne       near ptr M01_L51
M01_L17:
       mov       ecx,[rsi+8]
       cmp       rcx,rdi
       jg        short M01_L20
       jmp       near ptr M01_L55
M01_L18:
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M01_L37
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+28],ecx
       jmp       near ptr M01_L10
M01_L19:
       mov       r15d,[r13+8]
       mov       ecx,r15d
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-50],rdx
       mov       [rbp-48],edx
       mov       [rbp-44],ecx
       xor       r14d,r14d
       test      r15d,r15d
       jle       near ptr M01_L25
       mov       rax,[rbp-78]
       jmp       short M01_L23
M01_L20:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L46
       cmp       qword ptr [rcx+10],0
       je        near ptr M01_L27
       mov       rax,[rcx+10]
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M01_L27
M01_L21:
       cmp       [r15],r15b
       lea       r14,[r15+48]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M01_L11
M01_L22:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L39
       mov       r13,[rcx+8]
       jmp       short M01_L19
M01_L23:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,3C
       cmp       edx,ecx
       jne       short M01_L24
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFEBE8A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-78]
M01_L24:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L23
M01_L25:
       mov       r12,[rbp-58]
       mov       rsi,[rbp-50]
       mov       r15d,[rbp-48]
       test      r15d,r15d
       je        near ptr M01_L40
       cmp       r15d,1
       je        near ptr M01_L41
       test      r15d,r15d
       jl        near ptr M01_L35
       mov       rsi,r12
       test      rsi,rsi
       je        near ptr M01_L42
       cmp       [r12+8],r15d
       jne       near ptr M01_L43
M01_L26:
       lea       rcx,[rbx+8]
       mov       edx,[rbx+28]
       cmp       edx,[r12+8]
       jae       near ptr M01_L34
       mov       rdx,[r12+rdx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],1
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       near ptr M01_L21
M01_L28:
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M01_L29:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L38
M01_L30:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L47
       mov       r13,[rcx+8]
       jmp       near ptr M01_L13
M01_L31:
       mov       r8,[rcx+10]
       mov       r14,[r8]
       test      r14,r14
       je        short M01_L28
       jmp       short M01_L29
M01_L32:
       mov       rcx,rax
       mov       r11,7FFEBE5509A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L07
       jmp       near ptr M01_L55
M01_L33:
       call      CORINFO_HELP_OVERFLOW
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L35:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFEBE82ED48]
       int       3
M01_L36:
       mov       rdx,r8
       call      qword ptr [7FFEBE74E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-78]
       jmp       near ptr M01_L09
M01_L37:
       call      qword ptr [7FFEBEAE73A8]
       mov       ecx,39
       mov       rdx,7FFEBEA9A940
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE955328
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE696B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBEA9A940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE696B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEAE7198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE856670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L38:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L30
       mov       rcx,rsi
       jmp       near ptr M01_L30
M01_L39:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L19
M01_L40:
       mov       rcx,1C977801FA0
       mov       r12,[rcx]
       jmp       near ptr M01_L26
M01_L41:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rcx,r12
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L26
M01_L42:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       jmp       near ptr M01_L26
M01_L43:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       r15d,r8d
       jle       short M01_L44
       jmp       short M01_L45
M01_L44:
       mov       r8d,r15d
M01_L45:
       mov       r8d,r8d
       shl       r8,3
       call      qword ptr [7FFEBE745BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L26
M01_L46:
       mov       edx,3E
       mov       rax,[rcx]
       mov       rax,[rax+80]
       call      qword ptr [rax+28]
       mov       r12,rax
       jmp       near ptr M01_L26
M01_L47:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L13
M01_L48:
       mov       rcx,1C977801FA0
       mov       rsi,[rcx]
       jmp       near ptr M01_L17
M01_L49:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L17
M01_L50:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M01_L17
M01_L51:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       cmp       r13d,r8d
       jle       short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       r8d,r13d
M01_L53:
       mov       r8d,r8d
       shl       r8,3
       call      qword ptr [7FFEBE745BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L54:
       mov       edx,3E
       mov       r8,[rcx]
       mov       r8,[r8+80]
       call      qword ptr [r8+28]
       mov       rsi,rax
       jmp       near ptr M01_L17
M01_L55:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredFields>d__1
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M01_L68
       mov       dword ptr [rax+20],0FFFFFFFE
M01_L56:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L57:
       mov       ecx,17
       call      qword ptr [7FFEBE82ED00]
       int       3
M01_L58:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+88]
       test      r11,r11
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2CF18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L60:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       jne       short M01_L63
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L61
       jmp       short M01_L62
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L62:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L63:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       test      rax,rax
       je        short M01_L64
       jmp       short M01_L65
M01_L64:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L65:
       movsxd    rdx,r12d
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+90]
       test      r11,r11
       je        short M01_L66
       jmp       short M01_L67
M01_L66:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2CF30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L67:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],r12d
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L68:
       mov       rcx,rax
       mov       r11,7FFEBE5509B0
       call      qword ptr [r11]
       jmp       near ptr M01_L56
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-78],0
       je        short M01_L70
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredFields>d__1
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M01_L69
       mov       dword ptr [rax+20],0FFFFFFFE
       jmp       short M01_L70
M01_L69:
       mov       rcx,rax
       mov       r11,7FFEBE5509B0
       call      qword ptr [r11]
M01_L70:
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
; Total bytes of code 2270
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredMethods()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredMethods>d__2
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,2A6D2B24C60
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE74DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rdi
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
; Total bytes of code 131
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-88],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L59
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE694348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L60
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2D4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2D4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       jmp       short M01_L09
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       je        near ptr M01_L12
M01_L08:
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       near ptr M01_L50
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-78]
M01_L09:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredMethods>d__2
       cmp       [rax],rcx
       jne       near ptr M01_L36
       mov       rbx,rax
       mov       ecx,[rbx+20]
       test      ecx,ecx
       je        near ptr M01_L19
       cmp       ecx,1
       jne       near ptr M01_L57
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       ecx,[rbx+28]
       add       ecx,1
       jo        near ptr M01_L48
       mov       [rbx+28],ecx
M01_L10:
       movsxd    rdi,dword ptr [rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L39
       cmp       qword ptr [rcx+10],0
       je        near ptr M01_L31
       mov       rax,[rbp-78]
       jmp       near ptr M01_L37
M01_L11:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       rcx,r13
       jmp       near ptr M01_L24
M01_L12:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2D4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L13:
       mov       r14d,[r13+8]
       mov       edx,r14d
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       [rbp-68],rcx
       mov       [rbp-60],ecx
       mov       [rbp-5C],edx
       xor       esi,esi
       test      r14d,r14d
       jle       short M01_L16
M01_L14:
       mov       edx,esi
       mov       r15,[r13+rdx*8+10]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       edx,[r15+58]
       mov       rcx,r15
       mov       r8d,3E
       mov       r9d,3
       call      qword ptr [7FFEBE5E65B0]; System.RuntimeType.FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
       test      eax,eax
       je        short M01_L15
       lea       rcx,[rbp-70]
       mov       r8,r15
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFEBE8A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L15:
       inc       esi
       cmp       r14d,esi
       jg        short M01_L14
M01_L16:
       mov       rsi,[rbp-70]
       mov       r14,[rbp-68]
       mov       r15d,[rbp-60]
       test      r15d,r15d
       je        near ptr M01_L43
       cmp       r15d,1
       je        near ptr M01_L44
       test      r15d,r15d
       jl        near ptr M01_L49
       mov       r14,rsi
       test      r14,r14
       je        near ptr M01_L45
       cmp       [rsi+8],r15d
       je        short M01_L18
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[r14+10]
       mov       r14d,[r14+8]
       cmp       r15d,r14d
       jg        near ptr M01_L46
M01_L17:
       mov       r8d,r15d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L38
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L18:
       mov       ecx,[rsi+8]
       cmp       rcx,rdi
       jg        near ptr M01_L22
       jmp       near ptr M01_L57
M01_L19:
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M01_L47
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+28],ecx
       jmp       near ptr M01_L10
M01_L20:
       mov       r14d,[rsi+8]
       mov       edx,r14d
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],edx
       xor       edi,edi
       test      r14d,r14d
       jle       near ptr M01_L27
M01_L21:
       mov       edx,edi
       mov       r15,[rsi+rdx*8+10]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       edx,[r15+58]
       mov       rcx,r15
       mov       r8d,3E
       mov       r9d,3
       call      qword ptr [7FFEBE5E65B0]; System.RuntimeType.FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
       test      eax,eax
       je        short M01_L26
       mov       rax,[rbp-78]
       jmp       short M01_L25
M01_L22:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L51
       cmp       qword ptr [rcx+10],0
       je        near ptr M01_L30
       mov       rax,[rcx+10]
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L30
M01_L23:
       cmp       [r14],r14b
       lea       r15,[r14+38]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L11
M01_L24:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L52
       mov       rsi,[rcx+8]
       jmp       near ptr M01_L20
M01_L25:
       lea       rcx,[rbp-58]
       mov       r8,r15
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFEBE8A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L26:
       inc       edi
       cmp       r14d,edi
       jg        near ptr M01_L21
M01_L27:
       mov       r13,[rbp-58]
       mov       r12,[rbp-50]
       mov       esi,[rbp-48]
       test      esi,esi
       je        near ptr M01_L53
       cmp       esi,1
       je        near ptr M01_L54
       test      esi,esi
       jl        near ptr M01_L49
       mov       r15,r13
       test      r15,r15
       je        near ptr M01_L55
       cmp       [r13+8],esi
       je        short M01_L29
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       lea       rcx,[r13+10]
       lea       rdx,[r15+10]
       mov       r15d,[r15+8]
       cmp       esi,r15d
       jg        near ptr M01_L56
M01_L28:
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        short M01_L35
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L29:
       lea       rcx,[rbx+8]
       mov       edx,[rbx+28]
       cmp       edx,[r13+8]
       jae       near ptr M01_L40
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],1
       jmp       near ptr M01_L07
M01_L30:
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L23
M01_L31:
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M01_L32:
       cmp       [r14],r14b
       lea       r15,[r14+38]
       mov       rcx,[r15]
       test      rcx,rcx
       je        short M01_L41
M01_L33:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L42
M01_L34:
       mov       r13,[rcx+8]
       jmp       near ptr M01_L13
M01_L35:
       call      qword ptr [7FFEBE745BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L29
M01_L36:
       mov       rcx,rax
       mov       r11,7FFEBE5509B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L07
       jmp       near ptr M01_L57
M01_L37:
       mov       r8,[rcx+10]
       mov       r14,[r8]
       test      r14,r14
       je        short M01_L31
       jmp       short M01_L32
M01_L38:
       call      qword ptr [7FFEBE745BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L39:
       mov       edx,3E
       mov       r8,[rcx]
       mov       r8,[r8+90]
       call      qword ptr [r8+8]
       mov       rsi,rax
       jmp       near ptr M01_L18
M01_L40:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L41:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L33
       mov       rcx,rsi
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       jne       near ptr M01_L34
M01_L42:
       xor       r8d,r8d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L13
M01_L43:
       mov       rcx,7FFEBE5D5120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2664CC03BA8
       mov       rsi,[rcx]
       jmp       near ptr M01_L18
M01_L44:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L18
M01_L45:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M01_L18
M01_L46:
       mov       r15d,r14d
       jmp       near ptr M01_L17
M01_L47:
       call      qword ptr [7FFEBEAE73A8]
       mov       ecx,39
       mov       rdx,7FFEBEA9B348
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE9558F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE696B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEBEA9B348
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE696B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEAE7198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE856670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L48:
       call      CORINFO_HELP_OVERFLOW
M01_L49:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFEBE82ED48]
       int       3
M01_L50:
       mov       rdx,r8
       call      qword ptr [7FFEBE74E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-78]
       jmp       near ptr M01_L09
M01_L51:
       mov       edx,3E
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L29
M01_L52:
       xor       r8d,r8d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M01_L20
M01_L53:
       mov       rcx,7FFEBE5D5120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2664CC03BA8
       mov       r13,[rcx]
       jmp       near ptr M01_L29
M01_L54:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,r12
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L29
M01_L55:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       jmp       near ptr M01_L29
M01_L56:
       mov       esi,r15d
       jmp       near ptr M01_L28
M01_L57:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredMethods>d__2
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M01_L70
       mov       dword ptr [rax+20],0FFFFFFFE
M01_L58:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L59:
       mov       ecx,17
       call      qword ptr [7FFEBE82ED00]
       int       3
M01_L60:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+88]
       test      r11,r11
       je        short M01_L61
       jmp       short M01_L62
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2D4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L62:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       jne       short M01_L65
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L63
       jmp       short M01_L64
M01_L63:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L64:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L65:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       test      rax,rax
       je        short M01_L66
       jmp       short M01_L67
M01_L66:
       mov       rcx,rdx
       mov       rdx,7FFEBEDC0E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L67:
       movsxd    rdx,r12d
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+90]
       test      r11,r11
       je        short M01_L68
       jmp       short M01_L69
M01_L68:
       mov       rcx,rdx
       mov       rdx,7FFEBEF2D510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L69:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],r12d
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L70:
       mov       rcx,rax
       mov       r11,7FFEBE5509B8
       call      qword ptr [r11]
       jmp       near ptr M01_L58
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M01_L72
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredMethods>d__2
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M01_L71
       mov       dword ptr [rax+20],0FFFFFFFE
       jmp       short M01_L72
M01_L71:
       mov       rcx,rax
       mov       r11,7FFEBE5509B8
       call      qword ptr [r11]
M01_L72:
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
; Total bytes of code 2390
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllFields()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllFields>d__3
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,21CB6F24C60
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.FieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE76DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rdi
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
; Total bytes of code 131
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
       je        near ptr M01_L11
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBEF4DDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE6B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L12
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBED8FA98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBEF4DE08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-30],rbx
       mov       rcx,rbx
       mov       r11,7FFEBE570A28
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L10
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r14,[rcx+80]
       test      r14,r14
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBEF4DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L07:
       mov       r11,r14
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L08
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L09
M01_L08:
       mov       rdx,r8
       call      qword ptr [7FFEBE76E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L09:
       mov       rcx,rbx
       mov       r11,7FFEBE570A28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFEBE570A30
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L11:
       mov       ecx,17
       call      qword ptr [7FFEBE84ED00]
       int       3
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFEBEF4DE38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M01_L17
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBED8FA98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
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
M01_L17:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBED8FAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L19:
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
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFEBEF4DE50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
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
       je        short M01_L22
       mov       rcx,[rbp-30]
       mov       r11,7FFEBE570A30
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 728
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllMethods()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllMethods>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,2373BF54C60
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE75DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rdi
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
; Total bytes of code 131
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
       je        near ptr M01_L11
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFEBEF3D7A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE6A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L12
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBED6CC98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3D7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-30],rbx
       mov       rcx,rbx
       mov       r11,7FFEBE560A20
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L10
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r14,[rcx+80]
       test      r14,r14
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3D7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L07:
       mov       r11,r14
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L08
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L09
M01_L08:
       mov       rdx,r8
       call      qword ptr [7FFEBE75E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L09:
       mov       rcx,rbx
       mov       r11,7FFEBE560A20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFEBE560A28
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L11:
       mov       ecx,17
       call      qword ptr [7FFEBE83ED00]
       int       3
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3D7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M01_L17
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBED6CC98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
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
M01_L17:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBED6CCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L19:
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
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3D800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
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
       je        short M01_L22
       mov       rcx,[rbp-30]
       mov       r11,7FFEBE560A28
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 728
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllProperties()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllProperties>d__6
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,21C91034C60
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.PropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE75DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+28],rdi
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
; Total bytes of code 131
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
       je        near ptr M01_L12
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEBE6A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L13
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-30],rbx
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFEBEF3EE30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBEDD0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3EE40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,rbx
       mov       r11,7FFEBE560AB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L11
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r14,[rcx+80]
       test      r14,r14
       je        short M01_L08
M01_L07:
       mov       r11,r14
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L09
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L10
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3EE58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
       jmp       short M01_L07
M01_L09:
       mov       rdx,r8
       call      qword ptr [7FFEBE75E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFEBE560AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
M01_L11:
       mov       rcx,rbx
       mov       r11,7FFEBE560AC0
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L12:
       mov       ecx,17
       call      qword ptr [7FFEBE83ED00]
       int       3
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3EE70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M01_L18
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBEDD0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L17:
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
M01_L18:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,7FFEBEDD0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L20:
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
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,rsi
       mov       rdx,7FFEBEF3EE88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L22:
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
       je        short M01_L23
       mov       rcx,[rbp-30]
       mov       r11,7FFEBE560AC0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 730
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeOfType()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rcx,2C07AFD2F98
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5DA5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L08
       mov       rcx,2C07AFD2F98
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       jne       near ptr M00_L07
       mov       rcx,2C07AFD2F98
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5DA5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L07
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],3
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       rcx,2C07AFD2F98
       mov       rdx,2C07AFE4CD8
       mov       r8d,0FFFFFFFF
       mov       r9d,1C
       call      qword ptr [7FFEBE5E6838]; System.RuntimeType.GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
       test      rax,rax
       je        near ptr M00_L06
       mov       rcx,rax
       mov       rdx,2C07AFDE7C0
       mov       r8d,1
       call      qword ptr [7FFEBE8A4168]; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       test      rax,rax
       je        short M00_L00
       cmp       dword ptr [rax+8],0
       jne       short M00_L03
M00_L00:
       xor       edx,edx
M00_L01:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L06
       mov       rax,offset MT_System.Runtime.CompilerServices.CompilerGeneratedAttribute
       cmp       [rcx],rax
       jne       short M00_L02
       mov       esi,3
       jmp       short M00_L05
M00_L02:
       mov       rcx,rax
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       je        short M00_L04
       call      qword ptr [7FFEBE82F1C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,rcx
       jmp       short M00_L01
M00_L05:
       mov       [rbp-18],esi
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rbp-18]
       call      qword ptr [7FFEBEF55710]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeOfType, DotNetTips.Spargine.8.Extensions]](DotNetTips.Spargine.Extensions.TypeOfType ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       esi,2
       jmp       short M00_L05
M00_L07:
       xor       esi,esi
       jmp       short M00_L05
M00_L08:
       mov       esi,1
       jmp       short M00_L05
; Total bytes of code 315
```
```assembly
; System.RuntimeType.IsValueTypeImpl()
       sub       rsp,28
       mov       rax,[rcx+18]
       mov       rdx,rax
       test      al,2
       jne       short M01_L00
       mov       eax,[rdx]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       rdx,2C07AFD5F60
       call      qword ptr [7FFEBE5DA7A8]; System.RuntimeType.IsSubclassOf(System.Type)
       nop
       add       rsp,28
       ret
; Total bytes of code 60
```
```assembly
; System.RuntimeType.GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebx,r8d
       mov       esi,r9d
       mov       r14d,[rsp+0D8]
       mov       rbp,[rsp+0E0]
       mov       r15,rdx
       test      r15,r15
       je        near ptr M02_L29
       test      sil,1
       jne       near ptr M02_L14
       mov       r13d,1
M02_L00:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M02_L13
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M02_L13
M02_L01:
       cmp       [r12],r12b
       lea       rdi,[r12+38]
       mov       rax,[rdi]
       test      rax,rax
       jne       short M02_L02
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+30]
       mov       rcx,rdi
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       cmove     rax,r12
M02_L02:
       mov       rdi,rax
       cmp       [rdi],dil
       cmp       r13d,1
       jne       near ptr M02_L30
       lea       rcx,[rdi+20]
       mov       r8,r15
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeMethodInfo[]>
       call      qword ptr [7FFEBE87CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       je        short M02_L04
M02_L03:
       mov       r13,rax
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       jmp       short M02_L03
M02_L05:
       mov       edi,[r13+8]
       mov       ecx,edi
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],eax
       mov       [rsp+4C],ecx
       xor       r15d,r15d
       test      edi,edi
       jle       short M02_L09
M02_L06:
       mov       ecx,r15d
       mov       r12,[r13+rcx*8+10]
       cmp       ebx,0FFFFFFFF
       je        short M02_L07
       mov       rcx,[r12+50]
       call      00007FFF1E21D060
       cmp       eax,ebx
       jne       short M02_L08
M02_L07:
       mov       [rsp+20],rbp
       mov       edx,[r12+58]
       mov       rcx,r12
       mov       r8d,esi
       mov       r9d,r14d
       call      qword ptr [7FFEBE5E65B0]; System.RuntimeType.FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
       test      eax,eax
       je        short M02_L08
       lea       rcx,[rsp+38]
       mov       r8,r12
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFEBE8A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L08:
       inc       r15d
       cmp       edi,r15d
       jg        short M02_L06
M02_L09:
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rax,[rsp+48]
       mov       [rsp+60],rax
       cmp       dword ptr [rsp+60],0
       je        near ptr M02_L19
       test      rbp,rbp
       jne       near ptr M02_L20
M02_L10:
       cmp       qword ptr [rsp+50],0
       je        short M02_L12
       mov       rax,[rsp+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L31
       mov       rax,[rsp+50]
       mov       rdi,[rax+10]
M02_L11:
       cmp       dword ptr [rsp+60],1
       jne       near ptr M02_L21
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       rdi,[rsp+58]
       jmp       short M02_L11
M02_L13:
       mov       rcx,rdi
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M02_L01
M02_L14:
       mov       rcx,27FE9000590
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFEBE7DC1C8]
       mov       r15,rax
       mov       r13d,2
       jmp       near ptr M02_L00
M02_L15:
       lea       rcx,[rdi+28]
       mov       r8,r15
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeMethodInfo[]>
       call      qword ptr [7FFEBE87CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L16
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,2
       xor       r9d,r9d
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L16:
       jmp       near ptr M02_L05
M02_L17:
       cmp       byte ptr [rdi+18],0
       je        short M02_L18
       mov       r13,[rdi+8]
       jmp       near ptr M02_L05
M02_L18:
       mov       rcx,rdi
       mov       r8d,r13d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFEBE8A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M02_L05
M02_L19:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L20:
       cmp       dword ptr [rbp+8],0
       jne       near ptr M02_L27
       jmp       near ptr M02_L10
M02_L21:
       test      rbp,rbp
       jne       near ptr M02_L27
       mov       esi,1
       jmp       short M02_L26
M02_L22:
       cmp       qword ptr [rsp+50],0
       jne       short M02_L23
       mov       rcx,[rsp+58]
       jmp       short M02_L24
M02_L23:
       mov       rcx,[rsp+50]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       rcx,[rsp+50]
       mov       edx,esi
       mov       rcx,[rcx+rdx*8+10]
M02_L24:
       mov       rdx,rdi
       call      qword ptr [7FFEBECA4C90]
       test      eax,eax
       jne       short M02_L25
       mov       rcx,rdi
       call      qword ptr [7FFEBE82F1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L25:
       inc       esi
M02_L26:
       cmp       esi,[rsp+60]
       jl        short M02_L22
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFEBE8A4B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       edx,[rsp+60]
       call      qword ptr [7FFEBECA4CC0]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      qword ptr [7FFEBE694360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L27:
       mov       rbx,[rsp+0D0]
       test      rbx,rbx
       jne       short M02_L28
       call      qword ptr [7FFEBE5E5FC8]; System.Type.get_DefaultBinder()
       mov       rbx,rax
M02_L28:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFEBE8A4B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r8,rax
       mov       rdi,[rsp+0E8]
       mov       [rsp+20],rdi
       mov       edx,esi
       mov       rcx,rbx
       mov       r9,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      qword ptr [7FFEBE694360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L29:
       xor       r13d,r13d
       jmp       near ptr M02_L00
M02_L30:
       cmp       r13d,2
       je        near ptr M02_L15
       jmp       near ptr M02_L17
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1000
```
```assembly
; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M03_L13
       test      rbx,rbx
       je        near ptr M03_L17
       mov       rbp,[rbx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       rbp,rcx
       jne       short M03_L02
       mov       r14,2C07AFD2DB8
       mov       rcx,rbx
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M03_L01
M03_L00:
       cmp       rax,r14
       je        short M03_L03
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M03_L00
M03_L01:
       mov       rcx,2C07AFD2D10
       cmp       r14,rcx
       je        near ptr M03_L14
       jmp       near ptr M03_L15
M03_L02:
       mov       rcx,rbx
       mov       rdx,2C07AFD2DB8
       mov       rax,[rbp+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M03_L15
M03_L03:
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rsi],rcx
       jne       near ptr M03_L16
       mov       ecx,8
M03_L04:
       cmp       ecx,2
       je        near ptr M03_L12
       cmp       ecx,10
       je        near ptr M03_L09
       mov       r8,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rsi],r8
       jne       near ptr M03_L20
       mov       r8,offset MT_System.RuntimeType
       cmp       rbp,r8
       jne       near ptr M03_L18
       mov       rdx,rbx
M03_L05:
       test      rdx,rdx
       je        near ptr M03_L19
       mov       r8,offset MT_System.RuntimeType
       cmp       [rdx],r8
       jne       near ptr M03_L19
       movzx     r8d,dil
       mov       rcx,rsi
       call      qword ptr [7FFEBE8A6100]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeMethodInfo, System.RuntimeType, Boolean)
M03_L06:
       mov       r8,rax
       test      r8,r8
       je        short M03_L07
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M03_L07
       mov       rdx,rax
       call      qword ptr [7FFEBE694390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M03_L07:
       mov       rax,r8
M03_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L09:
       mov       rcx,rsi
       mov       rdx,offset MT_System.Reflection.PropertyInfo
       cmp       [rcx],rdx
       jne       short M03_L11
M03_L10:
       movzx     r8d,dil
       mov       rdx,rbx
       call      qword ptr [7FFEBE8A4000]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       short M03_L08
M03_L11:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
       jmp       short M03_L10
M03_L12:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFEBE6943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       movzx     r8d,dil
       mov       rdx,rbx
       call      qword ptr [7FFEBE8A4048]
       jmp       short M03_L08
M03_L13:
       mov       ecx,0D9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE8566E8]
       int       3
M03_L14:
       mov       rcx,2C07AFD2D10
       cmp       rbx,rcx
       jne       near ptr M03_L03
M03_L15:
       mov       rcx,2C07AFD2DB8
       cmp       rbx,rcx
       je        near ptr M03_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBB70D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE69F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L16:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       ecx,eax
       jmp       near ptr M03_L04
M03_L17:
       mov       ecx,0E9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE8566E8]
       int       3
M03_L18:
       mov       rcx,rbx
       mov       rax,[rbp+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M03_L05
M03_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFEBEBB5A40]
       mov       rbx,rax
       mov       ecx,0E9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEBE69F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       movzx     r8d,dil
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L06
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M04_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M04_L03
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       jmp       qword ptr [7FFEBE6943A8]
M04_L03:
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       jne       short M04_L00
       jmp       short M04_L02
; Total bytes of code 71
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeOfType, DotNetTips.Spargine.8.Extensions]](DotNetTips.Spargine.Extensions.TypeOfType ByRef)
       ret
; Total bytes of code 1
```
**Extern method**
System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)

