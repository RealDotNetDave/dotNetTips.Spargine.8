## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromDisplayName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Enumeration.FromDisplayName[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]](System.String)
       mov       rdx,26353DC3B88
       call      qword ptr [7FF94D40CA20]; DotNetTips.Spargine.Core.Enumeration.FromDisplayName[[System.__Canon, System.Private.CoreLib]](System.String)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
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
       mov       rdx,7FF94D3E7618
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF94CB67318]; System.String.Trim()
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
       lea       rbp,[rdi+8]
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D408AC8
       mov       [rsi+18],rcx
       mov       [rsp+28],rsi
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       lea       r8,[rsp+28]
       mov       rdx,rbp
       call      qword ptr [7FF94D40CB70]; DotNetTips.Spargine.Core.Enumeration.Parse[[System.__Canon, System.Private.CoreLib]](System.String ByRef, System.Func`2<System.__Canon,Boolean> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF94D3E7738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L04
M01_L07:
       mov       rcx,rbx
       mov       rdx,7FF94D3E77D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L05
M01_L08:
       call      qword ptr [7FF94D00FB70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FF94D00F8B8]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26353DC3BA0
       mov       r8,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 356
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Enumeration.FromValue[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]](Int32)
       mov       edx,1
       call      qword ptr [7FF94D41C3C0]; DotNetTips.Spargine.Core.Enumeration.FromValue[[System.__Canon, System.Private.CoreLib]](Int32)
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
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       lea       rsi,[rdi+8]
       call      qword ptr [7FF94CD14180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       esi,[rsi]
       test      esi,esi
       jl        near ptr M01_L07
       mov       ecx,esi
       call      qword ptr [7FF94CD1FDF8]; System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       [rsp+30],rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D418468
       mov       [rsi+18],rcx
       mov       [rsp+28],rsi
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L06
M01_L03:
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      qword ptr [7FF94D41C510]; DotNetTips.Spargine.Core.Enumeration.Parse[[System.__Canon, System.Private.CoreLib]](System.String ByRef, System.Func`2<System.__Canon,Boolean> ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF94D3F76A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF94D3F77C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FF94D3F7868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L07:
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       call      qword ptr [7FF94CCEF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FF94CCEF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L09:
       mov       r8,[rax+28]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF94CD1FCA8]
       jmp       near ptr M01_L01
; Total bytes of code 296
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L97
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
       mov       rdx,7FF94D4679A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF94D2E2750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF94D4679B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       test      rax,rax
       je        near ptr M01_L59
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L59
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
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       r14d,[rcx+10]
       cmp       [rax+8],r14d
       jbe       near ptr M01_L16
       lea       edx,[r14+1]
       mov       [rcx+10],edx
       movsxd    rdx,r14d
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
M01_L09:
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        near ptr M01_L18
       cmp       edi,1
       jne       near ptr M01_L94
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L10:
       mov       ecx,[rbx+20]
       inc       ecx
       mov       [rbx+20],ecx
       mov       rdx,[rbx+10]
       cmp       [rdx+8],ecx
       jle       near ptr M01_L70
M01_L11:
       mov       r12,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r12+8]
       jae       short M01_L12
       mov       ecx,edx
       mov       r12,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L74
       test      byte ptr [r12+38],1
       jne       short M01_L14
       mov       rcx,r12
       call      qword ptr [7FF94CE371F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
       jmp       short M01_L15
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L13:
       mov       rcx,rsi
       mov       rdx,offset System.Enum.ToString[[System.UInt32, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L14:
       mov       ecx,[r12+38]
M01_L15:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       short M01_L17
       mov       r14,[r12+10]
       jmp       near ptr M01_L30
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
       jmp       near ptr M01_L09
M01_L17:
       xor       r14d,r14d
       jmp       near ptr M01_L30
M01_L18:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,23648D41128
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L29
M01_L19:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L20:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L76
       mov       r13,[rcx+8]
M01_L21:
       mov       edi,[r13+8]
       mov       r10d,edi
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      edi,edi
       jle       short M01_L24
M01_L22:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L23
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF94CDE4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L23:
       inc       r14d
       cmp       edi,r14d
       jg        short M01_L22
M01_L24:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L77
       cmp       r12d,1
       je        near ptr M01_L78
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L79
       cmp       [rdx+8],r12d
       jne       short M01_L27
M01_L25:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L70
       mov       rax,[rbp-68]
       jmp       near ptr M01_L11
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
       jne       near ptr M01_L20
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L20
M01_L27:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       eax,[rdi+8]
       cmp       r12d,eax
       jg        near ptr M01_L80
M01_L28:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FF94CC35BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
       jmp       near ptr M01_L25
M01_L29:
       mov       rcx,276DEFD3B38
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L19
M01_L30:
       test      r14,r14
       je        short M01_L31
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r14],rdx
       je        short M01_L31
       xor       r14d,r14d
M01_L31:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [r12+1C],10
       jne       short M01_L32
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L32:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L33
       mov       rcx,r12
       call      qword ptr [7FF94CE373C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L33:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L34
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M01_L93
M01_L34:
       mov       byte ptr [rbp-60],0
       test      r14,r14
       je        near ptr M01_L75
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L39
M01_L35:
       movzx     ecx,byte ptr [rax+95]
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
       je        short M01_L41
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L41
M01_L36:
       mov       [rax+95],r12b
       mov       rdx,rdi
M01_L37:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF94CB84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rdx,rax
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       jmp       near ptr M01_L07
M01_L38:
       mov       ecx,[r12+38]
       jmp       near ptr M01_L45
M01_L39:
       mov       rcx,r14
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L35
M01_L40:
       jmp       short M01_L42
M01_L41:
       mov       rcx,r14
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       jmp       short M01_L36
M01_L42:
       mov       r8d,r12d
       shl       r8,3
       call      qword ptr [7FF94CC35BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r14
M01_L43:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       ecx,[rbx+20]
       mov       rax,[rbx+10]
       cmp       ecx,[rax+8]
       jge       near ptr M01_L61
M01_L44:
       mov       r12,[rbx+10]
       mov       edx,[rbx+20]
       cmp       edx,[r12+8]
       jae       near ptr M01_L12
       mov       ecx,edx
       mov       r12,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r12],rcx
       jne       near ptr M01_L87
       test      byte ptr [r12+38],1
       jne       near ptr M01_L38
       mov       rcx,r12
       call      qword ptr [7FF94CE371F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       mov       ecx,eax
M01_L45:
       mov       rdx,[r12+8]
       cmp       byte ptr [rdx+94],0
       jne       near ptr M01_L57
       mov       r14,[r12+10]
M01_L46:
       test      r14,r14
       je        short M01_L47
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r14],rdx
       je        short M01_L47
       xor       r14d,r14d
M01_L47:
       test      cl,2
       jne       near ptr M01_L90
       test      byte ptr [r12+1C],10
       jne       short M01_L48
       mov       rcx,[r12+10]
       cmp       [rcx],cl
       xor       edx,edx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M01_L92
M01_L48:
       mov       rdx,[r12+28]
       test      rdx,rdx
       jne       short M01_L49
       mov       rcx,r12
       call      qword ptr [7FF94CE373C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L49:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L50
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M01_L93
M01_L50:
       mov       byte ptr [rbp-60],0
       test      r14,r14
       je        near ptr M01_L84
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L85
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L85
M01_L51:
       movzx     ecx,byte ptr [rax+95]
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
       je        near ptr M01_L86
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L86
M01_L52:
       mov       [rax+95],r12b
       mov       rdx,rdi
M01_L53:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF94CB84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L60
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
M01_L54:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx]
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L56
M01_L55:
       mov       rcx,[rbp-68]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       r14d,[rcx+10]
       cmp       [rax+8],r14d
       jbe       short M01_L58
       lea       edx,[r14+1]
       mov       [rcx+10],edx
       movsxd    rdx,r14d
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rbp-68]
       jmp       short M01_L59
M01_L56:
       mov       rcx,rsi
       mov       rdx,offset System.Enum.ToString[[System.UInt32, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L55
M01_L57:
       xor       r14d,r14d
       jmp       near ptr M01_L46
M01_L58:
       mov       rdx,r8
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-68]
M01_L59:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       cmp       [rax],rcx
       jne       near ptr M01_L88
       mov       rbx,rax
       mov       edi,[rbx+18]
       test      edi,edi
       je        short M01_L62
       cmp       edi,1
       jne       near ptr M01_L94
       mov       rax,[rbp-68]
       mov       dword ptr [rbx+18],0FFFFFFFF
M01_L60:
       mov       rax,[rbp-68]
       mov       r8d,[rbx+20]
       inc       r8d
       mov       [rbx+20],r8d
       mov       rcx,[rbx+10]
       cmp       [rcx+8],r8d
       jg        near ptr M01_L44
M01_L61:
       mov       rax,[rbp-68]
       xor       r8d,r8d
       mov       [rbx+10],r8
       jmp       near ptr M01_L94
M01_L62:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,23648D41128
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L69
M01_L63:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M01_L73
M01_L64:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L71
       mov       r13,[rcx+8]
M01_L65:
       mov       r12d,[r13+8]
       mov       r10d,r12d
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],ecx
       mov       [rbp-44],r10d
       xor       r14d,r14d
       test      r12d,r12d
       jle       short M01_L68
M01_L66:
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M01_L67
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF94CDE4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L67:
       inc       r14d
       cmp       r12d,r14d
       jg        short M01_L66
M01_L68:
       mov       rdx,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M01_L72
       cmp       r12d,1
       je        near ptr M01_L81
       test      r12d,r12d
       jl        near ptr M01_L89
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L82
       mov       esi,[rdx+8]
       cmp       esi,r12d
       je        near ptr M01_L43
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       add       rdi,10
       mov       rdx,rdi
       mov       eax,esi
       cmp       r12d,eax
       jg        near ptr M01_L83
       mov       rax,[rbp-68]
       jmp       near ptr M01_L40
M01_L69:
       mov       rcx,276DEFD3B38
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L63
M01_L70:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M01_L94
M01_L71:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF94CDE4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L65
M01_L72:
       mov       rax,[rbp-68]
       mov       rcx,2364D003530
       mov       rdx,[rcx]
       jmp       near ptr M01_L43
M01_L73:
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
       jne       near ptr M01_L64
       mov       rax,[rbp-68]
       mov       rcx,rdi
       jmp       near ptr M01_L64
M01_L74:
       mov       rcx,r12
       xor       edx,edx
       mov       r8,[r12]
       mov       r8,[r8+58]
       call      qword ptr [r8]
       mov       rdx,rax
       jmp       near ptr M01_L37
M01_L75:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L37
M01_L76:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF94CDE4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M01_L21
M01_L77:
       mov       rax,[rbp-68]
       mov       rcx,2364D003530
       mov       rdx,[rcx]
       jmp       near ptr M01_L25
M01_L78:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r13
       jmp       near ptr M01_L25
M01_L79:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L25
M01_L80:
       mov       r12d,eax
       jmp       near ptr M01_L28
M01_L81:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,r13
       jmp       near ptr M01_L43
M01_L82:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       jmp       near ptr M01_L43
M01_L83:
       mov       r12d,eax
       jmp       near ptr M01_L42
M01_L84:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       mov       rcx,r12
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L85:
       mov       rcx,r14
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L51
M01_L86:
       mov       rcx,r14
       call      qword ptr [7FF94CAD6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L52
M01_L87:
       mov       rcx,r12
       xor       edx,edx
       mov       rax,[r12]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L88:
       mov       rcx,rax
       mov       r11,7FF94CA40958
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L54
       jmp       near ptr M01_L94
M01_L89:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M01_L90:
       test      r14,r14
       je        short M01_L91
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE05D78]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L91
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D0CC510]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CDA6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L91:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CFB7870]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L92:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D0E49A8]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF94CDEDB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L93:
       call      qword ptr [7FF94CB843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L94:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       je        short M01_L95
       mov       rcx,rax
       mov       r11,7FF94CA40960
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
       call      qword ptr [7FF94CD7ED00]
       int       3
M01_L97:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rcx,rsi
       mov       rdx,7FF94D4679E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L99:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M01_L102
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L100
       jmp       short M01_L101
M01_L100:
       mov       rcx,rsi
       mov       rdx,7FF94D2E2750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L101:
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
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rcx,rsi
       mov       rdx,7FF94D2E2760
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L104:
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
       je        short M01_L105
       jmp       short M01_L106
M01_L105:
       mov       rcx,rsi
       mov       rdx,7FF94D4679F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L106:
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
       je        short M01_L107
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[DotNetTips.Spargine.Extensions.NumericFormat, DotNetTips.Spargine.8.Extensions]]
       mov       rax,[rbp-68]
       cmp       [rax],rcx
       je        short M01_L107
       mov       rcx,rax
       mov       r11,7FF94CA40960
       call      qword ptr [r11]
M01_L107:
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
; Total bytes of code 3283
```

