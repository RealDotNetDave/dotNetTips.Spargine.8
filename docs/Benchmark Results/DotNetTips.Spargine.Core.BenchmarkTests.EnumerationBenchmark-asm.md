## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.GetAll()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFF4C72DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF4C674348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF4CF5ADB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFF4CDF64F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFF4CF5ADC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L52
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L52
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
       mov       edi,[rcx+10]
       cmp       [r10+8],edi
       jbe       near ptr M01_L13
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L09:
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L25
       cmp       edi,1
       jne       near ptr M01_L94
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L10:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       near ptr M01_L55
M01_L11:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       short M01_L12
       mov       ecx,r8d
       mov       r15,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r15],rcx
       jne       near ptr M01_L93
       test      byte ptr [r15+38],1
       jne       short M01_L15
       mov       rcx,r15
       call      qword ptr [7FFF4C86C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       short M01_L16
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rdx,rax
       call      qword ptr [7FFF4C72E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L09
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFF4CF5ADD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       ecx,[r15+38]
M01_L16:
       mov       rdx,[r15+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L36
       mov       rdi,[r15+10]
M01_L17:
       test      rdi,rdi
       je        short M01_L18
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rdi],rdx
       je        short M01_L18
       xor       edi,edi
M01_L18:
       test      cl,2
       jne       near ptr M01_L88
       test      byte ptr [r15+1C],10
       jne       short M01_L19
       mov       rcx,[r15+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L90
M01_L19:
       mov       rdx,[r15+28]
       test      rdx,rdx
       jne       short M01_L20
       mov       rcx,r15
       call      qword ptr [7FFF4C86CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L20:
       mov       r12,rdx
       test      r12,r12
       je        short M01_L21
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L91
M01_L21:
       mov       byte ptr [rbp-60],0
       test      rdi,rdi
       je        near ptr M01_L61
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L62
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L62
M01_L22:
       movzx     ecx,byte ptr [rax+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r15
       mov       r8,r12
       mov       r9,rdi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r15,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L63
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L63
M01_L23:
       mov       [rax+95],r12b
       mov       rdx,r15
M01_L24:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFF4C674360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L25:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,19E4D591690
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L37
M01_L26:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L35
M01_L27:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L40
       mov       r14,[rcx+8]
M01_L28:
       mov       edi,[r14+8]
       mov       r10d,edi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L31
M01_L29:
       mov       ecx,r13d
       mov       r8,[r14+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L30
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF4C7FF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L30:
       inc       r13d
       cmp       edi,r13d
       jg        short M01_L29
M01_L31:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r15d,[rbp-48]
       test      r15d,r15d
       je        near ptr M01_L58
       cmp       r15d,1
       je        near ptr M01_L57
       test      r15d,r15d
       jl        near ptr M01_L87
       mov       r12,rdx
       test      r12,r12
       je        near ptr M01_L59
       cmp       [rdx+8],r15d
       jne       short M01_L33
M01_L32:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L55
       mov       rax,[rbp-68]
       jmp       near ptr M01_L11
M01_L33:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[r12+10]
       mov       eax,[r12+8]
       cmp       r15d,eax
       jg        near ptr M01_L60
M01_L34:
       mov       r8d,r15d
       shl       r8,3
       call      qword ptr [7FFF4C725BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,rdi
       jmp       short M01_L32
M01_L35:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
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
       jne       near ptr M01_L27
       mov       rcx,r13
       jmp       near ptr M01_L27
M01_L36:
       xor       edi,edi
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,1DEE50B45A8
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L26
M01_L38:
       mov       ecx,[r15+38]
M01_L39:
       mov       rdx,[r15+8]
       cmp       byte ptr [rdx+94],0
       jne       short M01_L41
       mov       rdi,[r15+10]
       jmp       short M01_L42
M01_L40:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFF4C7FF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M01_L28
M01_L41:
       xor       edi,edi
M01_L42:
       test      rdi,rdi
       je        short M01_L43
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rdi],rdx
       je        short M01_L43
       xor       edi,edi
M01_L43:
       test      cl,2
       jne       near ptr M01_L88
       test      byte ptr [r15+1C],10
       jne       short M01_L44
       mov       rcx,[r15+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L90
M01_L44:
       mov       rdx,[r15+28]
       test      rdx,rdx
       jne       short M01_L45
       mov       rcx,r15
       call      qword ptr [7FFF4C86CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L45:
       mov       r12,rdx
       test      r12,r12
       je        short M01_L46
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L91
M01_L46:
       mov       byte ptr [rbp-60],0
       test      rdi,rdi
       je        near ptr M01_L84
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L76
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L76
M01_L47:
       movzx     ecx,byte ptr [rax+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r15
       mov       r8,r12
       mov       r9,rdi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r15,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L77
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L77
M01_L48:
       mov       [rax+95],r12b
       mov       rdx,r15
M01_L49:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFF4C674360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L53
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
M01_L50:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx]
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L72
M01_L51:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       edi,[rcx+10]
       cmp       [r10+8],edi
       jbe       near ptr M01_L92
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L52:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L86
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L73
       cmp       edi,1
       jne       near ptr M01_L94
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L53:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       short M01_L56
M01_L54:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L12
       mov       ecx,r8d
       mov       r15,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r15],rcx
       jne       near ptr M01_L85
       test      byte ptr [r15+38],1
       jne       near ptr M01_L38
       mov       rcx,r15
       call      qword ptr [7FFF4C86C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       near ptr M01_L39
M01_L55:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L94
M01_L56:
       mov       rax,[rbp-68]
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L94
M01_L57:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r14
       jmp       near ptr M01_L32
M01_L58:
       mov       rax,[rbp-68]
       mov       rcx,19E53001EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L32
M01_L59:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L32
M01_L60:
       mov       r15d,eax
       jmp       near ptr M01_L34
M01_L61:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r15
       mov       r8,r12
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L24
M01_L62:
       mov       rcx,rdi
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L22
M01_L63:
       mov       rcx,rdi
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L23
M01_L64:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFF4C7FF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
M01_L65:
       mov       r10d,[r14+8]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r13d,r13d
       cmp       dword ptr [r14+8],0
       jle       short M01_L68
M01_L66:
       mov       ecx,r13d
       mov       r8,[r14+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L67
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF4C7FF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L67:
       inc       r13d
       cmp       [r14+8],r13d
       jg        short M01_L66
M01_L68:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r15d,[rbp-48]
       test      r15d,r15d
       je        near ptr M01_L80
       cmp       r15d,1
       je        near ptr M01_L81
       test      r15d,r15d
       jl        near ptr M01_L87
       mov       r12,rdx
       test      r12,r12
       je        near ptr M01_L82
       cmp       [rdx+8],r15d
       jne       short M01_L70
M01_L69:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L56
       mov       rax,[rbp-68]
       jmp       near ptr M01_L54
M01_L70:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[r12+10]
       mov       eax,[r12+8]
       cmp       r15d,eax
       jg        near ptr M01_L83
M01_L71:
       mov       r8d,r15d
       shl       r8,3
       call      qword ptr [7FFF4C725BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,rdi
       jmp       short M01_L69
M01_L72:
       mov       rcx,rsi
       mov       rdx,7FFF4CF5ADD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L51
M01_L73:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,19E4D591690
       mov       r14,[rcx]
       test      r14,r14
       je        short M01_L78
M01_L74:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        short M01_L79
M01_L75:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L64
       mov       r14,[rcx+8]
       jmp       near ptr M01_L65
M01_L76:
       mov       rcx,rdi
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L47
M01_L77:
       mov       rcx,rdi
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L48
M01_L78:
       mov       rcx,1DEE50B45A8
       call      qword ptr [7FFF4C5C6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M01_L74
M01_L79:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
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
       jne       short M01_L75
       mov       rcx,r13
       jmp       short M01_L75
M01_L80:
       mov       rax,[rbp-68]
       mov       rcx,19E53001EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L69
M01_L81:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r14
       jmp       near ptr M01_L69
M01_L82:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L69
M01_L83:
       mov       r15d,eax
       jmp       near ptr M01_L71
M01_L84:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r15
       mov       r8,r12
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L49
M01_L85:
       mov       rcx,r15
       xor       edx,edx
       mov       r8,[r15]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L49
M01_L86:
       mov       rcx,rax
       mov       r11,7FFF4C530A60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L50
       jmp       near ptr M01_L94
M01_L87:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF4C975B60]
       int       3
M01_L88:
       test      rdi,rdi
       je        short M01_L89
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF4C850EA0]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L89
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF4CBCC510]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF4C815F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L89:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF4CAB7870]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L90:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF4CBE49A8]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF4C81E508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L91:
       call      qword ptr [7FFF4C6743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L92:
       mov       rdx,rax
       call      qword ptr [7FFF4C72E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L52
M01_L93:
       mov       rcx,r15
       xor       edx,edx
       mov       r8,[r15]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L24
M01_L94:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L95
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L96
M01_L95:
       mov       rcx,rax
       mov       r11,7FFF4C530A68
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
       call      qword ptr [7FFF4C975B18]
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
       mov       rdx,7FFF4CF5ADF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L100:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M01_L103
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L101
       jmp       short M01_L102
M01_L101:
       mov       rcx,rsi
       mov       rdx,7FFF4CDF64F8
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
       mov       rdx,7FFF4CDF6508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L105:
       movsxd    rdx,ebx
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
       mov       rdx,7FFF4CF5AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L107:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L108
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L109
M01_L108:
       mov       rcx,rax
       mov       r11,7FFF4C530A68
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
; Total bytes of code 3262
```

