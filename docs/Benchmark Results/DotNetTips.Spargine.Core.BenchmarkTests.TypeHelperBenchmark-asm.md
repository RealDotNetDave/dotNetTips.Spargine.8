## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateWithParameters()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,23F6FC64C60
       mov       [rax+10],rdx
       mov       rdx,23F6FC64C88
       mov       [rax+18],rdx
       mov       rdx,rax
       mov       rcx,7FFEBEF281E8
       call      qword ptr [7FFEBEF36178]; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
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
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
; 		paramArray = paramArray.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return (T)Activator.CreateInstance(typeof(T), args: paramArray);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L03
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       edx,214
       mov       r9,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE606DF0]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r8,rax
       test      r8,r8
       jne       short M01_L01
M01_L00:
       mov       rax,r8
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FFEBE6B4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FFEBEB07990]
       mov       ecx,1F9F
       mov       rdx,7FFEBE977030
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE977030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE6B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFEBE977030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE6B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEB07780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE7D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBC5560]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FFEBE564000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE6BF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 352
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+128]
       mov       ebp,[rdi+14]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rdx,1A46B000428
       mov       rdx,[rdx]
       mov       r9,[rcx+18]
       mov       rcx,[rcx+28]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       [rsp+40],r9
       mov       [rsp+48],rcx
       lea       rcx,[rsp+40]
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+30],2
       mov       rcx,rsi
       lea       r9,[rsp+28]
       mov       r8,1E4FCE14C60
       call      qword ptr [7FFEBE80D830]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
M00_L01:
       mov       rcx,rdi
       cmp       ebp,[rcx+14]
       jne       short M00_L03
       mov       ecx,[rdi+10]
       cmp       r14d,ecx
       jae       short M00_L02
       mov       rcx,[rdi+8]
       cmp       r14d,[rcx+8]
       jae       short M00_L04
       mov       edx,r14d
       mov       rcx,[rcx+rdx*8+10]
       inc       r14d
       jmp       short M00_L00
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFEBE812A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFEBE935E00]
       int       3
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[r9]
       mov       [rsp+40],rbp
       mov       r14d,[r9+8]
       mov       [rsp+80],r14d
       test      rbx,rbx
       je        near ptr M01_L63
       test      rdi,rdi
       je        near ptr M01_L24
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rdx
       jne       near ptr M01_L64
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FFEBE6943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M01_L01:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M01_L19
       mov       r8d,r13d
       mov       edx,r8d
       lea       rax,[rbx+rdx*2+0C]
       mov       r10d,r12d
       sub       r10d,r8d
       mov       [rsp+30],rax
       mov       eax,r10d
       mov       [rsp+78],eax
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,[rsp+30]
       mov       r9d,eax
       call      qword ptr [7FFEBE93D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+9C],eax
       test      eax,eax
       jl        near ptr M01_L54
       cmp       eax,[rsp+78]
       ja        near ptr M01_L61
       mov       rdx,[rsp+30]
       mov       r8d,eax
       test      r8d,r8d
       je        short M01_L05
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+8C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M01_L04
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        near ptr M01_L20
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       je        short M01_L03
M01_L02:
       mov       eax,[rsp+9C]
       mov       ecx,eax
       add       ecx,[rsp+8C]
       mov       [rsi+18],ecx
       jmp       short M01_L05
M01_L03:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L02
M01_L04:
       mov       rcx,rsi
       mov       r8d,eax
       call      qword ptr [7FFEBE80D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+9C]
M01_L05:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M01_L65
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       ecx,r13d
       movzx     eax,word ptr [rbx+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M01_L26
       cmp       edx,7B
       jne       near ptr M01_L55
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       mov       [rsp+38],r9
       xor       r11d,r11d
       mov       [rsp+7C],r11d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M01_L56
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M01_L28
M01_L06:
       inc       r13d
       xor       r12d,r12d
       xor       ecx,ecx
       mov       [rsp+50],rcx
       cmp       eax,r14d
       jae       near ptr M01_L60
       mov       edx,eax
       mov       rax,[rbp+rdx*8]
       mov       [rsp+48],rax
       test      r15,r15
       jne       near ptr M01_L41
M01_L07:
       test      r12,r12
       jne       near ptr M01_L14
       mov       [rsp+0A0],r10d
       test      r10d,r10d
       jne       short M01_L10
       mov       [rsp+0A4],r8d
       test      r8d,r8d
       jne       short M01_L09
M01_L08:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFEBE694348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       mov       rax,[rsp+48]
       jne       near ptr M01_L44
M01_L09:
       mov       rdx,rax
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFEBE694348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L11
       mov       r12,[rsp+48]
       test      r12,r12
       jne       near ptr M01_L18
       jmp       near ptr M01_L23
M01_L10:
       mov       [rsp+0A4],r8d
       jmp       short M01_L08
M01_L11:
       mov       eax,[rsp+7C]
       test      eax,eax
       jne       near ptr M01_L49
M01_L12:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+50]
       mov       r11,7FFEBE5509B8
       call      qword ptr [r11]
       mov       r12,rax
M01_L13:
       test      r12,r12
       mov       r8d,[rsp+0A4]
       mov       r10d,[rsp+0A0]
       je        near ptr M01_L51
M01_L14:
       cmp       [r12+8],r8d
       jl        near ptr M01_L52
M01_L15:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        near ptr M01_L01
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+84],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L22
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jg        short M01_L21
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M01_L25
M01_L16:
       add       r12d,[rsp+84]
       mov       [rsi+18],r12d
       jmp       near ptr M01_L01
M01_L17:
       jmp       near ptr M01_L13
M01_L18:
       mov       r8,offset MT_System.String
       cmp       [r12],r8
       jne       near ptr M01_L50
       jmp       short M01_L17
M01_L19:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L20:
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FFEBE745B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L21:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFEBE745B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L16
M01_L22:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFEBE80D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L23:
       xor       r12d,r12d
       jmp       short M01_L17
M01_L24:
       xor       edx,edx
       jmp       near ptr M01_L00
M01_L25:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L16
M01_L26:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEBE80D2D8]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M01_L01
M01_L27:
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L28:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L30
       cmp       eax,0F4240
       jl        short M01_L27
       cmp       edx,20
       jne       short M01_L31
M01_L29:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L30:
       cmp       edx,20
       je        short M01_L29
M01_L31:
       cmp       edx,2C
       jne       near ptr M01_L38
M01_L32:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,20
       je        short M01_L32
       cmp       edx,2D
       jne       short M01_L33
       mov       r10d,1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L33:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M01_L56
       inc       r13d
       cmp       r12d,r13d
       ja        short M01_L35
       jmp       near ptr M01_L57
M01_L34:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
M01_L35:
       cmp       r13d,r12d
       jae       near ptr M01_L65
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L37
       cmp       r8d,0F4240
       jl        short M01_L34
       cmp       edx,20
       jne       short M01_L38
M01_L36:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L37:
       cmp       edx,20
       je        short M01_L36
M01_L38:
       cmp       edx,7D
       je        near ptr M01_L06
       cmp       edx,3A
       jne       near ptr M01_L58
       mov       r9d,r13d
M01_L39:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       je        short M01_L40
       cmp       edx,7B
       jne       short M01_L39
       jmp       near ptr M01_L58
M01_L40:
       inc       r9d
       mov       r11d,r13d
       sub       r11d,r9d
       mov       ecx,r9d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M01_L59
       mov       ecx,r9d
       lea       r9,[rbx+rcx*2+0C]
       mov       r12,r9
       mov       edx,r11d
       mov       [rsp+7C],edx
       mov       [rsp+38],r12
       jmp       near ptr M01_L06
M01_L41:
       mov       r11d,[rsp+7C]
       test      r11d,r11d
       mov       [rsp+0A4],r8d
       mov       [rsp+0A0],r10d
       je        short M01_L43
       mov       r9,[rsp+38]
       mov       [rsp+68],r9
       mov       [rsp+7C],r11d
       mov       [rsp+70],r11d
       lea       rcx,[rsp+68]
       call      00007FFEBE692520
       mov       [rsp+50],rax
       mov       rax,[rsp+48]
M01_L42:
       mov       rcx,r15
       mov       r9,rdi
       mov       rdx,[rsp+50]
       mov       r8,rax
       mov       r11,7FFEBE5509C8
       call      qword ptr [r11]
       mov       r12,rax
       mov       rax,[rsp+48]
       mov       r8d,[rsp+0A4]
       mov       r10d,[rsp+0A0]
       jmp       near ptr M01_L07
M01_L43:
       mov       [rsp+7C],r11d
       jmp       short M01_L42
M01_L44:
       mov       rdx,rcx
       mov       r12,[rsi+8]
       mov       ebp,[rsi+18]
       mov       r14,[rsi+8]
       mov       r14d,[r14+8]
       sub       r14d,[rsi+18]
       mov       [rsp+88],r14d
       test      r12,r12
       jne       short M01_L45
       or        ebp,r14d
       jne       near ptr M01_L61
       xor       ebp,ebp
       xor       r12d,r12d
       jmp       short M01_L46
M01_L45:
       mov       r8d,ebp
       mov       r14d,r14d
       add       r8,r14
       mov       r14d,[r12+8]
       cmp       r8,r14
       ja        near ptr M01_L61
       mov       r8d,ebp
       lea       rbp,[r12+r8*2+10]
       mov       r14d,[rsp+88]
       mov       r12d,r14d
M01_L46:
       mov       [rsp+58],rbp
       mov       [rsp+60],r12d
       mov       r9,[rsp+38]
       mov       [rsp+68],r9
       mov       r11d,[rsp+7C]
       mov       [rsp+70],r11d
       mov       [rsp+20],rdi
       mov       rcx,rdx
       lea       rdx,[rsp+58]
       lea       r9,[rsp+68]
       lea       r8,[rsp+90]
       mov       r11,7FFEBE5509C0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+48]
       mov       rbp,[rsp+40]
       mov       r14d,[rsp+80]
       je        near ptr M01_L09
       mov       ecx,[rsp+90]
       mov       rdx,[rsi+8]
       mov       eax,[rsi+18]
       mov       r9,[rsi+8]
       mov       r9d,[r9+8]
       sub       r9d,[rsi+18]
       test      rdx,rdx
       jne       short M01_L47
       or        eax,r9d
       jne       near ptr M01_L61
       xor       eax,eax
       jmp       short M01_L48
M01_L47:
       mov       eax,eax
       mov       r11d,r9d
       add       rax,r11
       mov       edx,[rdx+8]
       cmp       rax,rdx
       ja        near ptr M01_L61
       mov       eax,r9d
M01_L48:
       cmp       ecx,eax
       ja        near ptr M01_L62
       mov       ecx,[rsp+90]
       add       [rsi+18],ecx
       cmp       dword ptr [rsp+0A0],0
       je        near ptr M01_L01
       mov       r8d,[rsp+0A4]
       cmp       r8d,[rsp+90]
       jle       near ptr M01_L01
       sub       r8d,[rsp+90]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFEBE80D158]
       jmp       near ptr M01_L01
M01_L49:
       mov       rdx,[rsp+50]
       test      rdx,rdx
       mov       [rsp+50],rdx
       jne       near ptr M01_L12
       mov       rcx,[rsp+38]
       mov       [rsp+68],rcx
       mov       [rsp+70],eax
       lea       rcx,[rsp+68]
       call      00007FFEBE692520
       mov       rcx,rax
       mov       [rsp+50],rcx
       jmp       near ptr M01_L12
M01_L50:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L51:
       mov       r12,1E4FCE00008
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       mov       r8d,[rsp+0A4]
       jge       near ptr M01_L15
M01_L52:
       test      r10d,r10d
       je        short M01_L53
       mov       [rsp+0A4],r8d
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFEBE80D1A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFEBE80D158]
       jmp       near ptr M01_L01
M01_L53:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFEBE80D158]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFEBE80D1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L54:
       mov       r13,[rsp+30]
       mov       [rsp+68],r13
       mov       ebx,[rsp+78]
       mov       [rsp+70],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+68]
       call      qword ptr [7FFEBE80D458]
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L55:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFEBE935F98]
       int       3
M01_L56:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFEBE935F98]
       int       3
M01_L57:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFEBE935F98]
       int       3
M01_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFEBE935F98]
       int       3
M01_L59:
       mov       ecx,21
       call      qword ptr [7FFEBE935B48]
       int       3
M01_L60:
       call      qword ptr [7FFEBE935FB0]
       int       3
M01_L61:
       call      qword ptr [7FFEBE9357E8]
       int       3
M01_L62:
       call      qword ptr [7FFEBE935F80]
       int       3
M01_L63:
       mov       ecx,2F1
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE7B6790]
       int       3
M01_L64:
       mov       rcx,rdi
       mov       rdx,1E4FCE14CB0
       mov       r11,7FFEBE5509B0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2205
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M02_L03
       call      00007FFEBE691E60
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L02
       cmp       [rdx+8],r8d
       jb        short M02_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFEBE745B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18761
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFEBEBA75E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE74D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E4FCE00008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFEBEF05AB8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
; 			if (_builtInTypes == null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ComputeBuiltInTypes();
; 				^^^^^^^^^^^^^^^^^^^^^^
; 			return _builtInTypes.ToList().AsReadOnly();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,1CE91004C30
       cmp       qword ptr [rbx],0
       je        short M01_L02
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider<System.Type>
       call      qword ptr [7FFEBE684348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEBE73DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L01:
       cmp       [rdi],dil
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFEBEF05890]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltInTypes()
       mov       rsi,[rbx]
       test      rsi,rsi
       jne       short M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FFEBE927A38]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FFEBE540AA8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M01_L01
; Total bytes of code 176
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,7FFEBEF08138
       call      qword ptr [7FFEBE7B6130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
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
; Total bytes of code 66
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFEBE5E6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FFEBE694390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.DoesObjectEqualInstance()
       mov       rax,[rcx+50]
       cmp       rax,[rcx+58]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 22
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetMembersWithAttribute()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0B8],rsp
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,12DF1007BA8
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,16E83014C88
       mov       rcx,r15
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M00_L39
M00_L00:
       mov       rcx,16E830020B0
       cmp       rax,rcx
       je        short M00_L01
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M00_L00
       jmp       near ptr M00_L39
M00_L01:
       mov       rcx,16E83014C60
       mov       rax,[7FFEBE5DA358]
       call      qword ptr [rax+28]
       cmp       eax,2
       je        near ptr M00_L40
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,16E83014C60
       mov       rdx,16E83014C88
       mov       r8d,1
       mov       rax,[7FFEBE5DA360]
       call      qword ptr [rax+18]
       movzx     eax,al
M00_L02:
       test      eax,eax
       je        short M00_L03
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L41
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       movsxd    rdx,edx
       mov       r8,16E83014C60
       call      CORINFO_HELP_ARRADDR_ST
M00_L03:
       mov       rcx,16E83014C60
       mov       edx,3C
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5DA670]; System.RuntimeType.GetMembers(System.Reflection.BindingFlags)
       mov       r13,rax
       xor       r12d,r12d
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M00_L15
M00_L04:
       mov       ecx,r12d
       mov       rdi,[r13+rcx*8+10]
       test      rdi,rdi
       je        near ptr M00_L54
       mov       rcx,r15
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M00_L55
M00_L05:
       mov       rcx,16E830020B0
       cmp       rax,rcx
       je        near ptr M00_L17
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M00_L05
       jmp       near ptr M00_L55
M00_L06:
       mov       rcx,16E83014C60
       mov       rdx,r15
       mov       r8d,1
       call      qword ptr [7FFEBE7BE880]; System.Attribute.InternalIsDefined(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       rax,rcx
       jne       near ptr M00_L26
       mov       r10,16E83014C88
       mov       [rbp-90],r10
       test      r10,r10
       je        near ptr M00_L57
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M00_L57
       mov       rcx,rdi
       mov       rdx,r10
       call      qword ptr [7FFEBE7D50E0]; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L48
       mov       rcx,[rdi+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-0A0],rax
       mov       rcx,rdi
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-90]
       xor       r9d,r9d
       call      qword ptr [7FFEBE7D4F30]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M00_L48
       test      byte ptr [rdi+5C],40
       je        short M00_L09
       mov       rcx,[rdi+38]
       cmp       [rcx],cl
       mov       rax,rcx
       test      rax,rax
       je        near ptr M00_L49
       mov       rcx,rax
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
M00_L08:
       test      eax,eax
       je        near ptr M00_L24
M00_L09:
       xor       edx,edx
M00_L10:
       mov       rax,rdx
       test      rax,rax
       jne       near ptr M00_L52
M00_L11:
       xor       eax,eax
M00_L12:
       movzx     r8d,al
M00_L13:
       test      r8d,r8d
       je        short M00_L14
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L53
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       movsxd    rdx,edx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
M00_L14:
       inc       r12d
       cmp       esi,r12d
       jg        near ptr M00_L04
M00_L15:
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[rbp-58]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       call      qword ptr [7FFEBE7BCD80]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.List`1<System.__Canon>)
       lea       rdi,[r15+8]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
M00_L16:
       mov       rcx,r15
       mov       [rbp-70],rcx
       jmp       near ptr M00_L28
M00_L17:
       mov       rax,[rdi]
       mov       [rbp-68],rax
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       rax,rcx
       jne       near ptr M00_L23
       mov       edx,8
M00_L18:
       cmp       edx,2
       je        near ptr M00_L47
       cmp       edx,10
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       cmp       rax,rcx
       jne       near ptr M00_L22
M00_L19:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       rax,[rbp-68]
       cmp       rax,rcx
       jne       near ptr M00_L42
       mov       rax,16E83014C88
       mov       [rbp-88],rax
       test      rax,rax
       je        near ptr M00_L56
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M00_L56
       mov       rcx,[rdi+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rdi+50]
       mov       r8,[rbp-88]
       xor       r9d,r9d
       call      qword ptr [7FFEBE7D4F30]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       je        near ptr M00_L43
M00_L20:
       mov       r8d,1
M00_L21:
       jmp       near ptr M00_L13
M00_L22:
       mov       rdx,rdi
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       near ptr M00_L19
M00_L23:
       mov       rcx,rdi
       mov       rdx,[rax+40]
       call      qword ptr [rdx+28]
       mov       edx,eax
       mov       rax,[rbp-68]
       jmp       near ptr M00_L18
M00_L24:
       mov       rcx,[rdi+38]
       cmp       [rcx],cl
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L25
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdx],rcx
       jne       near ptr M00_L58
M00_L25:
       mov       rax,rdx
       test      rax,rax
       mov       [rbp-0B0],rax
       je        near ptr M00_L09
       mov       rcx,[rdi+50]
       call      System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
       mov       [rbp-3C],eax
       mov       rcx,[rbp-0B0]
       call      System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
       mov       r10d,[rbp-3C]
       cmp       eax,r10d
       jg        near ptr M00_L50
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,rdi
       mov       rdx,16E83014C88
       mov       r8d,1
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L12
M00_L27:
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       test      rcx,rcx
       je        near ptr M00_L33
       mov       rdx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       jmp       short M00_L30
M00_L29:
       mov       rcx,[rbp-70]
       mov       rsi,[rcx+10]
       mov       [rbp-60],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-60]
       mov       rdx,7FFEBEF78C58
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEF178E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp-70]
M00_L30:
       mov       rdx,[rcx]
       add       rcx,8
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7BCDE0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M00_L29
       jmp       near ptr M00_L37
M00_L31:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       mov       r10,[rbp-70]
       cmp       [r10],rcx
       jne       short M00_L34
       mov       rsi,[r10+10]
M00_L32:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-60]
       mov       rdx,7FFEBEF78C58
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEF178E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp-70]
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       cmp       [rcx],rdx
       jne       short M00_L35
       mov       rdx,[rcx]
       add       rcx,8
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7BCDE0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L36
M00_L34:
       mov       rcx,r10
       mov       r11,7FFEBE550A48
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M00_L32
M00_L35:
       mov       r11,7FFEBE550A40
       call      qword ptr [r11]
M00_L36:
       test      eax,eax
       jne       short M00_L31
M00_L37:
       mov       r10,[rbp-70]
       test      r10,r10
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       cmp       [r10],rcx
       jne       short M00_L38
       movsx     rcx,byte ptr [r10+8]
       jmp       near ptr M00_L27
M00_L38:
       mov       rcx,r10
       mov       r11,7FFEBE550A50
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFEBEBA6BF8]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEBE69F708]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M00_L40:
       mov       rcx,16E83014C60
       mov       rdx,r15
       mov       r8d,1
       call      qword ptr [7FFEBE7BE8E0]
       jmp       near ptr M00_L02
M00_L41:
       mov       rcx,r14
       mov       rdx,16E83014C60
       call      qword ptr [7FFEBE74E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L03
M00_L42:
       mov       rcx,rdi
       mov       rdx,16E83014C88
       mov       r8d,1
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M00_L20
M00_L43:
       mov       rcx,r15
       call      qword ptr [7FFEBE7BE988]
       cmp       byte ptr [rax+0D],0
       je        short M00_L46
       mov       rcx,rdi
       call      qword ptr [7FFEBE7BE958]
       mov       rcx,rdi
       mov       [rbp-78],rax
       mov       rdx,rax
       call      qword ptr [7FFEBE7BE898]
       jmp       short M00_L45
M00_L44:
       mov       rcx,rax
       mov       rdx,r15
       xor       r8d,r8d
       mov       [rbp-80],rax
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       test      eax,eax
       jne       near ptr M00_L20
       mov       rax,[rbp-80]
       mov       r8,[rbp-78]
       mov       rcx,rax
       mov       [rbp-78],r8
       mov       rdx,r8
       call      qword ptr [7FFEBE7BE898]
       mov       rdx,rax
       mov       rax,rdx
M00_L45:
       test      rax,rax
       jne       short M00_L44
M00_L46:
       xor       r8d,r8d
       jmp       near ptr M00_L21
M00_L47:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFEBE6943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,1
       call      qword ptr [7FFEBE7BE8E0]
       mov       r8d,eax
       jmp       near ptr M00_L13
M00_L48:
       mov       eax,1
       jmp       near ptr M00_L12
M00_L49:
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       setne     al
       movzx     eax,al
       jmp       near ptr M00_L08
M00_L50:
       mov       rcx,[rbp-0B0]
       mov       edx,r10d
       call      System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)
       mov       rdx,rax
       mov       rcx,[rbp-0B0]
       call      qword ptr [7FFEBE5E6400]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L51
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rdx],rcx
       jne       near ptr M00_L59
M00_L51:
       mov       rcx,rdx
       mov       rdx,rcx
       jmp       near ptr M00_L10
M00_L52:
       mov       [rbp-98],rax
       mov       rcx,[rax+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-98]
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       mov       dword ptr [rsp+20],1
       mov       rcx,[rbp-0A8]
       mov       r8,[rbp-90]
       xor       r9d,r9d
       call      qword ptr [7FFEBE7D4F30]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M00_L48
       mov       rax,[rbp-98]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7BD890]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       rcx,rax
       test      rcx,rcx
       mov       rax,rcx
       jne       short M00_L52
       jmp       near ptr M00_L11
M00_L53:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEBE74E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L14
M00_L54:
       mov       ecx,0D9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE7B6790]
       int       3
M00_L55:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBA6BF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE69F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L56:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEBA5560]
       mov       rdi,rax
       mov       ecx,0E9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEBE69F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L57:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFEBEBA5560]
       mov       r15,rax
       mov       ecx,0E9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFEBE69F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M00_L58:
       mov       rdx,rax
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L59:
       mov       rdx,rax
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L60:
       mov       rcx,7FFEBE5D5120
       mov       edx,60
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,12DF1007BB8
       mov       r15,[rcx]
       jmp       near ptr M00_L16
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
       lea       rbp,[rbp+0E0]
       cmp       qword ptr [rbp-70],0
       je        short M00_L62
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>+Enumerator
       mov       r11,[rbp-70]
       cmp       [r11],rcx
       jne       short M00_L61
       movsx     rcx,byte ptr [r11+8]
       jmp       short M00_L62
M00_L61:
       mov       rcx,r11
       mov       r11,7FFEBE550A50
       call      qword ptr [r11]
M00_L62:
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
; Total bytes of code 2334
```
```assembly
; System.RuntimeType.GetBaseType()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L01
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
       test      eax,eax
       jne       short M01_L02
M01_L00:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       jne       short M01_L03
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.RuntimeTypeHandle.GetBaseType(System.RuntimeType)
M01_L01:
       cmp       [rbx],bl
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FFEBE5DA5A0]
       mov       rsi,rax
       mov       rdi,16E83002008
       xor       ebp,ebp
       jmp       short M01_L08
M01_L04:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       mov       r14,rdx
       test      r14,r14
       je        short M01_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       je        short M01_L05
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L05:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5E4E10]; System.Type.get_IsInterface()
       test      eax,eax
       jne       short M01_L07
       mov       rcx,r14
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        short M01_L06
       mov       rcx,r14
       call      qword ptr [7FFEBE5DA598]
       and       eax,1C
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L07
M01_L06:
       mov       rdi,r14
M01_L07:
       inc       ebp
M01_L08:
       cmp       [rsi+8],ebp
       jg        short M01_L04
       mov       rcx,16E83002008
       cmp       rdi,rcx
       jne       short M01_L09
       mov       rcx,rbx
       call      qword ptr [7FFEBE5DA598]
       mov       rcx,16E83005358
       test      al,8
       cmovne    rdi,rcx
M01_L09:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 276
```
```assembly
; System.RuntimeType.GetMembers(System.Reflection.BindingFlags)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,0D0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       esi,edx
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],3
       xor       edx,edx
       mov       [rsp+30],rdx
       mov       [rsp+38],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFEBE5E66A0]; System.RuntimeType.GetMethodCandidates(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Boolean)
       mov       dword ptr [rsp+20],3
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       lea       rdx,[rbp-40]
       mov       rcx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFEBE5E66B8]; System.RuntimeType.GetConstructorCandidates(System.String, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Boolean)
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-58]
       mov       rcx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFEBE5E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFEBE5E66E8]; System.RuntimeType.GetEventCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rbp-88]
       mov       rcx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFEBE5E6700]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rbp-0A0]
       mov       rcx,rbx
       mov       r9d,esi
       xor       r8d,r8d
       call      qword ptr [7FFEBE5E6718]; System.RuntimeType.GetNestedTypeCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       mov       edx,[rbp-18]
       add       edx,[rbp-30]
       add       edx,[rbp-48]
       add       edx,[rbp-60]
       add       edx,[rbp-78]
       add       edx,[rbp-90]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Reflection.MemberInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       cmp       dword ptr [rbp-18],0
       je        short M02_L02
       cmp       dword ptr [rbp-18],1
       jne       short M02_L01
       xor       edx,edx
       mov       rcx,rbx
       mov       r8,[rbp-20]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L02
M02_L01:
       mov       ecx,[rbp-18]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-28]
       mov       r8,rbx
       xor       r9d,r9d
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L02:
       mov       esi,[rbp-18]
       cmp       dword ptr [rbp-30],0
       je        short M02_L04
       cmp       dword ptr [rbp-30],1
       jne       short M02_L03
       movsxd    rdx,esi
       mov       rcx,rbx
       mov       r8,[rbp-38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L04
M02_L03:
       mov       ecx,[rbp-30]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-40]
       mov       r8,rbx
       mov       r9d,esi
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L04:
       add       esi,[rbp-30]
       cmp       dword ptr [rbp-48],0
       je        short M02_L06
       cmp       dword ptr [rbp-48],1
       jne       short M02_L05
       movsxd    rdx,esi
       mov       rcx,rbx
       mov       r8,[rbp-50]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L06
M02_L05:
       mov       ecx,[rbp-48]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-58]
       mov       r8,rbx
       mov       r9d,esi
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L06:
       add       esi,[rbp-48]
       cmp       dword ptr [rbp-60],0
       je        short M02_L08
       cmp       dword ptr [rbp-60],1
       jne       short M02_L07
       movsxd    rdx,esi
       mov       rcx,rbx
       mov       r8,[rbp-68]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L08
M02_L07:
       mov       ecx,[rbp-60]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-70]
       mov       r8,rbx
       mov       r9d,esi
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L08:
       add       esi,[rbp-60]
       cmp       dword ptr [rbp-78],0
       je        short M02_L10
       cmp       dword ptr [rbp-78],1
       jne       short M02_L09
       movsxd    rdx,esi
       mov       rcx,rbx
       mov       r8,[rbp-80]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       ecx,[rbp-78]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-88]
       mov       r8,rbx
       mov       r9d,esi
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L10:
       add       esi,[rbp-78]
       cmp       dword ptr [rbp-90],0
       je        short M02_L12
       cmp       dword ptr [rbp-90],1
       jne       short M02_L11
       movsxd    rdx,esi
       mov       rcx,rbx
       mov       r8,[rbp-98]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L12
M02_L11:
       mov       ecx,[rbp-90]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-0A0]
       mov       r8,rbx
       mov       r9d,esi
       xor       edx,edx
       call      qword ptr [7FFEBE5E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L12:
       mov       rax,rbx
       add       rsp,0D0
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 666
```
```assembly
; System.Attribute.InternalIsDefined(System.Reflection.PropertyInfo, System.Type, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L11
       test      rsi,rsi
       je        near ptr M03_L08
       mov       rbp,offset MT_System.RuntimeType
       cmp       [rsi],rbp
       jne       near ptr M03_L09
       mov       r14,rsi
M03_L00:
       test      r14,r14
       je        near ptr M03_L10
       cmp       [r14],rbp
       jne       near ptr M03_L10
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbx+50]
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFEBE7D4F30]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
M03_L01:
       test      eax,eax
       je        short M03_L02
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       test      dil,dil
       je        short M03_L07
       mov       rcx,rsi
       call      qword ptr [7FFEBE7BE988]
       cmp       byte ptr [rax+0D],0
       jne       short M03_L03
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FFEBE7BE958]
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFEBE7BE898]
       mov       rbx,rax
       jmp       short M03_L06
M03_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M03_L05
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFEBE7BE898]
       mov       rbx,rax
M03_L06:
       test      rbx,rbx
       jne       short M03_L04
M03_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L08:
       mov       ecx,0E9
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE7B6790]
       int       3
M03_L09:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L10:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFEBEBA5560]
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
M03_L11:
       movzx     r8d,dil
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L01
; Total bytes of code 421
```
```assembly
; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,16E83002008
       cmp       rbx,rcx
       je        near ptr M04_L07
       mov       rcx,16E830020B0
       xor       edi,edi
       cmp       rbx,rcx
       sete      dil
M04_L00:
       movzx     ebp,dil
       test      ebp,ebp
       jne       short M04_L02
       mov       rcx,12DF1000C18
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFEBE7D5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       short M04_L01
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rax,16E83002218
       cmp       rbx,rax
       jne       short M04_L04
M04_L02:
       test      dword ptr [rsi+5C],2000
       je        short M04_L03
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       test      ebp,ebp
       jne       short M04_L05
M04_L04:
       mov       rcx,16E83002240
       cmp       rbx,rcx
       jne       short M04_L06
M04_L05:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFF1E16B010
       test      al,80
       je        short M04_L06
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       edi,1
       jmp       near ptr M04_L00
; Total bytes of code 204
```
```assembly
; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0D0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       add       rax,30
       jne       short M05_L00
       mov       rax,0F0F72F6F9524
       mov       [rbp-30],rax
       mov       ebx,edx
       mov       esi,r9d
       mov       edi,[rbp+30]
       mov       r14,r8
       mov       r15,rcx
       cmp       [r15],r15b
       mov       rcx,r15
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       [rbp-90],r15
       mov       [rbp-88],rax
       lea       r9,[rbp-80]
       mov       rcx,[rbp-88]
       mov       r8d,ebx
       mov       edx,0C000000
       call      System.Reflection.MetadataImport._Enum(IntPtr, Int32, Int32, System.Reflection.MetadataEnumResult ByRef)
       cmp       dword ptr [rbp-78],0
       je        near ptr M05_L03
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       test      r14,r14
       je        near ptr M05_L10
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       xor       esi,esi
       cmp       dword ptr [rbp-78],0
       jle       near ptr M05_L08
M05_L01:
       cmp       qword ptr [rbp-80],0
       je        near ptr M05_L05
       mov       r8,[rbp-80]
       cmp       esi,[r8+8]
       jae       near ptr M05_L17
       mov       r9d,esi
       mov       edx,[r8+r9*4+10]
M05_L02:
       lea       r8,[rbp-98]
       lea       r9,[rbp-0A8]
       mov       rcx,[rbp-88]
       call      System.Reflection.MetadataImport._GetCustomAttributeProps(IntPtr, Int32, Int32 ByRef, System.Reflection.ConstArray ByRef)
       mov       ecx,[rbp-98]
       mov       [rsp+20],r14
       movzx     edx,dil
       mov       [rsp+28],edx
       lea       rdx,[rbp-0C0]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-0C8]
       mov       [rsp+38],rdx
       lea       rdx,[rbp-0D0]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-0D8]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-90]
       mov       r8,r15
       mov       r9d,ebx
       call      qword ptr [7FFEBE7D4F78]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       test      eax,eax
       jne       short M05_L06
       inc       esi
       cmp       esi,[rbp-78]
       jl        near ptr M05_L01
       jmp       short M05_L08
M05_L03:
       xor       eax,eax
       mov       rcx,0F0F72F6F9524
       cmp       [rbp-30],rcx
       je        short M05_L04
       call      CORINFO_HELP_FAIL_FAST
M05_L04:
       nop
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L05:
       lea       rdx,[rbp-74]
       movsxd    r8,esi
       mov       edx,[rdx+r8*4]
       jmp       near ptr M05_L02
M05_L06:
       mov       eax,1
       mov       rcx,0F0F72F6F9524
       cmp       [rbp-30],rcx
       je        short M05_L07
       call      CORINFO_HELP_FAIL_FAST
M05_L07:
       nop
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L08:
       xor       eax,eax
       mov       rcx,0F0F72F6F9524
       cmp       [rbp-30],rcx
       je        short M05_L09
       call      CORINFO_HELP_FAIL_FAST
M05_L09:
       nop
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L10:
       xor       ebx,ebx
       jmp       short M05_L16
M05_L11:
       cmp       qword ptr [rbp-80],0
       je        short M05_L12
       mov       r8,[rbp-80]
       cmp       ebx,[r8+8]
       jae       short M05_L17
       mov       r9d,ebx
       mov       edx,[r8+r9*4+10]
       jmp       short M05_L13
M05_L12:
       lea       rdx,[rbp-74]
       movsxd    r8,ebx
       mov       edx,[rdx+r8*4]
M05_L13:
       lea       r8,[rbp-98]
       lea       r9,[rbp-0A8]
       mov       rcx,[rbp-88]
       call      System.Reflection.MetadataImport._GetCustomAttributeProps(IntPtr, Int32, Int32 ByRef, System.Reflection.ConstArray ByRef)
       mov       eax,[rbp-98]
       cmp       eax,esi
       jne       short M05_L15
       mov       eax,1
       mov       rcx,0F0F72F6F9524
       cmp       [rbp-30],rcx
       je        short M05_L14
       call      CORINFO_HELP_FAIL_FAST
M05_L14:
       nop
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L15:
       inc       ebx
M05_L16:
       cmp       ebx,[rbp-78]
       jl        short M05_L11
       jmp       near ptr M05_L08
M05_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 660
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+10],eax
       mov       eax,[rsi+14]
       mov       [rbx+14],eax
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M07_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M07_L03
M07_L01:
       mov       rax,rdx
       ret
M07_L02:
       jmp       qword ptr [7FFEBE6943A8]
M07_L03:
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       jne       short M07_L00
       jmp       short M07_L02
; Total bytes of code 71
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       [rsp+20],rcx
       mov       eax,[rbx+14]
       cmp       eax,[rcx+14]
       jne       short M09_L00
       mov       eax,[rbx+10]
       cmp       eax,[rcx+10]
       jae       short M09_L00
       lea       rcx,[rbx+8]
       mov       rdx,[rsp+20]
       mov       rdx,[rdx+8]
       cmp       eax,[rdx+8]
       jae       short M09_L01
       mov       eax,eax
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+10]
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L00:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFEBE7BCDF8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M09_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M10_L01
       mov       edx,[rdx+8]
       add       edx,edx
M10_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFEBE74DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L01:
       mov       edx,4
       jmp       short M10_L00
; Total bytes of code 100
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L00
       cmp       [rdx],rcx
       jne       short M11_L01
M11_L00:
       mov       rax,rdx
       ret
M11_L01:
       jmp       qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
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
       xor       ebx,ebx
       mov       [rbp-40],rbx
       mov       rsi,rcx
       mov       rbx,rdx
       lea       rcx,[rbp-88]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.IsDynamicMethod(System.RuntimeMethodHandleInternal)
       test      eax,eax
       jne       near ptr M12_L37
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.GetDeclaringType(System.RuntimeMethodHandleInternal)
       mov       r14,rax
       xor       r15d,r15d
       test      rsi,rsi
       cmove     rsi,r14
       cmp       rsi,r14
       je        near ptr M12_L21
       cmp       [rsi],sil
       test      r14,r14
       je        near ptr M12_L39
       mov       rcx,rsi
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M12_L01
M12_L00:
       cmp       rax,r14
       je        near ptr M12_L21
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M12_L00
M12_L01:
       mov       rcx,16E83002008
       cmp       r14,rcx
       je        near ptr M12_L21
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        near ptr M12_L40
       cmp       eax,1D
       je        near ptr M12_L40
       mov       r13,[r14+18]
       mov       rax,r13
       mov       r12,rax
       and       eax,2
       jne       near ptr M12_L44
       mov       ecx,[r12]
       test      ecx,80000000
       jne       short M12_L02
       xor       edx,edx
       test      cl,30
       setne     dl
       jmp       short M12_L03
M12_L02:
       xor       edx,edx
M12_L03:
       movzx     ecx,dl
       test      ecx,ecx
       je        near ptr M12_L53
       test      eax,eax
       jne       near ptr M12_L45
       mov       ecx,[r13]
       test      ecx,80000000
       jne       short M12_L04
       xor       r8d,r8d
       test      cl,30
       setne     r8b
       jmp       short M12_L05
M12_L04:
       xor       r8d,r8d
M12_L05:
       movzx     r13d,r8b
       test      r13d,r13d
       je        near ptr M12_L46
M12_L06:
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M12_L32
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M12_L32
M12_L07:
       mov       rdx,[rcx+88]
       test      rdx,rdx
       je        near ptr M12_L34
M12_L08:
       mov       r12,rdx
       test      r12,r12
       je        short M12_L09
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M12_L36
M12_L09:
       mov       [rbp+10],rsi
       mov       r13,rsi
M12_L10:
       mov       rcx,r13
       mov       rax,[rcx+18]
       mov       r8,rax
       mov       rdx,r8
       and       r8d,2
       jne       near ptr M12_L47
       mov       edx,[rdx]
       test      edx,80000000
       jne       near ptr M12_L27
       xor       r10d,r10d
       test      dl,30
       setne     r10b
M12_L11:
       movzx     edx,r10b
       test      edx,edx
       je        near ptr M12_L16
       mov       rdx,rax
       test      r8d,r8d
       jne       near ptr M12_L48
       mov       edx,[rdx]
       and       edx,80000030
       cmp       edx,30
       sete      dl
       movzx     edx,dl
M12_L12:
       movzx     edx,dl
       test      edx,edx
       jne       short M12_L16
       test      r8d,r8d
       jne       near ptr M12_L49
       mov       edx,[rax]
       test      edx,80000000
       jne       near ptr M12_L28
       xor       eax,eax
       test      dl,30
       setne     al
M12_L13:
       movzx     eax,al
       test      eax,eax
       je        near ptr M12_L51
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M12_L29
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M12_L29
M12_L14:
       mov       rdx,[rax+88]
       test      rdx,rdx
       je        near ptr M12_L33
M12_L15:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M12_L16
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M12_L52
M12_L16:
       cmp       rcx,r12
       je        short M12_L17
       mov       rcx,r13
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       mov       r13,rax
       test      r13,r13
       jne       near ptr M12_L10
M12_L17:
       test      r13,r13
       je        near ptr M12_L50
       mov       [rbp-48],r13
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.IsGenericMethodDefinition(System.RuntimeMethodHandleInternal)
       test      eax,eax
       jne       near ptr M12_L26
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rdx,[rbp-40]
       mov       rcx,rbx
       mov       r8d,1
       mov       rax,7FFEBE7C2D28
       mov       [rbp-78],rax
       lea       rax,[M12_L18]
       mov       [rbp-60],rax
       lea       rax,[rbp-88]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFF1E1F3D60
       call      rax
M12_L18:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF1E54917C],0
       je        short M12_L19
       call      qword ptr [7FFF1E5393B8]; CORINFO_HELP_STOP_FOR_GC
M12_L19:
       mov       rcx,[rbp-80]
       mov       [rdi+10],rcx
       mov       r15,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       r14,[rbp-48]
M12_L20:
       mov       rcx,rbx
       mov       rdx,r14
       call      System.RuntimeMethodHandle.GetMethodFromCanonical(System.RuntimeMethodHandleInternal, System.RuntimeType)
       mov       rbx,rax
       mov       rsi,[rbp+10]
M12_L21:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,r15
       call      System.RuntimeMethodHandle.GetStubIfNeeded(System.RuntimeMethodHandleInternal, System.RuntimeType, System.RuntimeType[])
       mov       rbx,rax
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.IsConstructor(System.RuntimeMethodHandleInternal)
       test      eax,eax
       jne       near ptr M12_L54
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.HasMethodInstantiation(System.RuntimeMethodHandleInternal)
       test      eax,eax
       jne       near ptr M12_L57
M12_L22:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M12_L30
       mov       r12,[rcx]
       test      r12,r12
       je        short M12_L30
M12_L23:
       cmp       [r12],r12b
       lea       r13,[r12+38]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M12_L35
M12_L24:
       mov       rcx,[r12+38]
       mov       rdx,r14
       mov       r8,rbx
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7BF6C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].AddMethod(System.RuntimeType, System.RuntimeMethodHandleInternal, CacheType)
M12_L25:
       jmp       short M12_L31
M12_L26:
       mov       r14,[rbp-48]
       jmp       near ptr M12_L20
M12_L27:
       xor       r10d,r10d
       jmp       near ptr M12_L11
M12_L28:
       xor       eax,eax
       jmp       near ptr M12_L13
M12_L29:
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M12_L14
M12_L30:
       mov       rcx,rsi
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       short M12_L23
M12_L31:
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
M12_L32:
       mov       rcx,r14
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M12_L07
M12_L33:
       mov       rcx,rax
       call      qword ptr [7FFEBE7B6B80]; System.RuntimeType+RuntimeTypeCache.<GetGenericTypeDefinition>g__CacheGenericDefinition|50_0()
       mov       rdx,rax
       jmp       near ptr M12_L15
M12_L34:
       call      qword ptr [7FFEBE7B6B80]; System.RuntimeType+RuntimeTypeCache.<GetGenericTypeDefinition>g__CacheGenericDefinition|50_0()
       mov       rdx,rax
       jmp       near ptr M12_L08
M12_L35:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       jmp       near ptr M12_L24
M12_L36:
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M12_L37:
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.GetResolver(System.RuntimeMethodHandleInternal)
       test      rax,rax
       je        short M12_L38
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       near ptr M12_L31
M12_L38:
       xor       eax,eax
       jmp       near ptr M12_L31
M12_L39:
       mov       ecx,2B3
       mov       rdx,7FFEBE544000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE7B6790]
       int       3
M12_L40:
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.GetName(System.RuntimeMethodHandleInternal)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,9
       mov       r9d,34
       call      qword ptr [7FFEBE5DA660]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodBase[]
       call      qword ptr [7FFEBE694330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       short M12_L43
M12_L41:
       mov       edx,r12d
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,offset MT_System.IRuntimeMethodInfo
       call      qword ptr [7FFEBE6943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFEBE550BD8
       call      qword ptr [r11]
       cmp       rax,rbx
       jne       short M12_L42
       mov       r13d,1
M12_L42:
       inc       r12d
M12_L43:
       cmp       [rdi+8],r12d
       jg        short M12_L41
       test      r13d,r13d
       jne       near ptr M12_L21
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBA6F40]
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFEBEBA4768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE69F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L44:
       xor       edx,edx
       jmp       near ptr M12_L03
M12_L45:
       xor       r8d,r8d
       movzx     r13d,r8b
       test      r13d,r13d
       jne       near ptr M12_L06
M12_L46:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBACF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE7D5F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L47:
       mov       rsi,[rbp+10]
       xor       r10d,r10d
       mov       [rbp+10],rsi
       jmp       near ptr M12_L11
M12_L48:
       mov       rsi,[rbp+10]
       xor       edx,edx
       mov       [rbp+10],rsi
       jmp       near ptr M12_L12
M12_L49:
       mov       rsi,[rbp+10]
       xor       eax,eax
       mov       [rbp+10],rsi
       jmp       near ptr M12_L13
M12_L50:
       mov       rsi,[rbp+10]
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFEBEBA6F40]
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFEBEBA4768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE69F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L51:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFEBEBACF48]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEBE7D5F68]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M12_L52:
       mov       rcx,rax
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M12_L53:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFEBE5DA800]; Precode of System.RuntimeType.IsAssignableFrom(System.Reflection.TypeInfo)
       test      eax,eax
       jne       near ptr M12_L21
       call      qword ptr [7FFEBEBA6F40]
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFEBE5E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFEBE5E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBEBA4768]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEBE69F708]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M12_L54:
       cmp       qword ptr [rsi+10],0
       je        short M12_L55
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M12_L55
       jmp       short M12_L56
M12_L55:
       mov       rcx,rsi
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M12_L56:
       mov       rdx,r14
       mov       r8,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7B6B50]
       jmp       near ptr M12_L25
M12_L57:
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.IsGenericMethodDefinition(System.RuntimeMethodHandleInternal)
       test      eax,eax
       jne       near ptr M12_L22
       cmp       qword ptr [rsi+10],0
       je        short M12_L58
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M12_L58
       jmp       short M12_L59
M12_L58:
       mov       rcx,rsi
       call      qword ptr [7FFEBE5E6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M12_L59:
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7B6A78]
       jmp       near ptr M12_L25
; Total bytes of code 1778
```
```assembly
; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      byte ptr [rbx+5C],40
       je        short M13_L01
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
       test      eax,eax
       jne       short M13_L01
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       call      qword ptr [7FFEBE5E7330]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       mov       rsi,rdx
       test      rsi,rsi
       je        short M13_L00
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       short M13_L03
M13_L00:
       test      rsi,rsi
       je        short M13_L02
       mov       rcx,[rbx+50]
       call      System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
       mov       edi,eax
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
       cmp       eax,edi
       jg        short M13_L04
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L03:
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M13_L04:
       mov       rcx,rsi
       mov       edx,edi
       call      System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEBE5E6400]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       r8,rax
       test      r8,r8
       je        short M13_L05
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r8],rcx
       je        short M13_L05
       mov       rdx,rax
       call      qword ptr [7FFEBE6943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M13_L05:
       mov       rax,r8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 200
```
**Extern method**
System.RuntimeTypeHandle.GetModule(System.RuntimeType)
System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       byte ptr [rsp+2A],1
       mov       word ptr [rsp+2C],2B
       lea       rdx,[rsp+28]
       mov       rcx,26FF0554C60
       call      qword ptr [7FFEBEF05BA8]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ProcessType(sb, type, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-68],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L33
       mov       rcx,22F62804C40
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L34
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L34
M01_L00:
       mov       r14,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [r14],r14b
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFEBE7FD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-40],r14
       mov       rcx,rbx
       mov       r15,[rcx]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M01_L09
       mov       rcx,[rbx+18]
       mov       rax,rcx
       test      cl,2
       jne       near ptr M01_L08
       test      dword ptr [rax],80000000
       jne       short M01_L02
       test      byte ptr [rax],30
       setne     al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       xor       eax,eax
M01_L03:
       movzx     edx,al
M01_L04:
       test      edx,edx
       jne       near ptr M01_L07
       cmp       r15,r13
       jne       near ptr M01_L11
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        near ptr M01_L10
       xor       r12d,r12d
       cmp       eax,1D
       sete      r12b
M01_L05:
       test      r12d,r12d
       je        near ptr M01_L24
       mov       rcx,rbx
       cmp       r15,r13
       jne       near ptr M01_L12
       call      System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
M01_L06:
       mov       [rbp-50],rax
       lea       rcx,[rbp-40]
       lea       rdx,[rbp-50]
       mov       r8,rsi
       call      qword ptr [7FFEBEF05A40]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-40]
       mov       rdx,26FF0554C94
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M01_L13
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M01_L32
M01_L07:
       mov       rcx,rbx
       mov       rax,[r15+68]
       call      qword ptr [rax+28]
       mov       r8,rax
       mov       rcx,[rbp-40]
       mov       rdx,rbx
       mov       r9d,[r8+8]
       mov       eax,[rsi]
       mov       [rbp-58],eax
       mov       ax,[rsi+4]
       mov       [rbp-54],ax
       lea       rax,[rbp-58]
       mov       [rsp+20],rax
       call      qword ptr [7FFEBEF05C08]
       jmp       near ptr M01_L32
M01_L08:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,rbx
       mov       rax,[r15+60]
       call      qword ptr [rax+8]
       mov       edx,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       r12d,1
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       rax,[r15+58]
       call      qword ptr [rax+10]
       mov       r12d,eax
       jmp       near ptr M01_L05
M01_L12:
       mov       rax,[r15+68]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L06
M01_L13:
       mov       r8d,2
       call      qword ptr [7FFEBE7FD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L32
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       r13,[rbp-40]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7FD1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L32
M01_L16:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       short M01_L23
M01_L17:
       mov       rcx,rbx
       mov       rax,[r15+58]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L25
M01_L18:
       mov       rdx,[r15+50]
       call      qword ptr [rdx+20]
       jmp       short M01_L22
M01_L19:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L20:
       mov       rcx,[rbp-40]
       movzx     r8d,word ptr [rsi+4]
       mov       r9,[rbp-40]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[r14+8]
       jo        short M01_L14
       mov       edx,[r14+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7FD950]
       jmp       near ptr M01_L32
M01_L21:
       mov       rcx,rbx
       cmp       r15,r13
       jne       short M01_L18
       mov       edx,2
       call      qword ptr [7FFEBE5D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L22:
       mov       r14,rax
M01_L23:
       mov       rdi,[rbp-40]
       cmp       [rdi],dil
       test      r14,r14
       je        near ptr M01_L31
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       test      r8d,r8d
       je        near ptr M01_L31
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L30
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L28
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L29
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L29
M01_L24:
       cmp       r15,r13
       jne       near ptr M01_L17
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
M01_L25:
       test      eax,eax
       jne       short M01_L27
       cmp       byte ptr [rsi],0
       je        near ptr M01_L16
       cmp       r15,r13
       jne       near ptr M01_L19
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FFEBE5D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L26:
       test      rax,rax
       je        near ptr M01_L16
       jmp       near ptr M01_L21
M01_L27:
       cmp       byte ptr [rsi+1],0
       jne       near ptr M01_L15
       jmp       short M01_L32
M01_L28:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFEBE735B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L29:
       mov       [rdi+18],ebx
       jmp       short M01_L31
M01_L30:
       mov       rcx,rdi
       call      qword ptr [7FFEBE7FD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L31:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M01_L20
M01_L32:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE802A28]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       mov       rcx,rsp
       call      M01_L36
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       call      qword ptr [7FFEBEAD7990]
       mov       ecx,1C2B
       mov       rdx,7FFEBE947030
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE947030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEBE686B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,0DE3
       mov       rdx,7FFEBE947030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFEBE686B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFEBEAD7780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      qword ptr [7FFEBE7A6718]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L34:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEDC5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L35
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L35:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L36:
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
       lea       rbp,[rbp+90]
       mov       rcx,22F62804C40
       mov       r12,[rcx]
       mov       r14,[rbp-40]
       mov       rax,[r12+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L37
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L41
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFEBE7FD0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L38
M01_L37:
       mov       rdx,r14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L41
M01_L38:
       cmp       qword ptr [r12+20],0
       jne       short M01_L39
       lea       rcx,[r12+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L41
M01_L39:
       lea       rcx,[r12+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r12+28]
       jg        short M01_L40
       mov       rcx,[r12+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFEBEDC5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L41
M01_L40:
       add       r12,2C
       lock dec  dword ptr [r12]
M01_L41:
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
; Total bytes of code 1344
```

## .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v3 (Job: Job-ZSLFFS(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ProcessGenericType()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,218FF401E90
       mov       r8,[rcx]
       mov       byte ptr [rsp+28],1
       mov       byte ptr [rsp+29],0
       mov       byte ptr [rsp+2A],1
       mov       word ptr [rsp+2C],2E
       mov       rcx,rsi
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       rdx,2598546CF60
       call      qword ptr [7FFEBEEF62B0]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FFEBE7F2A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
; 		builder = builder.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		genericArguments = genericArguments.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var offset = 0;
; 		^^^^^^^^^^^^^^^
; 		if (type.IsNested)
; 		^^^^^^^^^^^^^^^^^^
; 			offset = type.DeclaringType.GetGenericArguments().Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (options.FullName)
; 		^^^^^^^^^^^^^^^^^^^^^
; 			if (type.IsNested)
; 			^^^^^^^^^^^^^^^^^^
; 				ProcessGenericType(builder, type.DeclaringType, genericArguments, offset, options);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(options.NestedTypeDelimiter);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			else if (!string.IsNullOrEmpty(type.Namespace))
; 			     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(type.Namespace);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(ControlChars.Dot);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var genericPartIndex = type.Name.IndexOf('`', StringComparison.Ordinal);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (genericPartIndex <= 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(type.Name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = builder.Append(type.Name, 0, genericPartIndex);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (options.IncludeGenericParameters)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(ControlChars.StartAngleBracket);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var typeCount = offset; typeCount < length; typeCount++)
; 			     ^^^^^^^^^^^^^^^^^^^^^^
; 				ProcessType(builder, genericArguments[typeCount], options);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (typeCount + 1 == length)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(ControlChars.Comma);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (options.IncludeGenericParameterNames || !genericArguments[typeCount + 1].IsGenericParameter)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					_ = builder.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(ControlChars.EndAngleBracket);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+90],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       edi,r9d
       mov       rbp,[rsp+0B0]
       mov       rcx,[rsp+90]
       test      rcx,rcx
       je        near ptr M01_L42
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L43
       test      rsi,rsi
       je        near ptr M01_L44
       xor       r14d,r14d
       mov       r15,[rbx]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M01_L46
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L18
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L18
M01_L01:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L16
M01_L02:
       mov       rcx,25985461A50
       cmp       [r12+10],rcx
       jne       near ptr M01_L45
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       near ptr M01_L47
M01_L04:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L28
       cmp       r15,r13
       jne       near ptr M01_L21
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L19
M01_L05:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L15
M01_L06:
       mov       rcx,25985461A50
       cmp       [r12+10],rcx
       jne       near ptr M01_L20
       xor       eax,eax
M01_L07:
       test      rax,rax
       jne       near ptr M01_L22
       cmp       r15,r13
       jne       near ptr M01_L49
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L23
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L23
M01_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE796988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L48
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L48
M01_L09:
       test      rax,rax
       je        near ptr M01_L28
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L28
       mov       r12,[rsp+90]
       cmp       r15,r13
       jne       near ptr M01_L51
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L24
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L10:
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE796988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L50
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L50
M01_L11:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L26
       lea       rdx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rsp+44],eax
       test      eax,eax
       je        near ptr M01_L26
       mov       r8,[r12+8]
       mov       r10d,[r12+18]
       mov       [rsp+40],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L25
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       short M01_L13
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FFEBE725B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       ecx,[rsp+44]
       add       ecx,[rsp+40]
       mov       [r12+18],ecx
       jmp       near ptr M01_L26
M01_L13:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M01_L14
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L14:
       jmp       short M01_L12
M01_L15:
       mov       rcx,[r12+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,25985461A50
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L16:
       mov       rcx,[r12+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,25985461A50
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L17:
       lea       rdx,[rax+0C]
       mov       rbx,[r13+8]
       mov       r15d,[r13+18]
       lea       ecx,[r15+r12]
       cmp       ecx,[rbx+8]
       ja        near ptr M01_L40
       jmp       near ptr M01_L31
M01_L18:
       mov       rcx,rbx
       call      qword ptr [7FFEBE5C6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rcx,rbx
       call      qword ptr [7FFEBE5C6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L20:
       mov       rax,[r12+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L07
M01_L22:
       mov       r12,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       r9d,r14d
       mov       ecx,[rbp]
       mov       [rsp+38],ecx
       mov       cx,[rbp+4]
       mov       [rsp+3C],cx
       mov       rcx,r12
       mov       r8,rsi
       lea       rax,[rsp+38]
       mov       [rsp+20],rax
       call      qword ptr [7FFEBEEF62B0]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7ED2D8]; System.Text.StringBuilder.Append(Char)
       jmp       short M01_L28
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFEBE5C6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L24:
       mov       rcx,rbx
       call      qword ptr [7FFEBE5C6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L25:
       mov       rcx,r12
       mov       r8d,eax
       call      qword ptr [7FFEBE7ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L26:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L27
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],2E
       inc       dword ptr [rcx+18]
       jmp       short M01_L28
M01_L27:
       mov       edx,2E
       call      qword ptr [7FFEBE7ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L28:
       cmp       r15,r13
       jne       near ptr M01_L52
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFEBE5C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L29:
       lea       rcx,[rax+0C]
       mov       r8d,[rax+8]
       mov       edx,60
       call      qword ptr [7FFEBE7EDE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jle       near ptr M01_L53
       mov       rax,[rsp+90]
       mov       [rsp+30],rax
       cmp       r15,r13
       jne       near ptr M01_L54
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFEBE5C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       r13,[rsp+30]
       cmp       [r13],r13b
       test      rax,rax
       je        near ptr M01_L55
M01_L30:
       mov       ecx,[rax+8]
       sub       ecx,r12d
       js        near ptr M01_L56
       jmp       near ptr M01_L17
M01_L31:
       cmp       [rbx],bl
       movsxd    r8,r15d
       lea       rcx,[rbx+r8*2+10]
       cmp       r12d,2
       jle       near ptr M01_L36
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFEBE725B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L32:
       add       r12d,r15d
       mov       [r13+18],r12d
M01_L33:
       cmp       byte ptr [rbp+2],0
       je        near ptr M01_L38
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L39
       cmp       edx,[rax+8]
       jae       near ptr M01_L60
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L34:
       cmp       r14d,edi
       jl        near ptr M01_L57
M01_L35:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L37
       cmp       edx,[rax+8]
       jae       near ptr M01_L60
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
       jmp       short M01_L38
M01_L36:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M01_L32
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L32
M01_L37:
       mov       edx,3E
       call      qword ptr [7FFEBE7ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L38:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L39:
       mov       edx,3C
       call      qword ptr [7FFEBE7ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L34
M01_L40:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FFEBE7ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L33
M01_L41:
       call      CORINFO_HELP_OVERFLOW
M01_L42:
       call      qword ptr [7FFEBEAC7990]
       mov       ecx,2027
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,0DE3
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFEBEAC7780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFEBE796718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L43:
       call      qword ptr [7FFEBEAC7990]
       mov       ecx,1C2B
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEAC7780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE796718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L44:
       call      qword ptr [7FFEBEAC7990]
       mov       ecx,2037
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFEBE937030
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBE676B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEBEAC7780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEBE796718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L45:
       mov       rax,[r12+10]
       jmp       near ptr M01_L03
M01_L46:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L03
M01_L47:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       r14d,[rax+8]
       jmp       near ptr M01_L04
M01_L48:
       xor       eax,eax
       jmp       near ptr M01_L09
M01_L49:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L09
M01_L50:
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L51:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L11
M01_L52:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L29
M01_L53:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7ED1A0]; System.Text.StringBuilder.Append(System.String)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L54:
       mov       rcx,rbx
       mov       rdx,[r15+40]
       call      qword ptr [rdx+30]
       mov       r13,[rsp+30]
       cmp       [r13],r13b
       test      rax,rax
       jne       near ptr M01_L30
M01_L55:
       mov       ecx,2E5
       mov       rdx,7FFEBE524000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEBE796790]
       int       3
M01_L56:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FFEBE524000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEBEB875E8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFEBE72D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L57:
       cmp       r14d,[rsi+8]
       jae       near ptr M01_L60
       mov       edx,r14d
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FFEBEEF60E8]
       add       r14d,1
       jo        near ptr M01_L41
       cmp       r14d,edi
       je        short M01_L59
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7ED2D8]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L58
       cmp       r14d,[rsi+8]
       jae       short M01_L60
       mov       ecx,r14d
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L59
M01_L58:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFEBE7ED2D8]; System.Text.StringBuilder.Append(Char)
M01_L59:
       cmp       r14d,edi
       jl        near ptr M01_L57
       jmp       near ptr M01_L35
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2152
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M02_L03
       call      00007FFEBE671E60
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L02
       cmp       [rdx+8],r8d
       jb        short M02_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFEBE725B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18761
       mov       rdx,7FFEBE524000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFEBEB875E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFEBE72D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25985460008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

