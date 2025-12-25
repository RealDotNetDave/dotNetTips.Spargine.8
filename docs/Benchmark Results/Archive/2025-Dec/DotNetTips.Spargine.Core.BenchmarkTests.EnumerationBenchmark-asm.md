## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.GetAll()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; Total bytes of code 117
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
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-78],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L97
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
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L98
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
       mov       [rbp-68],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FF900927440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF9007B0A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF900927450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L56
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       [rax],rcx
       jne       near ptr M01_L56
       jmp       short M01_L09
M01_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r12d,[rcx+10]
       cmp       [r10+8],r12d
       jbe       near ptr M01_L13
       lea       edx,[r12+1]
       mov       [rcx+10],edx
       movsxd    rdx,r12d
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L09:
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L20
       cmp       edi,1
       jne       near ptr M01_L94
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L10:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       near ptr M01_L33
M01_L11:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       short M01_L12
       mov       ecx,r8d
       mov       rdi,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L69
       test      byte ptr [rdi+38],1
       jne       near ptr M01_L23
       mov       rcx,rdi
       call      qword ptr [7FF90022C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       near ptr M01_L24
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rdx,rax
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L09
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF900927468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       edi,[r13+8]
       mov       r10d,edi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      edi,edi
       jle       short M01_L18
M01_L16:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L17
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FF9001BF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L17:
       inc       r14d
       cmp       edi,r14d
       jg        short M01_L16
M01_L18:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L72
       cmp       r12d,1
       je        near ptr M01_L73
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L74
       cmp       [rdx+8],r12d
       jne       near ptr M01_L75
M01_L19:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L33
       mov       rax,[rbp-68]
       jmp       near ptr M01_L11
M01_L20:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,205EEBD11F8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L35
M01_L21:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L71
M01_L22:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L70
       mov       r13,[rcx+8]
       jmp       near ptr M01_L15
M01_L23:
       mov       ecx,[rdi+38]
M01_L24:
       mov       rdx,[rdi+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L78
       mov       r12,[rdi+10]
M01_L25:
       test      r12,r12
       je        short M01_L26
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r12],rdx
       je        short M01_L26
       xor       r12d,r12d
M01_L26:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [rdi+1C],10
       jne       short M01_L27
       mov       rcx,[rdi+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L27:
       mov       rdx,[rdi+28]
       test      rdx,rdx
       jne       short M01_L28
       mov       rcx,rdi
       call      qword ptr [7FF90022CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L28:
       mov       r14,rdx
       test      r14,r14
       je        short M01_L29
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L93
M01_L29:
       mov       byte ptr [rbp-60],0
       test      r12,r12
       je        near ptr M01_L34
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M01_L36
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M01_L36
M01_L30:
       movzx     ecx,byte ptr [r8+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,rdi
       mov       r8,r14
       mov       r9,r12
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdi,rax
       movzx     r14d,byte ptr [rbp-60]
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L37
M01_L31:
       mov       [rax+95],r14b
       mov       rdx,rdi
M01_L32:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF900024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L33:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L94
M01_L34:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       short M01_L32
M01_L35:
       mov       rcx,24684E74768
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L21
M01_L36:
       mov       rcx,r12
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       mov       r8,rax
       jmp       near ptr M01_L30
M01_L37:
       mov       rcx,r12
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L31
M01_L38:
       mov       esi,[r13+8]
       mov       r10d,esi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L41
M01_L39:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L40
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FF9001BF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L40:
       inc       r14d
       cmp       esi,r14d
       jg        short M01_L39
M01_L41:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L79
       cmp       r12d,1
       je        near ptr M01_L80
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L81
       cmp       [rdx+8],r12d
       jne       near ptr M01_L82
M01_L42:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L58
M01_L43:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L12
       mov       ecx,r8d
       mov       rdi,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L87
       test      byte ptr [rdi+38],1
       jne       near ptr M01_L62
       mov       rcx,rdi
       call      qword ptr [7FF90022C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
M01_L44:
       mov       rdx,[rdi+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L85
       mov       r12,[rdi+10]
M01_L45:
       test      r12,r12
       je        short M01_L46
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r12],rdx
       je        short M01_L46
       xor       r12d,r12d
M01_L46:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [rdi+1C],10
       jne       short M01_L47
       mov       rcx,[rdi+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L47:
       mov       rdx,[rdi+28]
       test      rdx,rdx
       jne       short M01_L48
       mov       rcx,rdi
       call      qword ptr [7FF90022CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L48:
       mov       r14,rdx
       test      r14,r14
       je        short M01_L49
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L93
M01_L49:
       mov       byte ptr [rbp-60],0
       test      r12,r12
       je        near ptr M01_L86
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M01_L63
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M01_L63
M01_L50:
       movzx     ecx,byte ptr [r8+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,rdi
       mov       r8,r14
       mov       r9,r12
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdi,rax
       movzx     r14d,byte ptr [rbp-60]
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M01_L64
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L64
M01_L51:
       mov       [rax+95],r14b
       mov       rdx,rdi
M01_L52:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF900024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L57
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
M01_L53:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx]
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L55
M01_L54:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r12d,[rcx+10]
       cmp       [r10+8],r12d
       jbe       near ptr M01_L68
       lea       edx,[r12+1]
       mov       [rcx+10],edx
       movsxd    rdx,r12d
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
       jmp       short M01_L56
M01_L55:
       mov       rcx,rsi
       mov       rdx,7FF900927468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L54
M01_L56:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       [rax],rcx
       jne       near ptr M01_L88
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        short M01_L59
       cmp       edi,1
       jne       near ptr M01_L94
       mov       rax,[rbp-68]
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L57:
       mov       rax,[rbp-68]
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jg        near ptr M01_L43
M01_L58:
       mov       rax,[rbp-68]
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L94
M01_L59:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,205EEBD11F8
       mov       r14,[rcx]
       test      r14,r14
       je        short M01_L65
M01_L60:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        short M01_L67
M01_L61:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        short M01_L66
       mov       r13,[rcx+8]
       jmp       near ptr M01_L38
M01_L62:
       mov       ecx,[rdi+38]
       jmp       near ptr M01_L44
M01_L63:
       mov       rcx,r12
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       mov       r8,rax
       jmp       near ptr M01_L50
M01_L64:
       mov       rcx,r12
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L51
M01_L65:
       mov       rcx,24684E74768
       call      qword ptr [7FF8FFF76658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M01_L60
M01_L66:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF9001BF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L38
M01_L67:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L61
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L61
M01_L68:
       mov       rdx,rax
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L56
M01_L69:
       mov       rcx,rdi
       xor       edx,edx
       mov       r8,[rdi]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L32
M01_L70:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF9001BF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L15
M01_L71:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L22
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L22
M01_L72:
       mov       rax,[rbp-68]
       mov       rcx,205F3001EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L19
M01_L73:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r12
       jmp       near ptr M01_L19
M01_L74:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L19
M01_L75:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       lea       rcx,[r13+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jle       short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       eax,r12d
M01_L77:
       mov       r8d,eax
       shl       r8,3
       call      qword ptr [7FF9000D5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r13
       jmp       near ptr M01_L19
M01_L78:
       mov       rax,[rbp-68]
       xor       r12d,r12d
       jmp       near ptr M01_L25
M01_L79:
       mov       rax,[rbp-68]
       mov       rcx,205F3001EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L42
M01_L80:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r12
       jmp       near ptr M01_L42
M01_L81:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L42
M01_L82:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       lea       rcx,[r13+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jle       short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       eax,r12d
M01_L84:
       mov       r8d,eax
       shl       r8,3
       call      qword ptr [7FF9000D5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r13
       jmp       near ptr M01_L42
M01_L85:
       xor       r12d,r12d
       jmp       near ptr M01_L45
M01_L86:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L52
M01_L87:
       mov       rcx,rdi
       xor       edx,edx
       mov       rax,[rdi]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M01_L52
M01_L88:
       mov       rcx,rax
       mov       r11,7FF8FFEE0990
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L53
       jmp       near ptr M01_L94
M01_L89:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M01_L90:
       test      r12,r12
       je        short M01_L91
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF900201300]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L91
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90057F5D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9001D5F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L91:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900477090]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L92:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90059C1B0]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9001DE508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L93:
       call      qword ptr [7FF9000243F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L94:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L95
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L96
M01_L95:
       mov       rcx,rax
       mov       r11,7FF8FFEE0998
       call      qword ptr [r11]
M01_L96:
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
M01_L97:
       mov       ecx,17
       call      qword ptr [7FF900325B18]
       int       3
M01_L98:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rcx,rsi
       mov       rdx,7FF900927480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L100:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M01_L103
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L101
       jmp       short M01_L102
M01_L101:
       mov       rcx,rsi
       mov       rdx,7FF9007B0A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L102:
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
M01_L103:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L104
       jmp       short M01_L105
M01_L104:
       mov       rcx,rsi
       mov       rdx,7FF9007B0A10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L105:
       movsxd    rdx,r15d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rcx,rsi
       mov       rdx,7FF900927498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L107:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],r15d
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M01_L109
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L108
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L109
M01_L108:
       mov       rcx,rax
       mov       r11,7FF8FFEE0998
       call      qword ptr [r11]
M01_L109:
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
; Total bytes of code 3303
```

