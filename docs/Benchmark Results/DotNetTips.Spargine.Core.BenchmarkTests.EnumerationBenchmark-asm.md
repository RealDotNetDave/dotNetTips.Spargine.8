## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC0421DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        near ptr M01_L96
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFC04164348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L97
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
       mov       [rbp-68],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AF60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rdx
       mov       rdx,7FFC048E5A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L56
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L56
       jmp       short M01_L09
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       esi,[rcx+10]
       cmp       [r10+8],esi
       jbe       near ptr M01_L13
       lea       edx,[rsi+1]
       mov       [rcx+10],edx
       movsxd    rdx,esi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L09:
       mov       rbx,rax
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M01_L25
       cmp       esi,1
       jne       near ptr M01_L93
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L10:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       near ptr M01_L65
M01_L11:
       mov       r12,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r12+8]
       jae       short M01_L12
       mov       ecx,edx
       mov       r12,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L66
       test      byte ptr [r12+38],1
       jne       short M01_L15
       mov       rcx,r12
       call      qword ptr [7FFC0435C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       short M01_L16
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rdx,rax
       call      qword ptr [7FFC0421E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L09
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AF88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       ecx,[r12+38]
M01_L16:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L33
       mov       rsi,[r12+10]
M01_L17:
       test      rsi,rsi
       je        short M01_L18
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rsi],rdx
       je        short M01_L18
       xor       esi,esi
M01_L18:
       test      cl,2
       jne       near ptr M01_L88
       test      byte ptr [r12+1C],10
       jne       short M01_L19
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L90
M01_L19:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L20
       mov       rcx,r12
       call      qword ptr [7FFC0435CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L20:
       mov       r13,rdx
       test      r13,r13
       je        short M01_L21
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L91
M01_L21:
       mov       byte ptr [rbp-60],0
       test      rsi,rsi
       je        near ptr M01_L59
       mov       rcx,[rsi+10]
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
       mov       rcx,r12
       mov       r8,r13
       mov       r9,rsi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r13,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L64
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L64
M01_L23:
       mov       [rax+95],r12b
       mov       rdx,r13
M01_L24:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFC04164360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L25:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,288EA2E10C0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L34
M01_L26:
       cmp       [rdi],dil
       lea       r14,[rdi+48]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M01_L32
M01_L27:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L36
       mov       rdi,[rcx+8]
M01_L28:
       mov       r14d,[rdi+8]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r14d
       xor       esi,esi
       cmp       dword ptr [rdi+8],0
       jle       short M01_L31
M01_L29:
       mov       ecx,esi
       mov       r8,[rdi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L30
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC042EF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L30:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M01_L29
M01_L31:
       mov       rdx,[rbp-58]
       mov       r13,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       jne       short M01_L35
       mov       rcx,288EFC01EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L39
M01_L32:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L27
       mov       rcx,r15
       jmp       near ptr M01_L27
M01_L33:
       xor       esi,esi
       jmp       near ptr M01_L17
M01_L34:
       mov       rcx,2C981D84558
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       near ptr M01_L26
M01_L35:
       cmp       r12d,1
       jne       short M01_L38
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,rsi
       jmp       short M01_L39
M01_L36:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFC042EF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L28
M01_L37:
       mov       ecx,[r12+38]
       jmp       near ptr M01_L45
M01_L38:
       test      r12d,r12d
       jl        near ptr M01_L87
       mov       r13,rdx
       test      r13,r13
       je        near ptr M01_L61
       cmp       [rdx+8],r12d
       jne       short M01_L40
M01_L39:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L65
       mov       rax,[rbp-68]
       jmp       near ptr M01_L11
M01_L40:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[r13+10]
       mov       eax,[r13+8]
       cmp       r12d,eax
       jg        near ptr M01_L60
M01_L41:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FFC04215BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,rsi
       jmp       short M01_L39
M01_L42:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FFC04215BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,rsi
M01_L43:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L58
M01_L44:
       mov       r12,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r12+8]
       jae       near ptr M01_L12
       mov       ecx,edx
       mov       r12,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L82
       test      byte ptr [r12+38],1
       jne       near ptr M01_L37
       mov       rcx,r12
       call      qword ptr [7FFC0435C8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
M01_L45:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L63
       mov       rsi,[r12+10]
M01_L46:
       test      rsi,rsi
       je        short M01_L47
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rsi],rdx
       je        short M01_L47
       xor       esi,esi
M01_L47:
       test      cl,2
       jne       near ptr M01_L88
       test      byte ptr [r12+1C],10
       jne       short M01_L48
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L90
M01_L48:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L49
       mov       rcx,r12
       call      qword ptr [7FFC0435CA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L49:
       mov       r13,rdx
       test      r13,r13
       je        short M01_L50
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L91
M01_L50:
       mov       byte ptr [rbp-60],0
       test      rsi,rsi
       je        near ptr M01_L85
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L80
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L80
M01_L51:
       movzx     ecx,byte ptr [rax+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,r13
       mov       r9,rsi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r13,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L81
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L81
M01_L52:
       mov       [rax+95],r12b
       mov       rdx,r13
M01_L53:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFC04164360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L57
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
M01_L54:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       je        near ptr M01_L67
M01_L55:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       esi,[rcx+10]
       cmp       [r10+8],esi
       jbe       near ptr M01_L92
       lea       edx,[rsi+1]
       mov       [rcx+10],edx
       movsxd    rdx,esi
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L56:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L86
       mov       rbx,rax
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M01_L73
       cmp       esi,1
       jne       near ptr M01_L93
       mov       rax,[rbp-68]
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L57:
       mov       rax,[rbp-68]
       mov       r8d,[rbx+20]
       inc       r8d
       mov       [rbx+20],r8d
       mov       rcx,[rbx+10]
       cmp       [rcx+8],r8d
       jg        near ptr M01_L44
M01_L58:
       mov       rax,[rbp-68]
       xor       r8d,r8d
       mov       [rbx+10],r8
       jmp       near ptr M01_L93
M01_L59:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L24
M01_L60:
       mov       r12d,eax
       jmp       near ptr M01_L41
M01_L61:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L39
M01_L62:
       mov       rcx,rsi
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L22
M01_L63:
       xor       esi,esi
       jmp       near ptr M01_L46
M01_L64:
       mov       rcx,rsi
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L23
M01_L65:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L93
M01_L66:
       mov       rcx,r12
       xor       edx,edx
       mov       r8,[r12]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L24
M01_L67:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AF88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L55
M01_L68:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFC042EF6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
M01_L69:
       mov       r14d,[rdi+8]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r14d
       xor       esi,esi
       cmp       dword ptr [rdi+8],0
       jle       short M01_L72
M01_L70:
       mov       ecx,esi
       mov       r8,[rdi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L71
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC042EF438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L71:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M01_L70
M01_L72:
       mov       rdx,[rbp-58]
       mov       r13,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       jne       short M01_L76
       mov       rcx,288EFC01EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L43
M01_L73:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,288EA2E10C0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L79
M01_L74:
       cmp       [rdi],dil
       lea       r14,[rdi+48]
       mov       rcx,[r14]
       test      rcx,rcx
       je        short M01_L77
M01_L75:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L68
       mov       rdi,[rcx+8]
       jmp       near ptr M01_L69
M01_L76:
       cmp       r12d,1
       jne       short M01_L78
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,rsi
       jmp       near ptr M01_L43
M01_L77:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       short M01_L75
       mov       rcx,r15
       jmp       short M01_L75
M01_L78:
       test      r12d,r12d
       jl        near ptr M01_L87
       mov       r13,rdx
       test      r13,r13
       je        near ptr M01_L83
       cmp       [rdx+8],r12d
       je        near ptr M01_L43
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[r13+10]
       mov       eax,[r13+8]
       cmp       r12d,eax
       jg        short M01_L84
       mov       rax,[rbp-68]
       jmp       near ptr M01_L42
M01_L79:
       mov       rcx,2C981D84558
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       near ptr M01_L74
M01_L80:
       mov       rcx,rsi
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L51
M01_L81:
       mov       rcx,rsi
       call      qword ptr [7FFC040B6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L52
M01_L82:
       mov       rcx,r12
       xor       edx,edx
       mov       rax,[r12]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L83:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L43
M01_L84:
       mov       r12d,eax
       jmp       near ptr M01_L42
M01_L85:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L86:
       mov       rcx,rax
       mov       r11,7FFC04020A60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L54
       jmp       near ptr M01_L93
M01_L87:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC04465B60]
       int       3
M01_L88:
       test      rsi,rsi
       je        short M01_L89
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFC04340EA0]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L89
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC046BC510]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC04305F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L89:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC045A7870]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L90:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC046D49A8]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC0430E508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L91:
       call      qword ptr [7FFC041643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L92:
       mov       rdx,rax
       call      qword ptr [7FFC0421E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L56
M01_L93:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L94
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L95
M01_L94:
       mov       rcx,rax
       mov       r11,7FFC04020A68
       call      qword ptr [r11]
M01_L95:
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
M01_L96:
       mov       ecx,17
       call      qword ptr [7FFC04465B18]
       int       3
M01_L97:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+88]
       test      r11,r11
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AFA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L99:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       jne       short M01_L102
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L100
       jmp       short M01_L101
M01_L100:
       mov       rcx,rdx
       mov       rdx,7FFC048E5A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L101:
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
M01_L102:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       test      rax,rax
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rcx,rdx
       mov       rdx,7FFC048E5A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L104:
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
       je        short M01_L105
       jmp       short M01_L106
M01_L105:
       mov       rcx,rdx
       mov       rdx,7FFC04A4AFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L106:
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
       je        short M01_L108
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L107
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L108
M01_L107:
       mov       rcx,rax
       mov       r11,7FFC04020A68
       call      qword ptr [r11]
M01_L108:
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
; Total bytes of code 3315
```

