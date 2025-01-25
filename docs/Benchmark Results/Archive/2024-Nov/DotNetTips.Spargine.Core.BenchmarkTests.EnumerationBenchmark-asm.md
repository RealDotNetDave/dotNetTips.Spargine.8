## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromDisplayName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Enumeration.FromDisplayName[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]](System.String)
       mov       rdx,236A2B1BDA8
       call      qword ptr [7FFBF9CDCCC0]; DotNetTips.Spargine.Core.Enumeration.FromDisplayName[[System.__Canon, System.Private.CoreLib]](System.String)
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
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Enumeration.FromDisplayName[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L01:
       mov       rcx,rbx
       mov       rdx,7FFBF9CF0568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9537318]; System.String.Trim()
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L06
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rbp,[rdi+8]
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFBF9CD8D68
       mov       [rsi+18],rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       mov       rdx,rbp
       mov       r8,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFBF9CDCE10]; DotNetTips.Spargine.Core.Enumeration.Parse[[System.__Canon, System.Private.CoreLib]](System.String, System.Func`2<System.__Canon,Boolean>)
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFBF9CF0688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L04
M01_L07:
       mov       rcx,rbx
       mov       rdx,7FFBF9CF0728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L05
M01_L08:
       call      qword ptr [7FFBF9A8CD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFBF9A8CAC8]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,236A2B2AB58
       mov       r8,rbx
       call      qword ptr [7FFBF9726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Enumeration.FromValue[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]](Int32)
       mov       edx,1
       call      qword ptr [7FFBF9CED410]; DotNetTips.Spargine.Core.Enumeration.FromValue[[System.__Canon, System.Private.CoreLib]](Int32)
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
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Enumeration.FromValue[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L04
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       lea       rsi,[rdi+8]
       call      qword ptr [7FFBF96B4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       esi,[rsi]
       test      esi,esi
       jl        near ptr M01_L07
       mov       ecx,esi
       call      qword ptr [7FFBF96BFDF8]; System.Number.UInt32ToDecStr(UInt32)
       mov       rsi,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFBF9CE94B8
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L06
M01_L03:
       mov       rdx,rsi
       mov       r8,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFBF9CED560]; DotNetTips.Spargine.Core.Enumeration.Parse[[System.__Canon, System.Private.CoreLib]](System.String, System.Func`2<System.__Canon,Boolean>)
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFBF9D00568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFBF9D00688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFBF9D00728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L07:
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       call      qword ptr [7FFBF968F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFBF968F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L09:
       mov       r8,[rax+28]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF96BFCA8]
       mov       rsi,rax
       jmp       near ptr M01_L01
; Total bytes of code 272
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.GetAll()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__14`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
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
       call      qword ptr [7FFBF95FDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L98
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-68],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFBF9D497B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9D08188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFBF9D497C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L63
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__14`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L63
       jmp       short M01_L11
M01_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L09
M01_L08:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edi,[rcx+10]
       cmp       [rax+8],edi
       jbe       short M01_L10
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
       jmp       short M01_L11
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9D497E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L08
M01_L10:
       mov       rdx,r8
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
M01_L11:
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        short M01_L16
       cmp       edi,1
       jne       near ptr M01_L95
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L12:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       short M01_L15
M01_L13:
       mov       r14,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r14+8]
       jae       short M01_L14
       mov       ecx,edx
       mov       r14,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M01_L80
       test      byte ptr [r14+38],1
       jne       near ptr M01_L27
       mov       rcx,r14
       call      qword ptr [7FFBF97C71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       near ptr M01_L28
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L95
M01_L16:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,24C430A10B8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L30
M01_L17:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L18:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L82
       mov       r13,[rcx+8]
M01_L19:
       mov       edi,[r13+8]
       mov       r10d,edi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      edi,edi
       jle       short M01_L22
M01_L20:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L21
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9774BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L21:
       inc       r14d
       cmp       edi,r14d
       jg        short M01_L20
M01_L22:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L83
       cmp       r12d,1
       je        near ptr M01_L84
       test      r12d,r12d
       jl        near ptr M01_L90
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L85
       cmp       [rdx+8],r12d
       jne       short M01_L24
M01_L23:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L15
       mov       rax,[rbp-68]
       jmp       near ptr M01_L13
M01_L24:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jg        short M01_L29
       mov       eax,r12d
M01_L25:
       mov       r8d,eax
       shl       r8,3
       call      qword ptr [7FFBF95F5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
       jmp       short M01_L23
M01_L26:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
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
       jne       near ptr M01_L18
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L18
M01_L27:
       mov       ecx,[r14+38]
M01_L28:
       mov       rdx,[r14+8]
       cmp       byte ptr [rdx+94],0
       jne       short M01_L31
       mov       rdi,[r14+10]
       jmp       short M01_L32
M01_L29:
       jmp       short M01_L25
M01_L30:
       mov       rcx,28CD930AB58
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L17
M01_L31:
       xor       edi,edi
M01_L32:
       test      rdi,rdi
       je        short M01_L33
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rdi],rdx
       je        short M01_L33
       xor       edi,edi
M01_L33:
       test      cl,2
       jne       near ptr M01_L91
       test      byte ptr [r14+1C],10
       jne       short M01_L34
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L93
M01_L34:
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L35
       mov       rcx,r14
       call      qword ptr [7FFBF97C73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L35:
       mov       r12,rdx
       test      r12,r12
       je        short M01_L36
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L94
M01_L36:
       mov       byte ptr [rbp-60],0
       test      rdi,rdi
       je        near ptr M01_L81
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L41
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L41
M01_L37:
       movzx     ecx,byte ptr [rax+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       r8,r12
       mov       r9,rdi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r14,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M01_L43
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L43
M01_L38:
       mov       [rax+95],r12b
       mov       rdx,r14
M01_L39:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFBF9544360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L12
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L40:
       mov       ecx,[r14+38]
       jmp       near ptr M01_L47
M01_L41:
       mov       rcx,rdi
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L37
M01_L42:
       mov       eax,r12d
       jmp       near ptr M01_L49
M01_L43:
       mov       rcx,rdi
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       jmp       short M01_L38
M01_L44:
       mov       esi,[rdx+8]
       cmp       esi,r12d
       jne       short M01_L48
M01_L45:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L65
M01_L46:
       mov       r14,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r14+8]
       jae       near ptr M01_L14
       mov       ecx,edx
       mov       r14,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M01_L76
       test      byte ptr [r14+38],1
       jne       near ptr M01_L40
       mov       rcx,r14
       call      qword ptr [7FFBF97C71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
M01_L47:
       mov       rdx,[r14+8]
       cmp       byte ptr [rdx+94],0
       jne       short M01_L50
       mov       rdi,[r14+10]
       jmp       short M01_L51
M01_L48:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       add       rdi,10
       mov       rdx,rdi
       mov       eax,esi
       cmp       r12d,eax
       jle       near ptr M01_L42
M01_L49:
       mov       r8d,eax
       shl       r8,3
       call      qword ptr [7FFBF95F5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
       mov       rax,[rbp-68]
       jmp       near ptr M01_L45
M01_L50:
       xor       edi,edi
M01_L51:
       test      rdi,rdi
       je        short M01_L52
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rdi],rdx
       je        short M01_L52
       xor       edi,edi
M01_L52:
       test      cl,2
       jne       near ptr M01_L91
       test      byte ptr [r14+1C],10
       jne       short M01_L53
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L93
M01_L53:
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L54
       mov       rcx,r14
       call      qword ptr [7FFBF97C73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L54:
       mov       r12,rdx
       test      r12,r12
       je        short M01_L55
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L94
M01_L55:
       mov       byte ptr [rbp-60],0
       test      rdi,rdi
       je        near ptr M01_L88
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L74
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L74
M01_L56:
       movzx     ecx,byte ptr [rax+95]
       mov       [rbp-60],cl
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       r8,r12
       mov       r9,rdi
       xor       edx,edx
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r14,rax
       movzx     r12d,byte ptr [rbp-60]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L75
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L75
M01_L57:
       mov       [rax+95],r12b
       mov       rdx,r14
M01_L58:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FFBF9544360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L64
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
M01_L59:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx]
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L61
M01_L60:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edi,[rcx+10]
       cmp       [rax+8],edi
       jbe       short M01_L62
       lea       edx,[rdi+1]
       mov       [rcx+10],edx
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
       jmp       short M01_L63
M01_L61:
       mov       rcx,rsi
       mov       rdx,7FFBF9D497E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L60
M01_L62:
       mov       rdx,r8
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
M01_L63:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__14`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L89
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        short M01_L66
       cmp       edi,1
       jne       near ptr M01_L95
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L64:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jg        near ptr M01_L46
M01_L65:
       mov       rax,[rbp-68]
       xor       edx,edx
       mov       [rbx+10],rdx
       jmp       near ptr M01_L95
M01_L66:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,24C430A10B8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L73
M01_L67:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L79
M01_L68:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L77
       mov       r13,[rcx+8]
M01_L69:
       mov       r12d,[r13+8]
       mov       r10d,r12d
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      r12d,r12d
       jle       short M01_L72
M01_L70:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L71
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9774BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L71:
       inc       r14d
       cmp       r12d,r14d
       jg        short M01_L70
M01_L72:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L78
       cmp       r12d,1
       je        near ptr M01_L86
       test      r12d,r12d
       jl        near ptr M01_L90
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L87
       mov       rax,[rbp-68]
       jmp       near ptr M01_L44
M01_L73:
       mov       rcx,28CD930AB58
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L67
M01_L74:
       mov       rcx,rdi
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L56
M01_L75:
       mov       rcx,rdi
       call      qword ptr [7FFBF9496658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L57
M01_L76:
       mov       rcx,r14
       xor       edx,edx
       mov       r8,[r14]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L58
M01_L77:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFBF9774E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L69
M01_L78:
       mov       rcx,7FFBF9485120
       mov       edx,5B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24C4B401F40
       mov       rdx,[rcx]
       jmp       near ptr M01_L45
M01_L79:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
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
       jne       near ptr M01_L68
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L68
M01_L80:
       mov       rcx,r14
       xor       edx,edx
       mov       r8,[r14]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L39
M01_L81:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       r8,r12
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L39
M01_L82:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFBF9774E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L19
M01_L83:
       mov       rcx,7FFBF9485120
       mov       edx,5B
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24C4B401F40
       mov       rdx,[rcx]
       jmp       near ptr M01_L23
M01_L84:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r13
       jmp       near ptr M01_L23
M01_L85:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L23
M01_L86:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r13
       jmp       near ptr M01_L45
M01_L87:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       mov       rax,[rbp-68]
       jmp       near ptr M01_L45
M01_L88:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       r8,r12
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L58
M01_L89:
       mov       rcx,rax
       mov       r11,7FFBF9400968
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L59
       jmp       near ptr M01_L95
M01_L90:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFBF970ED48]
       int       3
M01_L91:
       test      rdi,rdi
       je        short M01_L92
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBF97957E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L92
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A4D500]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9736718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L92:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF99468F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L93:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A65998]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFBF977DB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L94:
       call      qword ptr [7FFBF95443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L95:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__14`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       je        short M01_L96
       mov       rcx,rax
       mov       r11,7FFBF9400970
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
       call      qword ptr [7FFBF970ED00]
       int       3
M01_L98:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rcx,rsi
       mov       rdx,7FFBF9D497F8
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
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L101
       jmp       short M01_L102
M01_L101:
       mov       rcx,rsi
       mov       rdx,7FFBF9D08188
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L104
       jmp       short M01_L105
M01_L104:
       mov       rcx,rsi
       mov       rdx,7FFBF9D08180
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rcx,rsi
       mov       rdx,7FFBF9D49810
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
       je        short M01_L108
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__14`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       je        short M01_L108
       mov       rcx,rax
       mov       r11,7FFBF9400970
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
; Total bytes of code 3245
```

