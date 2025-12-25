## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        near ptr M01_L98
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
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L99
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
       mov       rdx,7FFE62537528
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62537538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L40
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       [rax],rcx
       jne       near ptr M01_L40
       jmp       short M01_L09
M01_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        near ptr M01_L13
M01_L08:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r14d,[rcx+10]
       cmp       [r10+8],r14d
       jbe       near ptr M01_L19
       lea       edx,[r14+1]
       mov       [rcx+10],edx
       movsxd    rdx,r14d
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L09:
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L22
       cmp       edi,1
       jne       near ptr M01_L95
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L10:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       near ptr M01_L35
M01_L11:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       short M01_L12
       mov       ecx,r8d
       mov       r12,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L44
       test      byte ptr [r12+38],1
       jne       near ptr M01_L25
       mov       rcx,r12
       call      qword ptr [7FFE61EF71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       near ptr M01_L26
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE62537550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L14:
       mov       edi,[r13+8]
       mov       r10d,edi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      edi,edi
       jle       short M01_L17
M01_L15:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L16
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFE61EB4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L16:
       inc       r14d
       cmp       edi,r14d
       jg        short M01_L15
M01_L17:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L47
       cmp       r12d,1
       je        near ptr M01_L48
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L49
       cmp       [rdx+8],r12d
       jne       short M01_L20
M01_L18:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L35
       mov       rax,[rbp-68]
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,rax
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L09
M01_L20:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jg        near ptr M01_L50
M01_L21:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FFE61CE5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
       jmp       short M01_L18
M01_L22:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,269A4831128
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L37
M01_L23:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L46
M01_L24:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L45
       mov       r13,[rcx+8]
       jmp       near ptr M01_L14
M01_L25:
       mov       ecx,[r12+38]
M01_L26:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L51
       mov       r14,[r12+10]
M01_L27:
       test      r14,r14
       je        short M01_L28
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r14],rdx
       je        short M01_L28
       xor       r14d,r14d
M01_L28:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [r12+1C],10
       jne       short M01_L29
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L29:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L30
       mov       rcx,r12
       call      qword ptr [7FFE61EF73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L30:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L31
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M01_L93
M01_L31:
       mov       byte ptr [rbp-60],0
       test      r14,r14
       je        near ptr M01_L36
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L38
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M01_L38
M01_L32:
       movzx     ecx,byte ptr [r8+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       mov       r9,r14
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdi,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L39
M01_L33:
       mov       [rax+95],r12b
       mov       rdx,rdi
M01_L34:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFE61C34360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L35:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L95
M01_L36:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       short M01_L34
M01_L37:
       mov       rcx,2AA3C374768
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L23
M01_L38:
       mov       rcx,r14
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       mov       r8,rax
       jmp       near ptr M01_L32
M01_L39:
       mov       rcx,r14
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L33
M01_L40:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       [rax],rcx
       jne       near ptr M01_L88
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L63
       cmp       edi,1
       jne       near ptr M01_L95
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L41:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       short M01_L43
M01_L42:
       mov       rdx,[rbx+10]
       mov       r8d,[rbx+20]
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L12
       mov       ecx,r8d
       mov       r12,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L87
       test      byte ptr [r12+38],1
       jne       near ptr M01_L66
       mov       rcx,r12
       call      qword ptr [7FFE61EF71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       near ptr M01_L67
M01_L43:
       mov       rax,[rbp-68]
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L95
M01_L44:
       mov       rcx,r12
       xor       edx,edx
       mov       r8,[r12]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L34
M01_L45:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE61EB4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L14
M01_L46:
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
       jne       near ptr M01_L24
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L24
M01_L47:
       mov       rax,[rbp-68]
       mov       rcx,269AE401EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L18
M01_L48:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r12
       jmp       near ptr M01_L18
M01_L49:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L18
M01_L50:
       mov       r12d,eax
       jmp       near ptr M01_L21
M01_L51:
       mov       rax,[rbp-68]
       xor       r14d,r14d
       jmp       near ptr M01_L27
M01_L52:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx]
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L56
M01_L53:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       r14d,[rcx+10]
       cmp       [r10+8],r14d
       jbe       near ptr M01_L94
       lea       edx,[r14+1]
       mov       [rcx+10],edx
       movsxd    rdx,r14d
       mov       rcx,r10
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
       jmp       near ptr M01_L40
M01_L54:
       mov       r10d,[r13+8]
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-50],rdx
       mov       [rbp-48],edx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       cmp       dword ptr [r13+8],0
       jle       short M01_L59
M01_L55:
       mov       edx,r14d
       mov       r8,[r13+rdx*8+10]
       mov       edx,[r8+18]
       mov       ecx,edx
       and       ecx,18
       cmp       ecx,edx
       jne       short M01_L58
       mov       rax,[rbp-68]
       jmp       short M01_L57
M01_L56:
       mov       rcx,rsi
       mov       rdx,7FFE62537550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L53
M01_L57:
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFE61EB4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L58:
       inc       r14d
       cmp       [r13+8],r14d
       jg        short M01_L55
M01_L59:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L82
       cmp       r12d,1
       je        near ptr M01_L83
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L84
       cmp       [rdx+8],r12d
       jne       short M01_L61
M01_L60:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L43
       mov       rax,[rbp-68]
       jmp       near ptr M01_L42
M01_L61:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jg        near ptr M01_L85
M01_L62:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FFE61CE5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
       jmp       short M01_L60
M01_L63:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,269A4831128
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L78
M01_L64:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L81
M01_L65:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L79
       mov       r13,[rcx+8]
       jmp       near ptr M01_L54
M01_L66:
       mov       ecx,[r12+38]
M01_L67:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L86
       mov       r14,[r12+10]
M01_L68:
       test      r14,r14
       je        short M01_L69
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r14],rdx
       je        short M01_L69
       xor       r14d,r14d
M01_L69:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [r12+1C],10
       jne       short M01_L70
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L70:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L71
       mov       rcx,r12
       call      qword ptr [7FFE61EF73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L71:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L72
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M01_L93
M01_L72:
       mov       byte ptr [rbp-60],0
       test      r14,r14
       je        near ptr M01_L80
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L76
       mov       r8,[rcx]
       test      r8,r8
       je        short M01_L76
M01_L73:
       movzx     ecx,byte ptr [r8+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       mov       r9,r14
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdi,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L77
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L77
M01_L74:
       mov       [rax+95],r12b
       mov       rdx,rdi
M01_L75:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFE61C34360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L41
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L52
M01_L76:
       mov       rcx,r14
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       mov       r8,rax
       jmp       near ptr M01_L73
M01_L77:
       mov       rcx,r14
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       jmp       short M01_L74
M01_L78:
       mov       rcx,2AA3C374768
       call      qword ptr [7FFE61B86658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L64
M01_L79:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE61EB4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L54
M01_L80:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L75
M01_L81:
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
       jne       near ptr M01_L65
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L65
M01_L82:
       mov       rax,[rbp-68]
       mov       rcx,269AE401EE0
       mov       rdx,[rcx]
       jmp       near ptr M01_L60
M01_L83:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r12
       jmp       near ptr M01_L60
M01_L84:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L60
M01_L85:
       mov       r12d,eax
       jmp       near ptr M01_L62
M01_L86:
       mov       rax,[rbp-68]
       xor       r14d,r14d
       jmp       near ptr M01_L68
M01_L87:
       mov       rcx,r12
       xor       edx,edx
       mov       r8,[r12]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L75
M01_L88:
       mov       rcx,rax
       mov       r11,7FFE61AF09E8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L52
       jmp       near ptr M01_L95
M01_L89:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE61E3ED48]
       int       3
M01_L90:
       test      r14,r14
       je        short M01_L91
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE61EC6CF0]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L91
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE621A4D08]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61E66718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L91:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE62077EB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L92:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE621AD1A0]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE61EBDB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L93:
       call      qword ptr [7FFE61C343F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L94:
       mov       rdx,rax
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L40
M01_L95:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L96
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L97
M01_L96:
       mov       rcx,rax
       mov       r11,7FFE61AF09F0
       call      qword ptr [r11]
M01_L97:
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
M01_L98:
       mov       ecx,17
       call      qword ptr [7FFE61E3ED00]
       int       3
M01_L99:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L100
       jmp       short M01_L101
M01_L100:
       mov       rcx,rsi
       mov       rdx,7FFE62537568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L101:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M01_L104
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L102
       jmp       short M01_L103
M01_L102:
       mov       rcx,rsi
       mov       rdx,7FFE623C0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L103:
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
M01_L104:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L105
       jmp       short M01_L106
M01_L105:
       mov       rcx,rsi
       mov       rdx,7FFE623C0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L106:
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
       je        short M01_L107
       jmp       short M01_L108
M01_L107:
       mov       rcx,rsi
       mov       rdx,7FFE62537580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L108:
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
       je        short M01_L110
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       jne       short M01_L109
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],0FFFFFFFE
       jmp       short M01_L110
M01_L109:
       mov       rcx,rax
       mov       r11,7FFE61AF09F0
       call      qword ptr [r11]
M01_L110:
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
; Total bytes of code 3343
```

