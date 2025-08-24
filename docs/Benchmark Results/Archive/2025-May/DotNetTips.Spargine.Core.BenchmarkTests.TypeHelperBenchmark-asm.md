## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rdx,20DD9FA4768
       mov       [rax+10],rdx
       mov       rdx,20DD9FA4790
       mov       [rax+18],rdx
       mov       rdx,rax
       mov       rcx,7FF9B3728248
       call      qword ptr [7FF9B3734D08]; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
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
       call      qword ptr [7FF9B2DA6DF0]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FF9B2E54390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF9B3374CF0]
       mov       ecx,1F9F
       mov       rdx,7FF9B316BB50
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B316BB50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B316BB50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B3374AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B3076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9B33AD560]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FF9B2D04000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9B2E5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 352
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rdx,25FE1000428
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
       mov       r8,2A06F054768
       call      qword ptr [7FF9B310C930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF9B30FE778]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9B306EFE8]
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
       sub       rsp,98
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rbx,rbx
       je        near ptr M01_L64
       test      rdi,rdi
       je        near ptr M01_L25
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rdx
       jne       near ptr M01_L65
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FF9B2E743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M01_L01:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M01_L20
       mov       r8d,r13d
       mov       edx,r8d
       lea       rax,[rbx+rdx*2+0C]
       mov       r10d,r12d
       sub       r10d,r8d
       mov       [rsp+30],rax
       mov       eax,r10d
       mov       [rsp+70],eax
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,[rsp+30]
       mov       r9d,eax
       call      qword ptr [7FF9B317DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+8C],eax
       test      eax,eax
       jl        near ptr M01_L55
       cmp       eax,[rsp+70]
       ja        near ptr M01_L62
       mov       rdx,[rsp+30]
       mov       r8d,eax
       test      r8d,r8d
       je        short M01_L05
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+7C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M01_L04
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        near ptr M01_L21
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       je        short M01_L03
M01_L02:
       mov       eax,[rsp+8C]
       mov       ecx,eax
       add       ecx,[rsp+7C]
       mov       [rsi+18],ecx
       jmp       short M01_L05
M01_L03:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L02
M01_L04:
       mov       rcx,rsi
       mov       r8d,eax
       call      qword ptr [7FF9B310CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+8C]
M01_L05:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M01_L66
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       ecx,r13d
       movzx     eax,word ptr [rbx+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M01_L27
       cmp       edx,7B
       jne       near ptr M01_L56
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       mov       [rsp+38],r9
       xor       r11d,r11d
       mov       [rsp+74],r11d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M01_L57
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M01_L29
M01_L06:
       inc       r13d
       xor       r12d,r12d
       xor       ecx,ecx
       mov       [rsp+48],rcx
       cmp       eax,r14d
       jae       near ptr M01_L61
       mov       edx,eax
       mov       rax,[rbp+rdx*8]
       mov       [rsp+40],rax
       test      r15,r15
       jne       near ptr M01_L42
M01_L07:
       test      r12,r12
       jne       near ptr M01_L15
       mov       [rsp+90],r10d
       test      r10d,r10d
       jne       short M01_L11
       mov       [rsp+94],r8d
       test      r8d,r8d
       jne       short M01_L10
M01_L08:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FF9B2E74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L45
M01_L09:
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FF9B2E74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L12
       mov       r12,[rsp+40]
       test      r12,r12
       jne       near ptr M01_L18
       jmp       near ptr M01_L24
M01_L10:
       jmp       short M01_L09
M01_L11:
       mov       [rsp+94],r8d
       jmp       short M01_L08
M01_L12:
       mov       eax,[rsp+74]
       test      eax,eax
       jne       near ptr M01_L50
M01_L13:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+48]
       mov       r11,7FF9B2D30988
       call      qword ptr [r11]
       mov       r12,rax
M01_L14:
       test      r12,r12
       mov       r8d,[rsp+94]
       mov       r10d,[rsp+90]
       je        near ptr M01_L52
M01_L15:
       cmp       [r12+8],r8d
       jl        near ptr M01_L53
M01_L16:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        near ptr M01_L01
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+78],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M01_L23
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jg        short M01_L22
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        short M01_L26
M01_L17:
       add       r12d,[rsp+78]
       mov       [rsi+18],r12d
       jmp       near ptr M01_L01
M01_L18:
       mov       r8,offset MT_System.String
       cmp       [r12],r8
       jne       near ptr M01_L51
M01_L19:
       jmp       near ptr M01_L14
M01_L20:
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L22:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L17
M01_L23:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9B310CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L24:
       xor       r12d,r12d
       jmp       short M01_L19
M01_L25:
       xor       edx,edx
       jmp       near ptr M01_L00
M01_L26:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L17
M01_L27:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FF9B310C3D8]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M01_L01
M01_L28:
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L29:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L31
       cmp       eax,0F4240
       jl        short M01_L28
       cmp       edx,20
       jne       short M01_L32
M01_L30:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L31:
       cmp       edx,20
       je        short M01_L30
M01_L32:
       cmp       edx,2C
       jne       near ptr M01_L39
M01_L33:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,20
       je        short M01_L33
       cmp       edx,2D
       jne       short M01_L34
       mov       r10d,1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L34:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M01_L57
       inc       r13d
       cmp       r12d,r13d
       ja        short M01_L36
       jmp       near ptr M01_L58
M01_L35:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
M01_L36:
       cmp       r13d,r12d
       jae       near ptr M01_L66
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L38
       cmp       r8d,0F4240
       jl        short M01_L35
       cmp       edx,20
       jne       short M01_L39
M01_L37:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M01_L38:
       cmp       edx,20
       je        short M01_L37
M01_L39:
       cmp       edx,7D
       je        near ptr M01_L06
       cmp       edx,3A
       jne       near ptr M01_L59
       mov       r9d,r13d
M01_L40:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L58
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       je        short M01_L41
       cmp       edx,7B
       jne       short M01_L40
       jmp       near ptr M01_L59
M01_L41:
       inc       r9d
       mov       r11d,r13d
       sub       r11d,r9d
       mov       ecx,r9d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M01_L60
       mov       ecx,r9d
       lea       r9,[rbx+rcx*2+0C]
       mov       r12,r9
       mov       edx,r11d
       mov       [rsp+74],edx
       mov       [rsp+38],r12
       jmp       near ptr M01_L06
M01_L42:
       mov       r11d,[rsp+74]
       test      r11d,r11d
       mov       [rsp+94],r8d
       mov       [rsp+90],r10d
       je        short M01_L44
       mov       r9,[rsp+38]
       mov       [rsp+60],r9
       mov       [rsp+74],r11d
       mov       [rsp+68],r11d
       lea       rcx,[rsp+60]
       call      00007FF9B2E72520
       mov       [rsp+48],rax
       mov       rax,[rsp+40]
M01_L43:
       mov       rcx,r15
       mov       r9,rdi
       mov       rdx,[rsp+48]
       mov       r8,rax
       mov       r11,7FF9B2D30998
       call      qword ptr [r11]
       mov       r12,rax
       mov       rax,[rsp+40]
       mov       r8d,[rsp+94]
       mov       r10d,[rsp+90]
       jmp       near ptr M01_L07
M01_L44:
       mov       [rsp+74],r11d
       jmp       short M01_L43
M01_L45:
       mov       rdx,[rsi+8]
       mov       r9d,[rsi+18]
       mov       r8,[rsi+8]
       mov       r8d,[r8+8]
       sub       r8d,[rsi+18]
       test      rdx,rdx
       jne       short M01_L46
       or        r9d,r8d
       jne       near ptr M01_L62
       xor       r9d,r9d
       xor       r11d,r11d
       jmp       short M01_L47
M01_L46:
       mov       r11d,r9d
       mov       eax,r8d
       add       r11,rax
       mov       eax,[rdx+8]
       cmp       r11,rax
       ja        near ptr M01_L62
       mov       r9d,r9d
       lea       r9,[rdx+r9*2+10]
       mov       r11d,r8d
M01_L47:
       mov       [rsp+50],r9
       mov       [rsp+58],r11d
       mov       r12,[rsp+38]
       mov       [rsp+60],r12
       mov       eax,[rsp+74]
       mov       [rsp+68],eax
       mov       [rsp+20],rdi
       lea       rdx,[rsp+50]
       lea       r9,[rsp+60]
       lea       r8,[rsp+80]
       mov       r11,7FF9B2D30990
       call      qword ptr [r11]
       test      eax,eax
       mov       [rsp+38],r12
       je        near ptr M01_L09
       mov       r8d,[rsp+80]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+18]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       sub       eax,[rsi+18]
       test      rcx,rcx
       jne       short M01_L48
       or        edx,eax
       jne       near ptr M01_L62
       xor       edx,edx
       jmp       short M01_L49
M01_L48:
       mov       edx,edx
       mov       r10d,eax
       add       rdx,r10
       mov       ecx,[rcx+8]
       cmp       rdx,rcx
       ja        near ptr M01_L62
       mov       edx,eax
M01_L49:
       cmp       r8d,edx
       ja        near ptr M01_L63
       mov       r8d,[rsp+80]
       add       [rsi+18],r8d
       cmp       dword ptr [rsp+90],0
       je        near ptr M01_L01
       mov       r12d,[rsp+94]
       cmp       r12d,[rsp+80]
       jle       near ptr M01_L01
       mov       r8d,r12d
       sub       r8d,[rsp+80]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF9B310C258]
       jmp       near ptr M01_L01
M01_L50:
       mov       rdx,[rsp+48]
       test      rdx,rdx
       mov       [rsp+48],rdx
       jne       near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       [rsp+60],rcx
       mov       [rsp+68],eax
       lea       rcx,[rsp+60]
       call      00007FF9B2E72520
       mov       rcx,rax
       mov       [rsp+48],rcx
       jmp       near ptr M01_L13
M01_L51:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M01_L19
M01_L52:
       mov       r12,2A06F040008
       mov       [rsp+94],r8d
       cmp       [r12+8],r8d
       mov       r8d,[rsp+94]
       jge       near ptr M01_L16
M01_L53:
       test      r10d,r10d
       je        short M01_L54
       mov       [rsp+94],r8d
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FF9B310C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF9B310C258]
       jmp       near ptr M01_L01
M01_L54:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF9B310C258]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FF9B310C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L55:
       mov       r13,[rsp+30]
       mov       [rsp+60],r13
       mov       ebx,[rsp+70]
       mov       [rsp+68],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+60]
       call      qword ptr [7FF9B310C558]
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L56:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FF9B306F180]
       int       3
M01_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FF9B306F180]
       int       3
M01_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF9B306F180]
       int       3
M01_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF9B306F180]
       int       3
M01_L60:
       mov       ecx,21
       call      qword ptr [7FF9B306ED30]
       int       3
M01_L61:
       call      qword ptr [7FF9B306F198]
       int       3
M01_L62:
       call      qword ptr [7FF9B306E9D0]
       int       3
M01_L63:
       call      qword ptr [7FF9B306F168]
       int       3
M01_L64:
       mov       ecx,2F1
       mov       rdx,7FF9B2D24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B30966E8]
       int       3
M01_L65:
       mov       rcx,rdi
       mov       rdx,2A06F0547B8
       mov       r11,7FF9B2D30980
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2129
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
       call      00007FF9B2E71E60
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
       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9B2D24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9B33CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9B2F2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2A06F040008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9B3724CD8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
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
       mov       rbx,25E54408B78
       cmp       qword ptr [rbx],0
       je        short M01_L02
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider<System.Type>
       call      qword ptr [7FF9B2E44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9B2EFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9B3724AB0]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltInTypes()
       mov       rsi,[rbx]
       test      rsi,rsi
       jne       short M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FF9B3064F30]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FF9B2D00A78
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M01_L01
; Total bytes of code 176
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,7FF9B3718770
       call      qword ptr [7FF9B2FC6130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FF9B2D96E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FF9B2E44390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rcx,215EDE24768
       call      qword ptr [7FF9B372F150]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
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
       je        near ptr M01_L31
       mov       rcx,1D564002BB8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L32
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L32
M01_L00:
       mov       r14,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [r14],r14b
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9B302D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-40],r14
       mov       rcx,rbx
       mov       r15,[rcx]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M01_L11
       mov       rcx,[rbx+18]
       mov       rax,rcx
       test      cl,2
       jne       near ptr M01_L10
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
       jne       near ptr M01_L09
       cmp       r15,r13
       jne       near ptr M01_L13
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        near ptr M01_L12
       xor       r12d,r12d
       cmp       eax,1D
       sete      r12b
M01_L05:
       test      r12d,r12d
       je        near ptr M01_L26
       mov       rcx,rbx
       cmp       r15,r13
       jne       near ptr M01_L14
       call      System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
M01_L06:
       mov       [rbp-50],rax
       lea       rcx,[rbp-40]
       lea       rdx,[rbp-50]
       mov       r8,rsi
       call      qword ptr [7FF9B372EFE8]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-40]
       mov       rdx,215EDE2479C
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        short M01_L07
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M01_L30
M01_L07:
       mov       r8d,2
       call      qword ptr [7FF9B302D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L30
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
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
       call      qword ptr [7FF9B372F1B0]
       jmp       near ptr M01_L30
M01_L10:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rbx
       mov       rax,[r15+60]
       call      qword ptr [rax+8]
       mov       edx,eax
       jmp       near ptr M01_L04
M01_L12:
       mov       r12d,1
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,rbx
       mov       rax,[r15+58]
       call      qword ptr [rax+10]
       mov       r12d,eax
       jmp       near ptr M01_L05
M01_L14:
       mov       rax,[r15+68]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L06
M01_L15:
       mov       r13,[rbp-40]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L30
M01_L16:
       mov       rcx,rbx
       mov       rax,[r15+58]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L27
M01_L17:
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       mov       r12,rax
       jmp       near ptr M01_L22
M01_L18:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       jmp       short M01_L21
M01_L19:
       mov       rcx,[rbp-40]
       movzx     r8d,word ptr [rsi+4]
       mov       r9,[rbp-40]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[r12+8]
       jo        near ptr M01_L08
       mov       edx,[r12+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D950]
       jmp       near ptr M01_L30
M01_L20:
       cmp       byte ptr [rsi],0
       je        near ptr M01_L23
       cmp       r15,r13
       jne       short M01_L18
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FF9B2DB6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L21:
       test      rax,rax
       je        short M01_L23
       mov       rcx,rbx
       cmp       r15,r13
       jne       near ptr M01_L17
       mov       edx,2
       call      qword ptr [7FF9B2DB6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       r12,rax
M01_L22:
       mov       rdi,[rbp-40]
       cmp       [rdi],dil
       test      r12,r12
       je        near ptr M01_L29
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M01_L29
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L28
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L24
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L25
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L25
M01_L23:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       jmp       short M01_L22
M01_L24:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       mov       [rdi+18],r14d
       jmp       short M01_L29
M01_L26:
       cmp       r15,r13
       jne       near ptr M01_L16
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
M01_L27:
       test      eax,eax
       je        near ptr M01_L20
       cmp       byte ptr [rsi+1],0
       jne       near ptr M01_L15
       jmp       short M01_L30
M01_L28:
       mov       rcx,rdi
       call      qword ptr [7FF9B302D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L29:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M01_L19
M01_L30:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B30396D0]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       mov       rcx,rsp
       call      M01_L34
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
M01_L31:
       call      qword ptr [7FF9B332F588]
       mov       ecx,1C2B
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B332F378]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rsi
       call      qword ptr [7FF9B2FE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B35DD4B8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L33
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L33:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L34:
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
       mov       rcx,1D564002BB8
       mov       rdi,[rcx]
       mov       r14,[rbp-40]
       mov       rax,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L35
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L39
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9B302D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L36
M01_L35:
       mov       rdx,r14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L39
M01_L36:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L37
       lea       rcx,[rdi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L39
M01_L37:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L38
       mov       rcx,[rdi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9B35DD488]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L39
M01_L38:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L39:
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
; Total bytes of code 1335
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rcx,2516B001D78
       mov       r8,[rcx]
       mov       byte ptr [rsp+28],1
       mov       byte ptr [rsp+29],0
       mov       byte ptr [rsp+2A],1
       mov       word ptr [rsp+2C],2E
       mov       rcx,rsi
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       rdx,291FCFECA00
       call      qword ptr [7FF9B372ED90]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FF9B30396D0]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L38
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L39
       test      rsi,rsi
       je        near ptr M01_L40
       xor       r14d,r14d
       mov       r15,[rbx]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M01_L42
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L19
M01_L01:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L16
M01_L02:
       mov       rcx,291FCFE1A50
       cmp       [r12+10],rcx
       jne       near ptr M01_L41
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       near ptr M01_L43
M01_L04:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L22
       cmp       r15,r13
       jne       near ptr M01_L48
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L20
M01_L05:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L15
M01_L06:
       mov       rcx,291FCFE1A50
       cmp       [r12+10],rcx
       jne       near ptr M01_L47
       xor       eax,eax
M01_L07:
       test      rax,rax
       jne       near ptr M01_L49
       cmp       r15,r13
       jne       near ptr M01_L51
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L30
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L30
M01_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FF9B2FE6988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L50
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L50
M01_L09:
       test      rax,rax
       je        near ptr M01_L22
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L22
       mov       r12,[rsp+90]
       cmp       r15,r13
       jne       near ptr M01_L53
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L33
M01_L10:
       cmp       [rcx],ecx
       call      qword ptr [7FF9B2FE6988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L52
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L52
M01_L11:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L18
       lea       rdx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rsp+44],eax
       test      eax,eax
       je        near ptr M01_L18
       mov       r8,[r12+8]
       mov       r10d,[r12+18]
       mov       [rsp+40],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L17
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       short M01_L13
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       ecx,[rsp+44]
       add       ecx,[rsp+40]
       mov       [r12+18],ecx
       jmp       near ptr M01_L18
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
       mov       rax,291FCFE1A50
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
       mov       rax,291FCFE1A50
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L17:
       mov       rcx,r12
       mov       r8d,eax
       call      qword ptr [7FF9B302D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L18:
       mov       rcx,[rsp+90]
       mov       r12d,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],r12d
       jbe       short M01_L21
       jmp       near ptr M01_L34
M01_L19:
       mov       rcx,rbx
       call      qword ptr [7FF9B2DB6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rbx
       call      qword ptr [7FF9B2DB6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       edx,2E
       call      qword ptr [7FF9B302D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L22:
       cmp       r15,r13
       jne       near ptr M01_L54
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9B2DB6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L23:
       lea       rcx,[rax+0C]
       mov       r8d,[rax+8]
       mov       edx,60
       call      qword ptr [7FF9B302DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jle       near ptr M01_L55
       mov       rax,[rsp+90]
       mov       [rsp+30],rax
       cmp       r15,r13
       jne       near ptr M01_L56
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9B2DB6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L24:
       mov       rbx,[rsp+30]
       cmp       [rbx],bl
       test      rax,rax
       je        near ptr M01_L57
       mov       r8d,[rax+8]
       sub       r8d,r12d
       js        near ptr M01_L58
       lea       rdx,[rax+0C]
       mov       r8,[rbx+8]
       mov       r15d,[rbx+18]
       lea       ecx,[r15+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L36
       cmp       [r8],r8b
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M01_L29
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       add       r12d,r15d
       mov       [rbx+18],r12d
M01_L26:
       cmp       byte ptr [rbp+2],0
       je        near ptr M01_L32
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L35
       cmp       edx,[rax+8]
       jae       near ptr M01_L59
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L27:
       cmp       r14d,edi
       jl        near ptr M01_L44
M01_L28:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L31
       cmp       edx,[rax+8]
       jae       near ptr M01_L59
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
       jmp       short M01_L32
M01_L29:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M01_L25
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L25
M01_L30:
       mov       rcx,rbx
       call      qword ptr [7FF9B2DB6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L31:
       mov       edx,3E
       call      qword ptr [7FF9B302D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L32:
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
M01_L33:
       mov       rcx,rbx
       call      qword ptr [7FF9B2DB6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L34:
       mov       edx,r12d
       mov       word ptr [rax+rdx*2+10],2E
       inc       dword ptr [rcx+18]
       jmp       near ptr M01_L22
M01_L35:
       mov       edx,3C
       call      qword ptr [7FF9B302D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L27
M01_L36:
       mov       rcx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF9B302D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L26
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       call      qword ptr [7FF9B332F588]
       mov       ecx,2027
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9B332F378]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      qword ptr [7FF9B2FE6718]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L39:
       call      qword ptr [7FF9B332F588]
       mov       ecx,1C2B
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9B332F378]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF9B2FE6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L40:
       call      qword ptr [7FF9B332F588]
       mov       ecx,2037
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B317BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B332F378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B2FE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       mov       rax,[r12+10]
       jmp       near ptr M01_L03
M01_L42:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L03
M01_L43:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       r14d,[rax+8]
       jmp       near ptr M01_L04
M01_L44:
       cmp       r14d,[rsi+8]
       jae       near ptr M01_L59
       mov       edx,r14d
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FF9B372EBC8]
       add       r14d,1
       jo        near ptr M01_L37
       cmp       r14d,edi
       je        short M01_L46
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D2D8]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L45
       cmp       r14d,[rsi+8]
       jae       near ptr M01_L59
       mov       ecx,r14d
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L46
M01_L45:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D2D8]; System.Text.StringBuilder.Append(Char)
M01_L46:
       cmp       r14d,edi
       jl        near ptr M01_L44
       jmp       near ptr M01_L28
M01_L47:
       mov       rax,[r12+10]
       jmp       near ptr M01_L07
M01_L48:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L07
M01_L49:
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
       call      qword ptr [7FF9B372ED90]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D2D8]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L22
M01_L50:
       xor       eax,eax
       jmp       near ptr M01_L09
M01_L51:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L09
M01_L52:
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L53:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L11
M01_L54:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L23
M01_L55:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9B302D1A0]; System.Text.StringBuilder.Append(System.String)
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
M01_L56:
       mov       rcx,rbx
       mov       rdx,[r15+40]
       call      qword ptr [rdx+30]
       jmp       near ptr M01_L24
M01_L57:
       mov       ecx,2E5
       mov       rdx,7FF9B2D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B2FE6790]
       int       3
M01_L58:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FF9B2D14000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9B33BDEF0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FF9B2F1D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L59:
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
       call      00007FF9B2E61E60
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
       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9B2D14000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9B33BDEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9B2F1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,291FCFE0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

