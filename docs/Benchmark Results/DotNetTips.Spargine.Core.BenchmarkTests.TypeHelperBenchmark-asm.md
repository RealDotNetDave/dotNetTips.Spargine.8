## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,2AC63253B88
       mov       [rax+10],rdx
       mov       rdx,2AC63253BB0
       mov       [rax+18],rdx
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.Create[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Object[])
       call      qword ptr [7FF94D42D458]; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
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
       call      qword ptr [7FF94CAD6DF0]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FF94CB84390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF94D094438]
       mov       ecx,17EA
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D0CCE58]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FF94CA34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 352
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+118]
       mov       ebp,[rdi+14]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rdx,271B6C00428
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
       mov       r8,2B244B73B88
       call      qword ptr [7FF94CE0C930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF94CDFE3F0]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF94CD6EFE8]
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
       je        near ptr M01_L24
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rdx
       jne       near ptr M01_L65
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FF94CB743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FF94CE7DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       call      qword ptr [7FF94CE0CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L45
M01_L09:
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L12
       mov       r12,[rsp+40]
       test      r12,r12
       jne       near ptr M01_L19
       jmp       near ptr M01_L25
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
       mov       r11,7FF94CA308F8
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
       jmp       short M01_L14
M01_L19:
       mov       r8,offset MT_System.String
       cmp       [r12],r8
       jne       near ptr M01_L51
       jmp       short M01_L18
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
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L22:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L17
M01_L23:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF94CE0CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L24:
       xor       edx,edx
       jmp       near ptr M01_L00
M01_L25:
       xor       r12d,r12d
       jmp       short M01_L18
M01_L26:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L17
M01_L27:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FF94CE0C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+48],rax
       mov       rax,[rsp+40]
M01_L43:
       mov       rcx,r15
       mov       r9,rdi
       mov       rdx,[rsp+48]
       mov       r8,rax
       mov       r11,7FF94CA30908
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
       mov       r11,7FF94CA30900
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
       call      qword ptr [7FF94CE0C258]
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
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       mov       [rsp+48],rcx
       jmp       near ptr M01_L13
M01_L51:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M01_L18
M01_L52:
       mov       r12,2B244B60008
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
       call      qword ptr [7FF94CE0C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF94CE0C258]
       jmp       near ptr M01_L01
M01_L54:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF94CE0C258]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FF94CE0C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L55:
       mov       r13,[rsp+30]
       mov       [rsp+60],r13
       mov       ebx,[rsp+70]
       mov       [rsp+68],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+60]
       call      qword ptr [7FF94CE0C558]
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
       call      qword ptr [7FF94CD6F180]
       int       3
M01_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FF94CD6F180]
       int       3
M01_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF94CD6F180]
       int       3
M01_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF94CD6F180]
       int       3
M01_L60:
       mov       ecx,21
       call      qword ptr [7FF94CD6ED30]
       int       3
M01_L61:
       call      qword ptr [7FF94CD6F198]
       int       3
M01_L62:
       call      qword ptr [7FF94CD6E9D0]
       int       3
M01_L63:
       call      qword ptr [7FF94CD6F168]
       int       3
M01_L64:
       mov       ecx,2F1
       mov       rdx,7FF94CA24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD966E8]
       int       3
M01_L65:
       mov       rcx,rdi
       mov       rdx,2B244B73BB0
       mov       r11,7FF94CA308F0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2128
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF94CA24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D0BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B244B60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltinTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF94D42D428]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltinTypes()
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
; DotNetTips.Spargine.Core.TypeHelper.get_BuiltinTypes()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,1BDB0408B20
       cmp       qword ptr [rbx],0
       je        short M01_L02
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L01:
       cmp       [rdi],dil
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
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
       call      qword ptr [7FF94D42D200]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltinTypes()
       mov       rsi,[rbx]
       test      rsi,rsi
       jne       short M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FF94CDA4F30]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FF94CA40A08
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M01_L01
; Total bytes of code 176
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FF94CDBC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FF94CAC6E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FF94CB74390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.DoesObjectEqualInstance()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       mov       rdx,[rbx+48]
       call      qword ptr [7FF94D43D2A8]; DotNetTips.Spargine.Core.TypeHelper.DoesObjectEqualInstance(System.Object, System.Object)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.DoesObjectEqualInstance(System.Object, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        near ptr M01_L01
       xor       eax,eax
       cmp       rcx,rdx
       sete      al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FF94D0A4438]
       mov       ecx,1800
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L01:
       call      qword ptr [7FF94D0A4438]
       mov       ecx,180C
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 328
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,24F56400170
       mov       rcx,[rcx]
       mov       rdx,28FE83B3B88
       mov       r8d,1
       call      qword ptr [7FF94D40DA88]; DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.AppDomain, System.Type, Boolean)
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
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.AppDomain, System.Type, Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       test      rcx,rcx
       je        near ptr M01_L08
       mov       rax,[rbp+18]
       cmp       qword ptr [rbp+18],0
       je        near ptr M01_L09
       mov       [rbp+18],rax
       call      System.Runtime.Loader.AssemblyLoadContext.GetLoadedAssemblies()
       mov       rbx,rax
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[System.Reflection.Assembly, System.Private.CoreLib]]
       cmp       [rdx],rcx
       je        near ptr M01_L10
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Immutable.IImmutableArray
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L12
       mov       r8d,[rbx+8]
       test      r8d,r8d
       jl        near ptr M01_L07
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableExtensions.ToArray[[System.Reflection.Assembly, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.Assembly>, Int32)
       call      qword ptr [7FF94D446BF8]; System.Collections.Immutable.ImmutableExtensions.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rsi,rax
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,24F564054E0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],rbx
       mov       ebx,[rsi+8]
       mov       [rbp-30],rsi
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L01:
       mov       ecx,[rbp-1C]
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       short M01_L03
       call      qword ptr [7FF94CD9BB20]; System.Reflection.RuntimeAssembly.get_DefinedTypes()
       mov       rdi,rax
       jmp       short M01_L04
M01_L02:
       mov       [rbp-28],rdi
       jmp       near ptr M01_L05
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<LoadDerivedTypes>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+3C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r8d,byte ptr [rbp+20]
       mov       [rbx+41],r8b
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FF94D615B18]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jle       short M01_L05
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L02
       mov       rcx,[rbp-28]
       mov       rdx,rdi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
M01_L05:
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
       mov       rsi,[rbp-30]
       mov       ebx,[rsi+8]
       cmp       ebx,ecx
       jg        near ptr M01_L01
M01_L06:
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       call      qword ptr [7FF94D074438]
       mov       ecx,1830
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       call      qword ptr [7FF94D074438]
       mov       ecx,181E
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[System.Reflection.Assembly, System.Private.CoreLib]]
       call      qword ptr [7FF94CB64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rsi,[rax]
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,40B
       mov       rdx,7FF94D3FE5B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D445950]
       int       3
M01_L12:
       mov       rcx,rax
       mov       r11,7FF94CA20A38
       call      qword ptr [r11]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L13
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D446E98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CD86718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.Reflection.Assembly[]
       call      qword ptr [7FF94CB64390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L14:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,rdx
       mov       edx,2C
       call      qword ptr [7FF94D2CEA78]
       mov       rcx,rax
       call      qword ptr [7FF94D4446D8]
       lea       rax,[M01_L05]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 1015
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetMembersWithAttribute()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetMembersWithAttribute[[DotNetTips.Spargine.Core.InformationAttribute, DotNetTips.Spargine.8.Core]](System.Type)
       mov       rdx,26606C43B88
       call      qword ptr [7FF94D43D668]; DotNetTips.Spargine.Core.TypeHelper.GetMembersWithAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)
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
; DotNetTips.Spargine.Core.TypeHelper.GetMembersWithAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       mov       [rsp+90],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L66
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.MemberInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,22574C055B0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M01_L01
M01_L00:
       mov       rcx,26606C32DB8
       cmp       rax,rcx
       je        short M01_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M01_L00
M01_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       [rsi],rcx
       jne       near ptr M01_L67
M01_L02:
       mov       rbp,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rbx],rbp
       jne       near ptr M01_L24
       mov       r14d,8
M01_L03:
       cmp       r14d,2
       je        near ptr M01_L32
       cmp       r14d,10
       je        short M01_L04
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       cmp       [rbx],rbp
       jne       near ptr M01_L39
       test      rdx,rdx
       je        near ptr M01_L60
       mov       r14,offset MT_System.RuntimeType
       cmp       [rdx],r14
       jne       near ptr M01_L33
       mov       r15,rdx
       jmp       near ptr M01_L34
M01_L04:
       mov       rcx,rbx
       mov       rdx,offset MT_System.Reflection.PropertyInfo
       cmp       [rcx],rdx
       jne       short M01_L06
M01_L05:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF94CDF4018]; System.Attribute.InternalIsDefined(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M01_L37
M01_L06:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M01_L05
M01_L07:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rax,[rsp+80]
       cmp       rax,rbp
       jne       near ptr M01_L48
       test      rdx,rdx
       je        near ptr M01_L60
       cmp       [rdx],r14
       jne       near ptr M01_L81
       cmp       [rdx],dl
       mov       r8,rdx
M01_L08:
       mov       r10,r8
       mov       [rsp+58],r10
       test      r10,r10
       je        near ptr M01_L61
       cmp       [r10],r14
       jne       near ptr M01_L61
       mov       rcx,r13
       mov       rdx,r10
       call      qword ptr [7FF94CDF63A0]; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L82
       mov       rcx,[r13+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+48],rax
       mov       rcx,r13
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rsp+48]
       mov       r8,[rsp+58]
       xor       r9d,r9d
       call      qword ptr [7FF94CDF61D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L82
       test      byte ptr [r13+5C],40
       je        short M01_L10
       mov       rcx,[r13+38]
       cmp       [rcx],cl
       mov       rax,rcx
       test      rax,rax
       je        near ptr M01_L83
       mov       rcx,rax
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
M01_L09:
       test      eax,eax
       je        near ptr M01_L41
M01_L10:
       xor       edx,edx
M01_L11:
       mov       rax,rdx
       test      rax,rax
       jne       short M01_L18
M01_L12:
       xor       eax,eax
M01_L13:
       movzx     eax,al
M01_L14:
       test      eax,eax
       jne       near ptr M01_L53
M01_L15:
       inc       ebx
       cmp       r15d,ebx
       jle       near ptr M01_L52
M01_L16:
       mov       ecx,ebx
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        near ptr M01_L55
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M01_L22
M01_L17:
       mov       rcx,26606C32DB8
       cmp       rax,rcx
       je        near ptr M01_L23
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M01_L17
       jmp       near ptr M01_L22
M01_L18:
       mov       [rsp+50],rax
       mov       rcx,[rax+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       mov       dword ptr [rsp+20],1
       mov       rcx,[rsp+40]
       mov       r8,[rsp+58]
       xor       r9d,r9d
       call      qword ptr [7FF94CDF61D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L82
       mov       rax,[rsp+50]
       test      byte ptr [rax+5C],40
       je        short M01_L20
       mov       [rsp+50],rax
       mov       rcx,[rax+38]
       cmp       [rcx],cl
       mov       rdx,rcx
       test      rdx,rdx
       je        near ptr M01_L84
       mov       rcx,rdx
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
M01_L19:
       test      eax,eax
       je        near ptr M01_L49
M01_L20:
       xor       eax,eax
M01_L21:
       test      rax,rax
       jne       short M01_L18
       jmp       near ptr M01_L12
M01_L22:
       mov       rcx,offset MT_System.Attribute
       cmp       [rsi],rcx
       jne       near ptr M01_L56
M01_L23:
       mov       rax,[r13]
       mov       [rsp+80],rax
       cmp       rax,rbp
       jne       short M01_L25
       jmp       near ptr M01_L40
M01_L24:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M01_L03
M01_L25:
       mov       rcx,r13
       mov       rdx,[rax+40]
       call      qword ptr [rdx+28]
M01_L26:
       cmp       eax,2
       je        near ptr M01_L80
       cmp       eax,10
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       cmp       [rsp+80],rcx
       jne       short M01_L28
M01_L27:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       rdx,[rsp+80]
       cmp       rdx,rcx
       jne       near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L60
       cmp       [rax],r14
       jne       near ptr M01_L71
       jmp       short M01_L29
M01_L28:
       mov       rdx,r13
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M01_L27
M01_L29:
       mov       [rsp+68],rax
       test      rax,rax
       je        near ptr M01_L57
       cmp       [rax],r14
       jne       near ptr M01_L57
       mov       rcx,[r13+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[r13+50]
       mov       r8,[rsp+68]
       xor       r9d,r9d
       call      qword ptr [7FF94CDF61D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
M01_L30:
       test      eax,eax
       jne       near ptr M01_L73
       mov       rax,26606C43E08
       mov       [rsp+60],rax
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rdx,[rsp+60]
       xor       r8d,r8d
       call      qword ptr [7FF94CDF60E8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.RuntimeType, System.RuntimeType, Boolean)
       cmp       dword ptr [rax+8],1
       jne       near ptr M01_L74
       cmp       dword ptr [rax+8],0
       jbe       near ptr M01_L85
       mov       rdx,[rax+10]
       mov       r8,rdx
       test      r8,r8
       je        short M01_L31
       mov       rcx,offset MT_System.AttributeUsageAttribute
       cmp       [r8],rcx
       jne       near ptr M01_L58
M01_L31:
       cmp       byte ptr [r8+0D],0
       je        near ptr M01_L78
       jmp       near ptr M01_L75
M01_L32:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF94CB943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF94CDF4078]
       jmp       near ptr M01_L37
M01_L33:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       r15,rax
M01_L34:
       test      r15,r15
       je        near ptr M01_L68
       cmp       [r15],r14
       jne       near ptr M01_L68
       mov       r13,rbx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF94CDF63A0]; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L69
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r14,rax
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r14
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF94CDF61D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L69
M01_L35:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDDEB68]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       r13,rax
       test      r13,r13
       jne       short M01_L38
       xor       r14d,r14d
M01_L36:
       movzx     eax,r14b
M01_L37:
       test      eax,eax
       je        near ptr M01_L43
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L42
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L43
M01_L38:
       mov       rcx,[r13+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r14,rax
       mov       rcx,r13
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       mov       dword ptr [rsp+20],1
       mov       rcx,r14
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF94CDF61D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L69
       jmp       near ptr M01_L35
M01_L39:
       mov       rcx,rbx
       mov       r8d,1
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M01_L36
M01_L40:
       mov       ecx,8
       mov       eax,ecx
       jmp       near ptr M01_L26
M01_L41:
       mov       rcx,[r13+38]
       cmp       [rcx],cl
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L46
       jmp       short M01_L45
M01_L42:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L43:
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M01_L70
       mov       rcx,rbx
       mov       edx,3C
       call      qword ptr [7FF94CADA670]; System.RuntimeType.GetMembers(System.Reflection.BindingFlags)
       mov       r12,rax
M01_L44:
       xor       ebx,ebx
       mov       r15d,[r12+8]
       test      r15d,r15d
       jle       near ptr M01_L52
       jmp       near ptr M01_L16
M01_L45:
       mov       rcx,r14
       cmp       [rdx],rcx
       jne       near ptr M01_L62
M01_L46:
       mov       rax,rdx
       test      rax,rax
       mov       [rsp+38],rax
       je        near ptr M01_L10
       mov       rcx,[r13+50]
       call      System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
       mov       [rsp+8C],eax
       mov       rcx,[rsp+38]
       call      System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
       mov       r8d,[rsp+8C]
       cmp       eax,r8d
       jle       near ptr M01_L10
       mov       rax,[rsp+38]
       mov       [rsp+38],rax
       mov       rcx,rax
       mov       edx,r8d
       call      System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF94CAE6400]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L47
       mov       rcx,rbp
       cmp       [rdx],rcx
       jne       near ptr M01_L63
M01_L47:
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M01_L11
M01_L48:
       mov       rcx,r13
       mov       r8d,1
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L13
M01_L49:
       mov       rax,[rsp+50]
       mov       [rsp+50],rax
       mov       rcx,[rax+38]
       cmp       [rcx],cl
       call      qword ptr [7FF94CAE7330]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L50
       mov       rcx,r14
       cmp       [rdx],rcx
       jne       near ptr M01_L64
M01_L50:
       mov       rax,rdx
       test      rax,rax
       mov       [rsp+30],rax
       je        near ptr M01_L20
       mov       rax,[rsp+50]
       mov       [rsp+50],rax
       mov       rcx,[rax+50]
       call      System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
       mov       [rsp+88],eax
       mov       rcx,[rsp+30]
       call      System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
       mov       r8d,[rsp+88]
       cmp       eax,r8d
       jle       near ptr M01_L20
       mov       rax,[rsp+30]
       mov       [rsp+30],rax
       mov       rcx,rax
       mov       edx,r8d
       call      System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)
       mov       rdx,rax
       mov       rcx,[rsp+30]
       call      qword ptr [7FF94CAE6400]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L51
       mov       r10,rbp
       cmp       [rcx],r10
       jne       near ptr M01_L65
M01_L51:
       mov       rax,rcx
       jmp       near ptr M01_L21
M01_L52:
       mov       rax,rdi
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
M01_L53:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L54
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       movsxd    rdx,edx
       mov       r8,r13
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L15
M01_L54:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L15
M01_L55:
       mov       ecx,0D9
       mov       rdx,7FF94CA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CDB66E8]
       int       3
M01_L56:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0DE4F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB9F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L57:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF94D0DCE58]
       mov       r13,rax
       mov       ecx,0E9
       mov       rdx,7FF94CA44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rdi
       call      qword ptr [7FF94CB9F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L58:
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L59:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D0DFC48]
       mov       rbp,rax
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF94D0DC048]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CDF74B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L60:
       mov       ecx,0E9
       mov       rdx,7FF94CA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CDB66E8]
       int       3
M01_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0DCE58]
       mov       r14,rax
       mov       ecx,0E9
       mov       rdx,7FF94CA44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF94CB9F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L62:
       mov       rdx,rax
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L63:
       mov       rdx,rax
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L64:
       mov       rdx,rax
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L65:
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FF94CB943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L66:
       call      qword ptr [7FF94D0A4438]
       mov       ecx,1498
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF94D0A4228]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF94CDB6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF94D0DE4F0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF94CB9F708]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D0DCE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF94CA44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       r14d,1
       jmp       near ptr M01_L36
M01_L70:
       mov       rcx,rbx
       mov       edx,3C
       mov       rax,[rbx]
       mov       rax,[rax+88]
       call      qword ptr [rax+20]
       mov       r12,rax
       jmp       near ptr M01_L44
M01_L71:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L29
M01_L72:
       mov       rcx,r13
       mov       rdx,rax
       mov       r8d,1
       mov       rax,[rsp+80]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L30
M01_L73:
       mov       eax,1
       jmp       near ptr M01_L79
M01_L74:
       cmp       dword ptr [rax+8],0
       jne       near ptr M01_L59
       mov       rcx,7FF94CAD5120
       mov       edx,0EE
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,22574C00178
       mov       r8,[rdx]
       jmp       near ptr M01_L31
M01_L75:
       mov       rcx,r13
       call      qword ptr [7FF94CDF40F0]
       mov       rcx,r13
       mov       [rsp+78],rax
       mov       rdx,rax
       call      qword ptr [7FF94CDF4030]
       jmp       short M01_L77
M01_L76:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,[rsp+70]
       xor       r8d,r8d
       mov       [rsp+70],rcx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L73
       mov       rax,[rsp+70]
       mov       r8,[rsp+78]
       mov       rcx,rax
       mov       [rsp+78],r8
       mov       rdx,r8
       call      qword ptr [7FF94CDF4030]
M01_L77:
       test      rax,rax
       mov       [rsp+70],rax
       jne       short M01_L76
M01_L78:
       xor       eax,eax
M01_L79:
       jmp       near ptr M01_L14
M01_L80:
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF94CB943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FF94CDF4078]
       jmp       near ptr M01_L14
M01_L81:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L08
M01_L82:
       mov       eax,1
       jmp       near ptr M01_L13
M01_L83:
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       setne     al
       movzx     eax,al
       jmp       near ptr M01_L09
M01_L84:
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       setne     al
       movzx     eax,al
       jmp       near ptr M01_L19
M01_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2965
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0D0],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+0D0],1
       mov       dword ptr [rsp+0D4],2
       mov       esi,2
       xor       edx,edx
       mov       [rsp+0D0],rdx
       mov       edi,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L56
M00_L01:
       test      eax,eax
       je        near ptr M00_L57
M00_L02:
       xor       edx,edx
       mov       [rsp+0D0],rdx
       mov       ebp,14
       mov       edx,1
       mov       r8d,edx
       test      edx,edx
       je        near ptr M00_L59
M00_L03:
       test      r8d,r8d
       je        near ptr M00_L60
M00_L04:
       mov       rdx,1774B408260
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L62
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M00_L63
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L71
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M00_L28
       mov       rcx,rax
       mov       r11,7FF94CA10EA0
       call      qword ptr [r11]
       mov       r15d,eax
M00_L06:
       test      r15d,r15d
       jle       near ptr M00_L35
       mov       rcx,r14
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L69
       mov       rcx,1774B40B2A0
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L75
M00_L07:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+10],r8d
       mov       [r14+14],r8d
       mov       rdx,r14
       lea       r8,[rsp+0A0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L08:
       mov       rdx,[r14+88]
       test      rdx,rdx
       je        near ptr M00_L14
       cmp       dword ptr [rdx+8],0
       je        near ptr M00_L14
       mov       r15,[r14+88]
       test      r15,r15
       je        near ptr M00_L76
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L77
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M00_L27
       mov       rcx,rax
       mov       r11,7FF94CA10EC8
       call      qword ptr [r11]
       mov       r13d,eax
M00_L09:
       test      r13d,r13d
       jle       near ptr M00_L37
       mov       rcx,r15
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L67
       mov       rcx,1774B40B2B0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L81
M00_L10:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       test      r12,r12
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       lea       rcx,[r13+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+28],0
       mov       r8d,1
       mov       rdx,r13
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Int32)
       call      qword ptr [7FF94D3C5458]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+98]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M00_L11:
       mov       r13,[rax+8]
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M00_L14
       cmp       dword ptr [rdx+8],0
       je        near ptr M00_L14
       test      r13,r13
       je        near ptr M00_L38
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M00_L26
       mov       rcx,rax
       mov       r11,7FF94CA10EE8
       call      qword ptr [r11]
       mov       r12d,eax
M00_L12:
       test      r12d,r12d
       jle       near ptr M00_L14
       mov       rcx,r13
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L65
       mov       rcx,1774B40B2C0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L43
M00_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       test      r12,r12
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],0
       mov       r8d,1
       mov       rdx,r15
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Int32)
       call      qword ptr [7FF94D3C5458]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+90]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M00_L14:
       mov       rdx,1774B408270
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L45
       mov       r15,[rcx+18]
M00_L15:
       test      r15,r15
       je        near ptr M00_L46
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M00_L25
       mov       rcx,rax
       mov       r11,7FF94CA10F08
       call      qword ptr [r11]
       mov       r12d,eax
M00_L16:
       test      r12d,r12d
       jle       near ptr M00_L36
       mov       byte ptr [rsp+78],0
       lea       r8,[rsp+78]
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef, System.String)
       mov       r9,1B7DD3E0008
       call      qword ptr [7FF94D3C5398]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef, System.String)
       test      eax,eax
       je        near ptr M00_L64
       mov       rcx,1774B40B2D0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L51
M00_L17:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,r12
       xor       r9d,r9d
       call      qword ptr [7FF94CFAF708]; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IComparer`1<Int32>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       r8d,1
       mov       rdx,r13
       mov       rcx,offset MD_System.Linq.Enumerable.Take[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FF94D3C5158]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+70]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L18:
       call      qword ptr [7FF94CFD79D8]; DotNetTips.Spargine.Tester.RandomData.GenerateLastName()
       mov       r9,rax
       lea       rcx,[rsp+80]
       mov       r8,r15
       mov       rdx,offset MT_System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF94D3C4A38]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r15,[rsp+80]
       mov       r13,[rsp+88]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       call      qword ptr [7FF94D2FFC30]; DotNetTips.Spargine.Tester.PersonData..ctor()
       call      qword ptr [7FF94CDF5B90]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0C0]
       mov       r8d,1
       call      qword ptr [7FF94CE6C780]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+0B8],rcx
       mov       ecx,1
       mov       edx,5A
       call      qword ptr [7FF94CFD79A8]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L55
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+0B8]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF94CE6CB58]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+0C0]
       lea       rdx,[rsp+0A8]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF94CE6C6F0]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+0A8]
       vmovups   [r12+38],xmm0
       mov       ecx,[r14+0B8]
       call      qword ptr [7FF94CFD79F0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FF94CFD77C8]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       lea       rcx,[r12+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+0B8]
       call      qword ptr [7FF94CFD79F0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r12+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF94CFDC6D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rsp+20],ebp
       mov       rdx,[r12+10]
       mov       r8d,esi
       mov       r9d,edi
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Core.Data.Models.Country, Int32, Int32, Int32)
       call      qword ptr [7FF94D3C4390]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Core.Data.Models.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CFECD68]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r12+38]
       vmovups   [rsp+48],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+48]
       call      qword ptr [7FF94CFECD78]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r12+8]
       mov       rcx,r15
       call      qword ptr [7FF94CFECD88]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r12+18]
       mov       rcx,r15
       call      qword ptr [7FF94CFECD98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r12+20]
       mov       rcx,r15
       call      qword ptr [7FF94CFECDA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FF94D3C7EB8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CFECDB8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r12+28]
       mov       rcx,r15
       call      qword ptr [7FF94CFECDC8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r12+30]
       mov       rcx,r15
       call      qword ptr [7FF94CFECDD8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF94CB5EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,r15
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B40B2E0
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M00_L24
M00_L19:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FF94CF6F930]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       mov       rcx,1774B40B2E8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L20:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF94CFAF7F8]; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>)
       call      qword ptr [7FF94CFAD968]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       near ptr M00_L32
M00_L21:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],rcx
       jne       near ptr M00_L52
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDDA390]; System.Reflection.RuntimePropertyInfo.GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       near ptr M00_L33
M00_L22:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1774B40B2D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF94D42A580
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L20
M00_L23:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M00_L30
M00_L24:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1774B40B2D8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D42A568
       mov       [rbp+18],rcx
       mov       rcx,1774B40B2E0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbp
       jmp       near ptr M00_L19
M00_L25:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M00_L55
       mov       r12d,eax
       jmp       near ptr M00_L16
M00_L26:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M00_L55
       mov       r12d,eax
       jmp       near ptr M00_L12
M00_L27:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M00_L55
       mov       r13d,eax
       jmp       near ptr M00_L09
M00_L28:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M00_L55
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,offset MT_System.String
       cmp       [r12],rcx
       jne       near ptr M00_L23
       cmp       [r12],r12b
M00_L30:
       mov       [rsp+38],r14
       mov       [rsp+40],r12
       lea       r8,[rsp+38]
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF94D42E628]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
M00_L31:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M00_L21
M00_L32:
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       call      qword ptr [7FF94D42E658]; DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+58],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+58]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF94D4A54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L33:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+30],rax
       test      rax,rax
       jne       near ptr M00_L53
M00_L34:
       test      r12,r12
       je        short M00_L31
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],rcx
       jne       near ptr M00_L54
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDDA2C0]; System.Reflection.RuntimePropertyInfo.get_Name()
       mov       r14,rax
       jmp       near ptr M00_L29
M00_L35:
       xor       r14d,r14d
       jmp       near ptr M00_L08
M00_L36:
       xor       r15d,r15d
       jmp       near ptr M00_L18
M00_L37:
       xor       eax,eax
       jmp       near ptr M00_L11
M00_L38:
       call      qword ptr [7FF94D086D90]
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FF94CD86670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L39:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L40
       mov       rcx,rax
       mov       r11,7FF94CA10EE0
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M00_L12
M00_L40:
       xor       r12d,r12d
       mov       rcx,r13
       mov       r11,7FF94CA10ED0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L42
M00_L41:
       add       r12d,1
       jo        near ptr M00_L55
M00_L42:
       mov       rcx,r15
       mov       r11,7FF94CA10ED8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L41
       jmp       near ptr M00_L12
M00_L43:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,1774B40B2B8
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,7FF94D3C1290
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2C0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L44:
       mov       ecx,9
       call      qword ptr [7FF94CD84F30]
       int       3
M00_L45:
       call      qword ptr [7FF94CF6D680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L15
M00_L46:
       call      qword ptr [7FF94D086D90]
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FF94CD86670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L47:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L48
       mov       rcx,rax
       mov       r11,7FF94CA10F00
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M00_L16
M00_L48:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FF94CA10EF0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M00_L50
M00_L49:
       add       r12d,1
       jo        near ptr M00_L55
M00_L50:
       mov       rcx,r13
       mov       r11,7FF94CA10EF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L49
       jmp       near ptr M00_L16
M00_L51:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,1774B40B2C8
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,7FF94D3C1290
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2D0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L17
M00_L52:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M00_L33
M00_L53:
       mov       rcx,rax
       mov       r11,7FF94CA10F10
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L34
       mov       rcx,r14
       mov       rdx,[r14]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r14,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,[rsp+30]
       mov       edx,2C
       call      qword ptr [7FF94D2FFB88]
       mov       r9,rax
       lea       rcx,[rsp+60]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF94CB5F348]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       r8,[rsp+38]
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF94D42E628]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M00_L31
M00_L54:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L29
M00_L55:
       call      CORINFO_HELP_OVERFLOW
M00_L56:
       movzx     ecx,byte ptr [rsp+0D0]
       test      cl,cl
       je        near ptr M00_L01
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF94CC047B0]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L57:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L58
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M00_L58:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EECA8
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L59:
       movzx     ecx,byte ptr [rsp+0D0]
       test      cl,cl
       je        near ptr M00_L03
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF94CC047B0]
       mov       ebp,eax
       jmp       near ptr M00_L04
M00_L60:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L61
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M00_L61:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EECD8
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L62:
       call      qword ptr [7FF94CF6D680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L05
M00_L63:
       call      qword ptr [7FF94D086D90]
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FF94CD86670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L64:
       call      qword ptr [7FF94D086BB0]
       mov       rsi,rax
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94D2FD950]
       int       3
M00_L65:
       call      qword ptr [7FF94D086BB0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FF94D086B80]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EEB80
       mov       r8,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L67:
       call      qword ptr [7FF94D086BB0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L68
       call      qword ptr [7FF94D086B80]
       mov       rbx,rax
M00_L68:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EEB80
       mov       r8,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L69:
       call      qword ptr [7FF94D086BB0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L70
       call      qword ptr [7FF94D086B80]
       mov       rbx,rax
M00_L70:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EEB80
       mov       r8,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L71:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L72
       mov       rcx,rax
       mov       r11,7FF94CA10E98
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L06
M00_L72:
       xor       r15d,r15d
       mov       rcx,r14
       mov       r11,7FF94CA10E88
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M00_L74
M00_L73:
       add       r15d,1
       jo        near ptr M00_L55
M00_L74:
       mov       rcx,r13
       mov       r11,7FF94CA10E90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L73
       jmp       near ptr M00_L06
M00_L75:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1774B40B298
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,7FF94D3C1290
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2A0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L07
M00_L76:
       call      qword ptr [7FF94D086D90]
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FF94CD86670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L77:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L78
       mov       rcx,rax
       mov       r11,7FF94CA10EC0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L09
M00_L78:
       xor       r13d,r13d
       mov       rcx,r15
       mov       r11,7FF94CA10EB0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M00_L80
M00_L79:
       add       r13d,1
       jo        near ptr M00_L55
M00_L80:
       mov       rcx,r12
       mov       r11,7FF94CA10EB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L79
       jmp       near ptr M00_L09
M00_L81:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,1774B40B2A8
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,7FF94D3C1290
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2B0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
; Total bytes of code 4702
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M01_L02
       mov       rbx,[rdx]
       movzx     eax,word ptr [rbx+0E]
       test      rax,rax
       je        short M01_L01
       mov       r8,[rbx+38]
       cmp       rax,4
       jl        short M01_L03
M01_L00:
       cmp       [r8],rcx
       je        short M01_L02
       cmp       [r8+8],rcx
       je        short M01_L02
       cmp       [r8+10],rcx
       je        short M01_L02
       cmp       [r8+18],rcx
       je        short M01_L02
       add       r8,20
       add       rax,0FFFFFFFFFFFFFFFC
       cmp       rax,4
       jge       short M01_L00
       test      rax,rax
       jne       short M01_L03
M01_L01:
       test      dword ptr [rbx],406C0000
       jne       short M01_L04
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       pop       rbx
       ret
M01_L03:
       cmp       [r8],rcx
       je        short M01_L02
       add       r8,8
       dec       rax
       test      rax,rax
       jg        short M01_L03
       jmp       short M01_L01
M01_L04:
       pop       rbx
       jmp       qword ptr [7FF94CB54378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 111
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L01
       mov       rax,offset MT_DotNetTips.Spargine.Core.Data.Models.City[]
       cmp       [rcx],rax
       je        short M02_L00
       mov       r11,7FF94CA10D10
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       eax,[rcx+8]
       test      eax,eax
       jl        short M02_L05
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FF94CA10D08
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FF94CA10CF8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FF94CA10D00
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 210
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M03_L19
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FF94D48CA20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M03_L02
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FF94D48CFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FF94D48CC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L07
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rbx
       mov       rdx,7FF94D48CEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M03_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M03_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rbx
       mov       rdx,7FF94D48CED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rbx
       mov       rdx,7FF94D48CDC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA10C50
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L14
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rbx
       mov       rdx,7FF94D48CDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M03_L20
       jmp       short M03_L18
M03_L16:
       mov       rcx,rsp
       call      M03_L20
       nop
M03_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M03_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M03_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA10C58
       call      qword ptr [r11]
M03_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 596
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FF94D4EFB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M04_L04
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF94D4EFD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FF94D4EFE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M04_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FF94D500C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94CE6E2B0]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF94D500BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF94D4DDC98]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 351
```
```assembly
; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,r9
       test      rbx,rbx
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     eax,cl
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     edx,byte ptr [rdi]
       test      edx,ecx
       jne       short M05_L02
M05_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       xor       ecx,ecx
       movzx     eax,cl
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     edx,byte ptr [rdi]
       test      edx,ecx
       je        short M05_L00
M05_L02:
       call      qword ptr [7FF94D086BB0]
       mov       rdi,rax
       test      rbp,rbp
       je        short M05_L03
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],0
       sete      cl
       test      ecx,ecx
       jne       short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rbp,rdi
M05_L04:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L05
       jmp       short M05_L06
M05_L05:
       mov       rcx,rsi
       mov       rdx,7FF94D3B35F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF94D3C53F8]
       int       3
; Total bytes of code 172
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IComparer`1<Int32>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M06_L00
       test      rdi,rdi
       je        short M06_L01
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,1774B405470
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+28],sil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L00:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M06_L01:
       mov       ecx,9
       call      qword ptr [7FF94CD84F30]
       int       3
; Total bytes of code 140
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        short M07_L05
       test      esi,esi
       jle       short M07_L02
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FF94D4EFAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rbx
       mov       r8d,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF94D3C5458]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M07_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L03
       jmp       short M07_L04
M07_L03:
       mov       rdx,7FF94D4EFAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF94CFAE1A8]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M07_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
; Total bytes of code 140
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateLastName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,1774B408278
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M08_L07
       mov       rbx,[rcx+18]
       test      rbx,rbx
       je        near ptr M08_L08
M08_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M08_L11
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M08_L04
       mov       rcx,rax
       mov       r11,7FF94CA10FD0
       call      qword ptr [r11]
       mov       esi,eax
M08_L01:
       test      esi,esi
       jle       near ptr M08_L05
       mov       rcx,rbx
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M08_L09
       mov       rcx,1774B40B2D0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M08_L15
M08_L02:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M08_L16
       xor       ecx,ecx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbx+10],r8d
       mov       [rbx+14],r8d
       mov       rdx,rbx
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M08_L03:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L04:
       mov       eax,[rax+8]
       test      eax,eax
       jl        short M08_L06
       mov       esi,eax
       jmp       near ptr M08_L01
M08_L05:
       xor       eax,eax
       jmp       short M08_L03
M08_L06:
       call      CORINFO_HELP_OVERFLOW
M08_L07:
       call      qword ptr [7FF94CF6D680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M08_L00
M08_L08:
       call      qword ptr [7FF94D086D90]
       mov       ecx,49
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M08_L09:
       call      qword ptr [7FF94D086BB0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M08_L10
       call      qword ptr [7FF94D086B80]
       mov       rbx,rax
M08_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EEB80
       mov       r8,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M08_L11:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M08_L12
       mov       rcx,rax
       mov       r11,7FF94CA10FC8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M08_L01
M08_L12:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FF94CA10FB8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M08_L14
M08_L13:
       add       esi,1
       jo        near ptr M08_L06
M08_L14:
       mov       rcx,rdi
       mov       r11,7FF94CA10FC0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L13
       jmp       near ptr M08_L01
M08_L15:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1774B40B2C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF94D3C1290
       call      qword ptr [7FF94CB54210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1774B40B2D0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L02
M08_L16:
       mov       ecx,9
       call      qword ptr [7FF94CD84F30]
       int       3
; Total bytes of code 770
```
```assembly
; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r9
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Tester.PersonData..ctor()
       push      rsi
       push      rbx
       mov       rbx,rcx
       lea       rcx,[rbx+8]
       mov       rsi,1B7DD3E0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; System.DateTime.get_UtcNow()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       lea       rcx,[rbp-18]
       mov       rax,7FF9EDF35380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1774B4001C8
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FF9ACA240DC],0
       jne       short M11_L02
M11_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M11_L01
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L01:
       call      qword ptr [7FF94CDF5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L00
; Total bytes of code 105
```
```assembly
; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,1774B400350
       mov       rbp,[rcx]
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M12_L02
M12_L00:
       mov       rdx,rsi
       mov       r9,rbp
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FF94D3C5C98]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rcx,rax
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rsi
       add       r8,rcx
       js        near ptr M12_L08
       mov       rax,2BCA2875F4373FFF
       cmp       r8,rax
       jg        near ptr M12_L08
M12_L01:
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      rcx
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,1A
       add       rax,rdx
       imul      rdx,rax,23C34600
       mov       r10,rcx
       sub       r10,rdx
       jne       near ptr M12_L04
       mov       rdx,0FFFFFF8AA7425000
       cmp       rcx,rdx
       jl        near ptr M12_L05
       mov       rdx,7558BDB000
       cmp       rcx,rdx
       jg        near ptr M12_L05
       cwde
       mov       rdx,2BCA2875F4373FFF
       cmp       r8,rdx
       ja        near ptr M12_L07
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rdx,rcx
       js        near ptr M12_L06
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       jg        near ptr M12_L06
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M12_L07
       cwde
       mov       [rbx],ax
       mov       [rbx+8],rdx
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L02:
       mov       rcx,rbp
       call      qword ptr [7FF94D3C6610]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rcx,rax
       jmp       near ptr M12_L00
M12_L03:
       xor       eax,eax
       mov       rdx,2BCA2875F4373FFF
       test      r8,r8
       cmovge    rax,rdx
       mov       r8,rax
       jmp       near ptr M12_L01
M12_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94CE9FD80]
       mov       rsi,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94CE9FD68]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94CEB42B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L07:
       call      qword ptr [7FF94CDF4AB0]
       int       3
M12_L08:
       test      dil,dil
       je        near ptr M12_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94CE9D9B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 609
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       sub       rsp,28
       mov       eax,ecx
       add       eax,1
       jo        short M13_L00
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94D017D80]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       nop
       add       rsp,28
       ret
M13_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 34
```
```assembly
; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       sub       rsp,28
       movsxd    rax,edx
       imul      rax,15180
       movsxd    rdx,r8d
       imul      rdx,0E10
       add       rax,rdx
       movsxd    rdx,r9d
       imul      rdx,3C
       add       rax,rdx
       movsxd    rdx,dword ptr [rsp+50]
       add       rax,rdx
       imul      rax,0F4240
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rax,rdx
       jg        short M14_L00
       mov       rdx,0F333333333333334
       cmp       rax,rdx
       jl        short M14_L00
       lea       rax,[rax+rax*4]
       add       rax,rax
       mov       [rcx],rax
       add       rsp,28
       ret
M14_L00:
       call      qword ptr [7FF94CD5EBB0]
       int       3
; Total bytes of code 104
```
```assembly
; System.DateTimeOffset.Subtract(System.TimeSpan)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       call      qword ptr [7FF94CE6C168]; System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rdi
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        short M15_L00
       mov       rcx,0C000000000000000
       and       rcx,rax
       or        rdx,rcx
       movsx     rcx,word ptr [rbx]
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        short M15_L01
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        short M15_L01
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FF94CE6C048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovups   xmm0,[rsp+20]
       vmovups   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L00:
       xor       ecx,ecx
       call      qword ptr [7FF94CDF4B10]
       int       3
M15_L01:
       call      qword ptr [7FF94CD5EBB0]
       int       3
; Total bytes of code 178
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M16_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M16_L00
       mov       [rbp-40],rdx
       mov       [rbp-0F8],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0E8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0C8],rcx
       mov       rcx,rbp
       mov       [rbp-0B8],rcx
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M16_L37
M16_L01:
       test      eax,eax
       je        near ptr M16_L38
M16_L02:
       mov       rcx,1774B408290
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M16_L05
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       short M16_L05
M16_L03:
       mov       rdi,[rbp-48]
M16_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      rdi,rdi
       je        near ptr M16_L40
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF94CDFC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       edx,ebx
       call      qword ptr [7FF94CDFC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],rdi
       jmp       short M16_L07
M16_L05:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2FE9D0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M16_L41
M16_L06:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       short M16_L03
M16_L07:
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M16_L19
M16_L08:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       r15,[rbp-4C]
       mov       [rbp-0A8],r15
M16_L09:
       mov       rdx,r15
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M16_L10]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF9ED5A3670
       call      rax
M16_L10:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FF9ACA240DC],0
       je        short M16_L11
       call      qword ptr [7FF9ACA143A8]; CORINFO_HELP_STOP_FOR_GC
M16_L11:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M16_L32
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       r15,[rbp-0A8]
       ja        near ptr M16_L09
       mov       [rbp-5C],eax
       lea       rax,[rbp-5C]
       mov       rdi,[rbp-98]
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r8d,[rdi+18]
       mov       r10d,r8d
       mov       r14d,[rcx+8]
       sub       r14d,r8d
       mov       ecx,r10d
       mov       r8d,r14d
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M16_L33
       mov       ecx,r10d
       lea       r15,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M16_L21
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FF9689B87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r14d
       jg        near ptr M16_L20
       mov       [rbp-68],eax
       mov       [rbp-70],r15
       movsxd    rcx,eax
       lea       rcx,[r15+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M16_L14
       cmp       eax,64
       jb        short M16_L13
       mov       rdx,1774B400290
       mov       rdx,[rdx]
M16_L12:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,eax
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       eax,r10d
       mov       r10,rdx
       shl       eax,2
       mov       eax,[r10+rax+10]
       mov       [rcx],eax
       cmp       r8d,64
       mov       eax,r8d
       jae       short M16_L12
M16_L13:
       cmp       eax,0A
       jb        short M16_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1774B400290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M16_L15
M16_L14:
       add       eax,30
       mov       [rcx-2],ax
M16_L15:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
M16_L16:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M16_L17:
       test      eax,eax
       je        near ptr M16_L31
       mov       ecx,[rbp-68]
       add       [rdi+18],ecx
M16_L18:
       add       r13d,1
       jo        near ptr M16_L26
       cmp       r13d,ebx
       jl        near ptr M16_L08
M16_L19:
       mov       rdi,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FF94CDEE3F0]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M16_L25
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       near ptr M16_L27
       mov       rax,7FF9689B2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M16_L29
       jmp       near ptr M16_L28
M16_L20:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       short M16_L16
M16_L21:
       call      qword ptr [7FF94CCDF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M16_L22
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M16_L23
M16_L22:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M16_L23:
       mov       ecx,r12d
       mov       [rbp-80],r8
       mov       [rbp-78],r9d
       mov       [rbp-90],r15
       mov       [rbp-88],r14d
       lea       r8,[rbp-68]
       mov       [rsp+20],r8
       lea       r8,[rbp-80]
       lea       r9,[rbp-90]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF94D4ACAB0]
       jmp       near ptr M16_L17
M16_L24:
       call      qword ptr [7FF94D2CC3A8]
       test      eax,eax
       jne       short M16_L29
M16_L25:
       mov       [rbp-0A0],rsi
       jmp       near ptr M16_L34
M16_L26:
       call      CORINFO_HELP_OVERFLOW
M16_L27:
       call      qword ptr [7FF94D2CC3A8]
       test      eax,eax
       jne       short M16_L29
M16_L28:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M16_L30
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M16_L24
       mov       rax,7FF9689B2E50
       test      byte ptr [rcx+rax],80
       je        short M16_L25
M16_L29:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF94CB573F0]
       mov       rsi,rax
       jmp       short M16_L25
M16_L30:
       call      CORINFO_HELP_RNGCHKFAIL
M16_L31:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FF94CD0FC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94CDFC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M16_L18
M16_L32:
       mov       ecx,eax
       call      qword ptr [7FF94D2FF8B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M16_L33:
       call      qword ptr [7FF94CD5E9D0]
       int       3
M16_L34:
       mov       rcx,rsp
       call      M16_L44
       jmp       short M16_L36
M16_L35:
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L36:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M16_L35
M16_L37:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M16_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FF94CC047B0]
       mov       ebx,eax
       jmp       near ptr M16_L02
M16_L38:
       call      qword ptr [7FF94D086D78]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M16_L39
       call      qword ptr [7FF94D086B98]
       mov       rsi,rax
M16_L39:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,1B7DD3E86E0
       mov       r8,rsi
       call      qword ptr [7FF94CC0D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M16_L40:
       call      qword ptr [7FF94D086D90]
       mov       ecx,946
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF94CFEE850
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M16_L41:
       cmp       qword ptr [r15+10],0
       jne       short M16_L42
       xor       edx,edx
       mov       [rbp-48],rdx
       jmp       short M16_L43
M16_L42:
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF94D2FE4F0]
       test      eax,eax
       jne       near ptr M16_L06
M16_L43:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M16_L04
M16_L44:
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
       lea       rbp,[rbp+120]
       mov       rcx,1774B408290
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M16_L45
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        near ptr M16_L49
       xor       edx,edx
       call      qword ptr [7FF94CDFC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M16_L46
M16_L45:
       mov       rdx,[rbp-98]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M16_L49
M16_L46:
       cmp       qword ptr [rsi+20],0
       jne       short M16_L47
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M16_L49
M16_L47:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M16_L48
       mov       r14,[rsi+18]
       mov       rcx,[r14+10]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2FEA00]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M16_L49
       mov       rcx,r14
       mov       rdx,[rbp-98]
       call      qword ptr [7FF94D2FE4C0]
       jmp       short M16_L49
M16_L48:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M16_L49:
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
; Total bytes of code 1684
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rsp+30]
       mov       edx,3
       mov       r8d,4
       call      qword ptr [7FF94CCD56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       test      rbx,rbx
       je        near ptr M17_L14
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L14
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L15
M17_L00:
       test      rbx,rbx
       je        near ptr M17_L15
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M17_L15
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+40]
       add       r8d,[rbx+8]
       mov       [rsp+40],r8d
M17_L01:
       mov       r8d,[rsp+40]
       mov       ecx,[rsp+50]
       cmp       r8d,ecx
       ja        near ptr M17_L25
       mov       rdx,[rsp+48]
       mov       eax,r8d
       lea       rdx,[rdx+rax*2]
       sub       ecx,r8d
       cmp       ecx,1
       jb        near ptr M17_L16
       mov       r8,1B7DD3E0C54
       movzx     ecx,word ptr [r8]
       mov       [rdx],cx
       mov       r8d,[rsp+40]
       inc       r8d
       mov       [rsp+40],r8d
M17_L02:
       test      rsi,rsi
       je        near ptr M17_L17
       cmp       dword ptr [rsi+8],0
       je        near ptr M17_L17
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L18
M17_L03:
       test      rsi,rsi
       je        near ptr M17_L18
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M17_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M17_L04:
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M17_L25
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M17_L19
       mov       rcx,1B7DD3EF404
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M17_L05:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       edi,5
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,0F
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M17_L13
M17_L06:
       test      eax,eax
       je        near ptr M17_L20
M17_L07:
       mov       edx,edi
       add       edx,1
       jo        near ptr M17_L12
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,edi
       call      qword ptr [7FF94D017D80]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF94CFD7C30]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbp,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L22
       test      rbp,rbp
       je        near ptr M17_L22
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M17_L22
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+40]
       add       edx,[rbp+8]
       mov       [rsp+40],edx
M17_L08:
       mov       edx,[rsp+40]
       mov       ecx,[rsp+50]
       cmp       edx,ecx
       ja        near ptr M17_L25
       mov       rax,[rsp+48]
       mov       r8d,edx
       lea       rax,[rax+r8*2]
       sub       ecx,edx
       cmp       ecx,1
       jb        near ptr M17_L23
       mov       rdx,1B7DD3E0C54
       movzx     ecx,word ptr [rdx]
       mov       [rax],cx
       mov       edx,[rsp+40]
       inc       edx
       mov       [rsp+40],edx
M17_L09:
       mov       rdx,1774B408268
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M17_L24
       mov       r14,[rcx+18]
M17_L10:
       mov       edx,[r14+8]
       sub       edx,1
       jo        near ptr M17_L12
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF94D017D80]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M17_L27
       mov       r8d,eax
       mov       r15,[r14+r8*8+10]
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L26
       test      r15,r15
       je        near ptr M17_L26
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M17_L26
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[r15+8]
       mov       [rsp+40],ecx
M17_L11:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF94CCD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L12:
       call      CORINFO_HELP_OVERFLOW
M17_L13:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M17_L06
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M17_L07
M17_L14:
       mov       rbx,1B7DD3EF3A8
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L00
M17_L15:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FF94CCD5848]
       jmp       near ptr M17_L01
M17_L16:
       lea       rcx,[rsp+30]
       mov       rdx,1B7DD3E0C48
       call      qword ptr [7FF94CCD58F0]
       jmp       near ptr M17_L02
M17_L17:
       mov       rsi,1B7DD3EF3D0
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L03
M17_L18:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF94CCD5848]
       jmp       near ptr M17_L04
M17_L19:
       lea       rcx,[rsp+30]
       mov       rdx,1B7DD3EF3F8
       call      qword ptr [7FF94CCD58F0]
       jmp       near ptr M17_L05
M17_L20:
       call      qword ptr [7FF94D086D78]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M17_L21
       call      qword ptr [7FF94D086B98]
       mov       rbp,rax
M17_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,1B7DD3EF468
       mov       r8,rbp
       call      qword ptr [7FF94CC0D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M17_L22:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FF94CCD5848]
       jmp       near ptr M17_L08
M17_L23:
       lea       rcx,[rsp+30]
       mov       rdx,1B7DD3E0C48
       call      qword ptr [7FF94CCD58F0]
       jmp       near ptr M17_L09
M17_L24:
       call      qword ptr [7FF94CF6D680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M17_L10
M17_L25:
       call      qword ptr [7FF94CD5E9D0]
       int       3
M17_L26:
       lea       rcx,[rsp+30]
       mov       rdx,r15
       call      qword ptr [7FF94CCD5848]
       jmp       near ptr M17_L11
M17_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1218
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M18_L00
       jmp       short M18_L01
M18_L00:
       mov       rdx,7FF94D3B6D98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M18_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF94D3C4708]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Core.Data.Models.Country, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rbx,0FFFFFFFFFFFFFFA0
M19_L00:
       vmovdqa   xmmword ptr [rbp+rbx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rbx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rbx-20],xmm4
       add       rbx,30
       jne       short M19_L00
       mov       [rbp-40],rcx
       mov       r14,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       edi,r9d
       mov       r15d,[rbp+30]
       lea       rcx,[rbp-1C0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r13,rax
       mov       rcx,rsp
       mov       [rbp-1A0],rcx
       mov       rcx,rbp
       mov       [rbp-190],rcx
       test      rbx,rbx
       je        near ptr M19_L73
       mov       byte ptr [rbp-48],1
       mov       dword ptr [rbp-44],2
       xor       ecx,ecx
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    ecx,edx
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M19_L74
M19_L01:
       test      eax,eax
       je        near ptr M19_L75
M19_L02:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       edx,edx
       cmp       edi,64
       setle     dl
       cmp       edi,5
       cmovge    ecx,edx
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M19_L77
M19_L03:
       test      r8d,r8d
       je        near ptr M19_L78
M19_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       edx,edx
       cmp       r15d,32
       setle     dl
       cmp       r15d,5
       cmovge    ecx,edx
       mov       r10d,ecx
       test      ecx,ecx
       je        near ptr M19_L80
M19_L05:
       test      r10d,r10d
       je        near ptr M19_L81
M19_L06:
       mov       rcx,[r14+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M19_L61
M19_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,esi
       call      qword ptr [7FF94CC0DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       [rbp-0A8],r12
       xor       eax,eax
       mov       [rbp-4C],eax
       test      esi,esi
       jle       near ptr M19_L54
M19_L08:
       mov       [rbp+18],rbx
       mov       r8,[rbx+88]
       test      r8,r8
       je        near ptr M19_L88
       mov       [rbp-0F8],r8
       mov       rdx,r8
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M19_L89
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M19_L56
       mov       rcx,rax
       mov       r11,7FF94CA10DE0
       call      qword ptr [r11]
M19_L09:
       test      eax,eax
       jle       near ptr M19_L70
       mov       rdx,[rbp-0F8]
       mov       r8,rdx
       mov       [rbp-108],r8
       mov       rcx,r8
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M19_L122
       mov       rcx,1774B40B2B0
       mov       rax,[rcx]
       mov       rdx,[rbp-108]
       mov       [rbp-110],rdx
       mov       [rbp-118],rax
       test      rax,rax
       je        near ptr M19_L83
M19_L10:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-128],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       test      rax,rax
       je        near ptr M19_L126
       xor       ecx,ecx
       mov       r8,[rbp-128]
       mov       [r8+10],rcx
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       mov       rax,[rbp-128]
       lea       rcx,[rax+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-128]
       mov       byte ptr [rax+28],0
       mov       [rbp-130],rax
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-138],rdx
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       rdx,[rbp-138]
       mov       [rdx+10],r8d
       mov       [rdx+14],r8d
       lea       r8,[rbp-68]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M19_L11:
       mov       r8,rax
       mov       [rbp-0B0],r8
       test      r8,r8
       je        near ptr M19_L59
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M19_L53
       mov       [rbp-140],r10
       mov       rdx,r10
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M19_L93
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.State[]
       cmp       [rax],rcx
       je        near ptr M19_L57
       mov       rcx,rax
       mov       r11,7FF94CA10E08
       call      qword ptr [r11]
M19_L12:
       test      eax,eax
       jle       near ptr M19_L71
       mov       rdx,[rbp-140]
       mov       r8,rdx
       mov       [rbp-150],r8
       mov       rcx,r8
       call      qword ptr [7FF94D2FFA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M19_L124
       mov       rcx,1774B40B2C0
       mov       rax,[rcx]
       mov       rdx,[rbp-150]
       mov       [rbp-158],rdx
       mov       [rbp-160],rax
       test      rax,rax
       je        near ptr M19_L84
M19_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       test      rax,rax
       je        near ptr M19_L126
       xor       ecx,ecx
       mov       r8,[rbp-170]
       mov       [r8+10],rcx
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1774B405470
       mov       rdx,[rcx]
       mov       rax,[rbp-170]
       lea       rcx,[rax+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-170]
       mov       byte ptr [rax+28],0
       mov       [rbp-178],rax
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-180],rdx
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       rdx,[rbp-180]
       mov       [rdx+10],r8d
       mov       [rdx+14],r8d
       lea       r8,[rbp-78]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FF94CE6E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r9,rax
M19_L14:
       mov       rax,r9
M19_L15:
       mov       [rbp-0B8],rax
       mov       rcx,[r14+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M19_L58
M19_L16:
       call      qword ptr [7FF94CDAC978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-58],rax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-88],xmm0
       lea       rcx,[rbp-98]
       mov       rax,offset MD_Interop+Ole32.<CoCreateGuid>g____PInvoke|1_0(System.Guid*)
       mov       [rbp-1B0],rax
       lea       rax,[M19_L17]
       mov       [rbp-198],rax
       lea       rax,[rbp-1C0]
       mov       [r13+10],rax
       mov       byte ptr [r13+0C],0
       mov       rax,7FF9EE1DEF80
       call      rax
M19_L17:
       mov       byte ptr [r13+0C],1
       cmp       dword ptr [7FF9ACA240DC],0
       je        short M19_L18
       call      qword ptr [7FF9ACA143A8]; CORINFO_HELP_STOP_FOR_GC
M19_L18:
       mov       r8,[rbp-1B8]
       mov       [r13+10],r8
       mov       ebx,eax
       test      ebx,ebx
       jne       near ptr M19_L127
       vmovups   xmm0,[rbp-98]
       vmovups   [rbp-88],xmm0
       mov       r8,1774B400428
       mov       r8,[r8]
       lea       rcx,[rbp-88]
       mov       rdx,1B7DD3F34A0
       call      qword ptr [7FF94CC07198]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       mov       r12,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [r12],rcx
       jne       near ptr M19_L101
       mov       rax,[r12+30]
       cmp       rax,rbx
       je        short M19_L22
       test      rax,rax
       jne       near ptr M19_L69
M19_L19:
       mov       r8d,1
       mov       ecx,32
       cmp       r8d,32
       jg        near ptr M19_L98
       mov       edx,1
M19_L20:
       test      edx,edx
       je        near ptr M19_L128
       test      rbx,rbx
       je        near ptr M19_L100
       mov       edx,[rbx+8]
       cmp       edx,r8d
       jl        near ptr M19_L99
       xor       r10d,r10d
       cmp       edx,ecx
       setle     r10b
M19_L21:
       test      r10d,r10d
       je        near ptr M19_L130
       mov       rdx,rbx
       lea       rcx,[r12+30]
       call      CORINFO_HELP_ASSIGN_REF
M19_L22:
       mov       ecx,5
       call      qword ptr [7FF94CFD79F0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r12,rax
       mov       ecx,edi
       sub       ecx,5
       jo        near ptr M19_L72
       sub       ecx,1
       jo        near ptr M19_L72
       test      ecx,ecx
       jle       near ptr M19_L102
       xor       eax,eax
       cmp       ecx,7FFFFFFF
       setle     al
M19_L23:
       mov       edx,eax
       test      eax,eax
       je        near ptr M19_L87
       test      edx,edx
       je        near ptr M19_L131
M19_L24:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF94CFD7C30]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r8,rax
       mov       rcx,r12
       mov       rdx,1B7DD3E7D38
       call      qword ptr [7FF94CB56B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       mov       r12,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [r12],rcx
       jne       near ptr M19_L105
       mov       rax,[r12+8]
       cmp       rax,rbx
       je        short M19_L27
       test      rax,rax
       jne       near ptr M19_L68
M19_L25:
       mov       ecx,64
       mov       eax,1
       test      eax,eax
       je        near ptr M19_L133
       test      rbx,rbx
       je        near ptr M19_L104
       mov       edx,[rbx+8]
       xor       r8d,r8d
       cmp       edx,ecx
       setle     r8b
M19_L26:
       test      r8d,r8d
       je        near ptr M19_L135
       mov       rdx,rbx
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
M19_L27:
       mov       ecx,edi
       sub       ecx,5
       jo        near ptr M19_L72
       sub       ecx,1
       jo        near ptr M19_L72
       test      ecx,ecx
       jle       near ptr M19_L106
       xor       r12d,r12d
       cmp       ecx,7FFFFFFF
       setle     r12b
M19_L28:
       mov       edx,r12d
       test      r12d,r12d
       je        near ptr M19_L86
       test      edx,edx
       je        near ptr M19_L136
M19_L29:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF94CFD7C30]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FF94CFD79F0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3E7D38
       call      qword ptr [7FF94CB56B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r12,rax
       mov       rcx,[rbp-58]
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rbx],rcx
       jne       near ptr M19_L109
       mov       rax,[rbx+10]
       cmp       rax,r12
       je        short M19_L32
       test      rax,rax
       jne       near ptr M19_L67
M19_L30:
       mov       ecx,64
       mov       eax,1
       test      eax,eax
       je        near ptr M19_L138
       test      r12,r12
       je        near ptr M19_L108
       mov       edx,[r12+8]
       xor       r8d,r8d
       cmp       edx,ecx
       setle     r8b
M19_L31:
       test      r8d,r8d
       je        near ptr M19_L140
       mov       rdx,r12
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M19_L32:
       lea       rcx,[rbp-58]
       mov       rbx,[rbp-0B8]
       test      rbx,rbx
       je        near ptr M19_L55
       mov       r12,[rbx+18]
M19_L33:
       mov       rcx,[rcx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rdx
       jne       near ptr M19_L112
       mov       [rbp-0D0],rcx
       mov       rax,[rcx+18]
       cmp       rax,r12
       je        short M19_L36
       test      rax,rax
       jne       near ptr M19_L64
M19_L34:
       mov       edx,96
       mov       eax,1
       test      eax,eax
       je        near ptr M19_L141
       test      r12,r12
       je        near ptr M19_L111
       mov       eax,[r12+8]
       cmp       eax,edx
       setle     al
       movzx     eax,al
M19_L35:
       test      eax,eax
       je        near ptr M19_L143
       mov       rdx,r12
       lea       rcx,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
M19_L36:
       mov       r12,[rbp+18]
       mov       rax,[r12+58]
       mov       rdx,rax
       mov       [rbp-0C0],rdx
       mov       rcx,[rbp-58]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M19_L115
       mov       [rbp-0D8],rcx
       mov       rax,[rcx+20]
       cmp       rax,rdx
       je        short M19_L39
       test      rax,rax
       jne       near ptr M19_L66
M19_L37:
       mov       r8d,32
       mov       eax,1
       test      eax,eax
       je        near ptr M19_L144
       test      rdx,rdx
       je        near ptr M19_L114
       mov       eax,[rdx+8]
       cmp       eax,r8d
       setle     al
       movzx     eax,al
M19_L38:
       test      eax,eax
       je        near ptr M19_L146
       lea       rcx,[rcx+20]
       call      CORINFO_HELP_ASSIGN_REF
M19_L39:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       byte ptr [rbp-0A0],1
       mov       dword ptr [rbp-9C],1
       mov       ecx,r15d
       test      ecx,ecx
       jle       near ptr M19_L116
       xor       eax,eax
       cmp       r15d,7FFFFFFF
       setle     al
M19_L40:
       mov       r10d,eax
       test      eax,eax
       je        near ptr M19_L85
M19_L41:
       test      r10d,r10d
       je        near ptr M19_L147
M19_L42:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF94CFD7C30]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       [rbp-0C8],rdx
       mov       rcx,[rbp-58]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M19_L118
       mov       [rbp-0E0],rcx
       mov       rax,[rcx+28]
       cmp       rax,rdx
       je        short M19_L45
       test      rax,rax
       jne       near ptr M19_L65
M19_L43:
       test      rdx,rdx
       je        short M19_L44
       cmp       dword ptr [rdx+8],32
       jg        near ptr M19_L149
M19_L44:
       lea       rcx,[rcx+28]
       call      CORINFO_HELP_ASSIGN_REF
M19_L45:
       mov       ecx,[r12+0B8]
       mov       rax,[rbp-58]
       mov       [rbp-0E8],rax
       call      qword ptr [7FF94CFD79F0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       mov       r8,[rbp-0E8]
       cmp       [r8],rcx
       jne       near ptr M19_L119
       mov       rcx,r8
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF94CFEB728]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Phone(System.String)
       mov       rax,[rbp-58]
       mov       [rbp-0F0],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [7FF94CFD77E0]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.Core.Data.Models.City)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       mov       rbx,[rbp-0F0]
       cmp       [rbx],rcx
       jne       near ptr M19_L120
       mov       rcx,rbx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF94CFEB738]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_PostalCode(System.String)
M19_L46:
       lea       rcx,[rbp-58]
       mov       rbx,[rbp-0B0]
       test      rbx,rbx
       je        near ptr M19_L60
       mov       rdx,[rbx+20]
M19_L47:
       mov       rcx,[rcx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M19_L121
       cmp       [rcx],ecx
       call      qword ptr [7FF94CFEB748]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_State(System.String)
M19_L48:
       mov       r8,[rbp-58]
       mov       rbx,[rbp-0A8]
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M19_L63
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M19_L49:
       mov       eax,[rbp-4C]
       add       eax,1
       jo        near ptr M19_L72
       cmp       eax,esi
       mov       [rbp-4C],eax
       jl        short M19_L52
M19_L50:
       mov       rcx,[r14+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M19_L62
M19_L51:
       mov       rdx,rbx
       call      qword ptr [7FF94D3C7C78]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L52:
       mov       rbx,r12
       jmp       near ptr M19_L08
M19_L53:
       mov       r8,[rbp-0B0]
       jmp       short M19_L59
M19_L54:
       mov       rbx,[rbp-0A8]
       jmp       short M19_L50
M19_L55:
       mov       r12,1B7DD3E0008
       jmp       near ptr M19_L33
M19_L56:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M19_L72
       jmp       near ptr M19_L09
M19_L57:
       mov       eax,[rax+8]
       test      eax,eax
       jl        near ptr M19_L72
       jmp       near ptr M19_L12
M19_L58:
       mov       rcx,r14
       mov       rdx,7FF94D3B73A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M19_L16
M19_L59:
       xor       r9d,r9d
       mov       rax,r9
       jmp       near ptr M19_L15
M19_L60:
       mov       rdx,1B7DD3E0008
       jmp       near ptr M19_L47
M19_L61:
       mov       rcx,r14
       mov       rdx,7FF94D3B7380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M19_L07
M19_L62:
       mov       rcx,r14
       mov       rdx,7FF94D3B7C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M19_L51
M19_L63:
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FF94CC0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M19_L49
M19_L64:
       test      r12,r12
       je        near ptr M19_L34
       mov       edx,[rax+8]
       cmp       edx,[r12+8]
       je        near ptr M19_L110
       jmp       near ptr M19_L34
M19_L65:
       test      rdx,rdx
       je        near ptr M19_L43
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       je        near ptr M19_L117
       jmp       near ptr M19_L43
M19_L66:
       test      rdx,rdx
       je        near ptr M19_L37
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       je        near ptr M19_L113
       jmp       near ptr M19_L37
M19_L67:
       test      r12,r12
       je        near ptr M19_L30
       mov       ecx,[rax+8]
       cmp       ecx,[r12+8]
       je        near ptr M19_L107
       jmp       near ptr M19_L30
M19_L68:
       test      rbx,rbx
       je        near ptr M19_L25
       mov       ecx,[rax+8]
       cmp       ecx,[rbx+8]
       je        near ptr M19_L103
       jmp       near ptr M19_L25
M19_L69:
       test      rbx,rbx
       je        near ptr M19_L19
       mov       ecx,[rax+8]
       cmp       ecx,[rbx+8]
       je        near ptr M19_L97
       jmp       near ptr M19_L19
M19_L70:
       xor       eax,eax
       jmp       near ptr M19_L11
M19_L71:
       xor       r9d,r9d
       jmp       near ptr M19_L14
M19_L72:
       call      CORINFO_HELP_OVERFLOW
M19_L73:
       call      qword ptr [7FF94D086D90]
       mov       ecx,15
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,189
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r13
       call      qword ptr [7FF94CD86670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M19_L74:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M19_L01
       lea       rcx,[rbp-48]
       call      qword ptr [7FF94CC047B0]
       mov       esi,eax
       jmp       near ptr M19_L02
M19_L75:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L76
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L76:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,1B7DD3E4368
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M19_L77:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M19_L03
       lea       rcx,[rbp-48]
       call      qword ptr [7FF94CC047B0]
       mov       edi,eax
       jmp       near ptr M19_L04
M19_L78:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L79
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L79:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EECA8
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L80:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M19_L05
       lea       rcx,[rbp-48]
       call      qword ptr [7FF94CC047B0]
       mov       r15d,eax
       jmp       near ptr M19_L06
M19_L81:
       call      qword ptr [7FF94D086D78]
       mov       r12,rax
       test      r12,r12
       jne       short M19_L82
       call      qword ptr [7FF94D086B98]
       mov       r12,rax
M19_L82:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EECD8
       mov       r8,r12
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L83:
       mov       rbx,[rbp+18]
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-120],rax
       mov       rcx,1774B40B2A8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D3C1290
       mov       rax,[rbp-120]
       mov       [rax+18],rcx
       mov       rcx,1774B40B2B0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-120]
       mov       rdx,rax
       mov       [rbp+18],rbx
       mov       [rbp-118],rdx
       jmp       near ptr M19_L10
M19_L84:
       mov       rbx,[rbp+18]
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       mov       rcx,1774B40B2B8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D3C1290
       mov       rax,[rbp-168]
       mov       [rax+18],rcx
       mov       rcx,1774B40B2C0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-168]
       mov       r8,rax
       mov       [rbp+18],rbx
       mov       [rbp-160],r8
       jmp       near ptr M19_L13
M19_L85:
       movzx     eax,byte ptr [rbp-0A0]
       test      al,al
       je        near ptr M19_L41
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M19_L42
M19_L86:
       mov       ecx,1
       jmp       near ptr M19_L29
M19_L87:
       mov       ecx,1
       jmp       near ptr M19_L24
M19_L88:
       mov       rbx,[rbp+18]
       xor       edx,edx
       mov       [rbp+18],rbx
       mov       rax,rdx
       jmp       near ptr M19_L11
M19_L89:
       mov       rbx,[rbp+18]
       mov       rdx,[rbp-0F8]
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M19_L90
       mov       rcx,rax
       mov       r11,7FF94CA10DD8
       call      qword ptr [r11]
       mov       [rbp+18],rbx
       jmp       near ptr M19_L09
M19_L90:
       xor       eax,eax
       mov       [rbp-5C],eax
       mov       rcx,[rbp-0F8]
       mov       r11,7FF94CA10DC8
       call      qword ptr [r11]
       mov       [rbp-100],rax
       jmp       short M19_L92
M19_L91:
       mov       eax,[rbp-5C]
       add       eax,1
       jo        near ptr M19_L72
       mov       [rbp-5C],eax
       mov       rax,[rbp-100]
M19_L92:
       mov       rcx,rax
       mov       r11,7FF94CA10DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M19_L91
       mov       eax,[rbp-5C]
       mov       [rbp+18],rbx
       jmp       near ptr M19_L09
M19_L93:
       mov       rbx,[rbp+18]
       mov       rdx,[rbp-140]
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M19_L94
       mov       rcx,rax
       mov       r11,7FF94CA10E00
       call      qword ptr [r11]
       mov       [rbp+18],rbx
       jmp       near ptr M19_L12
M19_L94:
       xor       eax,eax
       mov       [rbp-6C],eax
       mov       rcx,[rbp-140]
       mov       r11,7FF94CA10DF0
       call      qword ptr [r11]
       mov       [rbp-148],rax
       jmp       short M19_L96
M19_L95:
       mov       eax,[rbp-6C]
       add       eax,1
       jo        near ptr M19_L72
       mov       [rbp-6C],eax
       mov       rax,[rbp-148]
M19_L96:
       mov       rcx,rax
       mov       r11,7FF94CA10DF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M19_L95
       mov       eax,[rbp-6C]
       mov       [rbp+18],rbx
       jmp       near ptr M19_L12
M19_L97:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [rbx],bl
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L22
       jmp       near ptr M19_L19
M19_L98:
       xor       edx,edx
       jmp       near ptr M19_L20
M19_L99:
       xor       r10d,r10d
       jmp       near ptr M19_L21
M19_L100:
       xor       r10d,r10d
       jmp       near ptr M19_L21
M19_L101:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r11,7FF94CA10D80
       call      qword ptr [r11]
       jmp       near ptr M19_L22
M19_L102:
       xor       eax,eax
       jmp       near ptr M19_L23
M19_L103:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [rbx],bl
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L27
       jmp       near ptr M19_L25
M19_L104:
       xor       r8d,r8d
       jmp       near ptr M19_L26
M19_L105:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r11,7FF94CA10D88
       call      qword ptr [r11]
       jmp       near ptr M19_L27
M19_L106:
       xor       r12d,r12d
       jmp       near ptr M19_L28
M19_L107:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [r12],r12b
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[r12+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L32
       jmp       near ptr M19_L30
M19_L108:
       xor       r8d,r8d
       jmp       near ptr M19_L31
M19_L109:
       mov       rcx,rbx
       mov       rdx,r12
       mov       r11,7FF94CA10D90
       call      qword ptr [r11]
       jmp       near ptr M19_L32
M19_L110:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [r12],r12b
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[r12+0C]
       mov       rcx,r10
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L36
       mov       rcx,[rbp-0D0]
       jmp       near ptr M19_L34
M19_L111:
       xor       eax,eax
       jmp       near ptr M19_L35
M19_L112:
       mov       rdx,r12
       mov       r11,7FF94CA10D98
       call      qword ptr [r11]
       jmp       near ptr M19_L36
M19_L113:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [rdx],dl
       mov       r8d,[rax+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L39
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       jmp       near ptr M19_L37
M19_L114:
       xor       eax,eax
       jmp       near ptr M19_L38
M19_L115:
       mov       r11,7FF94CA10DA0
       call      qword ptr [r11]
       jmp       near ptr M19_L39
M19_L116:
       xor       eax,eax
       jmp       near ptr M19_L40
M19_L117:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [rdx],dl
       mov       r8d,[rax+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M19_L45
       mov       rcx,[rbp-0E0]
       mov       rdx,[rbp-0C8]
       jmp       near ptr M19_L43
M19_L118:
       mov       r11,7FF94CA10DA8
       call      qword ptr [r11]
       jmp       near ptr M19_L45
M19_L119:
       mov       rcx,r8
       mov       rdx,rax
       mov       r11,7FF94CA10DB0
       call      qword ptr [r11]
       mov       rcx,[rbp-58]
       mov       [rbp-0F0],rcx
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [7FF94CFD77E0]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.Core.Data.Models.City)
       mov       rbx,[rbp-0F0]
M19_L120:
       mov       rcx,rbx
       mov       rdx,rax
       mov       r11,7FF94CA10DB8
       call      qword ptr [r11]
       jmp       near ptr M19_L46
M19_L121:
       mov       r11,7FF94CA10DC0
       call      qword ptr [r11]
       jmp       near ptr M19_L48
M19_L122:
       call      qword ptr [7FF94D086BB0]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M19_L123
       call      qword ptr [7FF94D086B80]
       mov       rsi,rax
M19_L123:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1B7DD3EEB80
       mov       r8,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M19_L124:
       call      qword ptr [7FF94D086BB0]
       mov       r14,rax
       test      r14,r14
       jne       short M19_L125
       call      qword ptr [7FF94D086B80]
       mov       r14,rax
M19_L125:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,1B7DD3EEB80
       mov       r8,r14
       call      qword ptr [7FF94CD86670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M19_L126:
       mov       ecx,9
       call      qword ptr [7FF94CD84F30]
       int       3
M19_L127:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FF94CB5CC30]
       mov       [r13+74],ebx
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M19_L128:
       call      qword ptr [7FF94D086D78]
       mov       r12,rax
       test      r12,r12
       jne       short M19_L129
       call      qword ptr [7FF94D086B98]
       mov       r12,rax
M19_L129:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r12
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L130:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A13
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A80]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L131:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L132
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L132:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3E86E0
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L133:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L134
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L134:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EF468
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L135:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9B7
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D0179C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L136:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L137
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L137:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3E86E0
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L138:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L139
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L139:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EF468
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L140:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9C9
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D0179C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L141:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L142
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L142:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EF468
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L143:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9DB
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D0179D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L144:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L145
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L145:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3EF468
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L146:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9E5
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D0179F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M19_L147:
       call      qword ptr [7FF94D086D78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L148
       call      qword ptr [7FF94D086B98]
       mov       rbx,rax
M19_L148:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B7DD3E86E0
       mov       r8,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M19_L149:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9F5
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 5785
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx+8],rbx
       je        near ptr M20_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M20_L16
M20_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF94D3C4708]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF94D3A5470]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M20_L09
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       near ptr M20_L09
       jmp       short M20_L03
M20_L01:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+18]
       test      r11,r11
       je        short M20_L06
M20_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94D3A5450]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-40]
M20_L03:
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M20_L05
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M20_L05
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       short M20_L04
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M20_L01
M20_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M20_L05:
       mov       rcx,r14
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF94CDAE688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       jne       short M20_L01
       jmp       near ptr M20_L14
M20_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D3B9010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M20_L02
M20_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+18]
       test      r11,r11
       je        short M20_L11
M20_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94D3A5450]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-40]
M20_L09:
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       short M20_L13
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M20_L12
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M20_L12
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       near ptr M20_L04
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M20_L07
M20_L10:
       test      eax,eax
       jne       short M20_L07
       jmp       short M20_L14
M20_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D3B9010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M20_L08
M20_L12:
       mov       rcx,r14
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF94CDAE688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       jmp       short M20_L10
M20_L13:
       mov       rcx,rax
       mov       r11,7FF94CA10E18
       call      qword ptr [r11]
       jmp       short M20_L10
M20_L14:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       short M20_L18
M20_L15:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M20_L16:
       mov       rcx,rdx
       mov       rdx,7FF94D3B6D98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M20_L00
M20_L17:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M20_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF94CA10E20
       call      qword ptr [r11]
       jmp       short M20_L15
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M20_L19
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,r11
       je        short M20_L19
       mov       r11,7FF94CA10E20
       call      qword ptr [r11]
M20_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 677
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       movsx     rsi,word ptr [rdx]
       mov       rdi,[rdx+8]
       mov       [rsp+60],rbx
       mov       rcx,[rbx+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rcx,rax
       mov       rax,4000000000000000
       or        rcx,rax
       mov       rbp,3FFFFFFFFFFFFFFF
       and       rbp,rdi
       or        rbp,rax
       mov       rax,rbp
       xor       rcx,rax
       shl       rcx,2
       je        near ptr M21_L14
       mov       rcx,0C000000000000000
       and       rcx,rbp
       je        short M21_L00
       mov       rax,4000000000000000
       cmp       rcx,rax
       je        short M21_L03
M21_L00:
       mov       rcx,1774B400350
       mov       r14,[rcx]
       mov       rcx,[r14+8]
       test      rcx,rcx
       je        short M21_L02
M21_L01:
       mov       rdx,rbp
       mov       r9,r14
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FF94D3C5C98]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rcx,rax
       jmp       short M21_L04
M21_L02:
       mov       rcx,r14
       call      qword ptr [7FF94D3C6610]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rcx,rax
       jmp       short M21_L01
M21_L03:
       xor       ecx,ecx
M21_L04:
       mov       r8,rcx
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      r8
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,1A
       add       rax,rdx
       imul      rax,23C34600
       mov       rdx,r8
       sub       rdx,rax
       jne       near ptr M21_L07
       mov       rax,0FFFFFF8AA7425000
       cmp       r8,rax
       jl        near ptr M21_L08
       mov       rax,7558BDB000
       cmp       r8,rax
       jg        near ptr M21_L08
       mov       r14,3FFFFFFFFFFFFFFF
       and       rbp,r14
       sub       rbp,rcx
       js        near ptr M21_L09
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       jg        near ptr M21_L09
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       ja        near ptr M21_L10
       lea       rcx,[rsp+28]
       mov       rax,7FF9EDF35380
       call      rax
       mov       rbx,[rsp+28]
       mov       rcx,1774B4001C8
       mov       r14,[rcx]
       sub       rbx,[r14+8]
       cmp       dword ptr [7FF9ACA240DC],0
       jne       near ptr M21_L11
       mov       ecx,0B2D05E00
       cmp       rbx,rcx
       jae       near ptr M21_L12
M21_L05:
       add       rbx,[r14+10]
M21_L06:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rbp
       mov       rax,4000000000000000
       or        rcx,rax
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       and       rax,rdx
       cmp       rcx,rax
       jg        near ptr M21_L13
       mov       rbx,[rsp+60]
       mov       [rbx+40],si
       mov       [rbx+48],rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M21_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF94CE9FD80]
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF94CB5F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M21_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FF94CE9FD68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M21_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94CEB42B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L10:
       call      qword ptr [7FF94CDF4AB0]
       int       3
M21_L11:
       call      CORINFO_HELP_POLL_GC
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jb        near ptr M21_L05
M21_L12:
       call      qword ptr [7FF94CDF5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M21_L06
M21_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A65
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017AF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L14:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 841
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       cmp       rdi,rbx
       je        near ptr M22_L06
       test      rdi,rdi
       jne       short M22_L05
M22_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       xor       ebp,ebp
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M22_L12
M22_L01:
       test      eax,eax
       je        short M22_L07
M22_L02:
       test      rbx,rbx
       je        near ptr M22_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M22_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M22_L03:
       test      r14d,r14d
       je        near ptr M22_L11
M22_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M22_L05:
       test      rbx,rbx
       je        short M22_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M22_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M22_L00
M22_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M22_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M22_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M22_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M22_L09:
       xor       r14d,r14d
       jmp       near ptr M22_L03
M22_L10:
       xor       r14d,r14d
       jne       near ptr M22_L04
M22_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A73
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017B10]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M22_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M22_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M22_L02
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       cmp       rdi,rbx
       je        near ptr M23_L06
       test      rdi,rdi
       jne       short M23_L05
M23_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       xor       ebp,ebp
       mov       [rsp+28],rcx
       mov       ecx,4B
       xor       edx,edx
       cmp       ebp,4B
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M23_L12
M23_L01:
       test      eax,eax
       je        short M23_L07
M23_L02:
       test      rbx,rbx
       je        near ptr M23_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M23_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M23_L03:
       test      r14d,r14d
       je        near ptr M23_L11
M23_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M23_L05:
       test      rbx,rbx
       je        short M23_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M23_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M23_L00
M23_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M23_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M23_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M23_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M23_L09:
       xor       r14d,r14d
       jmp       near ptr M23_L03
M23_L10:
       xor       r14d,r14d
       jne       near ptr M23_L04
M23_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A87
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M23_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M23_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M23_L02
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+20]
       cmp       rdi,rbx
       je        near ptr M24_L06
       test      rdi,rdi
       jne       short M24_L05
M24_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       xor       ebp,ebp
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M24_L12
M24_L01:
       test      eax,eax
       je        short M24_L07
M24_L02:
       test      rbx,rbx
       je        near ptr M24_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M24_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M24_L03:
       test      r14d,r14d
       je        near ptr M24_L11
M24_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M24_L05:
       test      rbx,rbx
       je        short M24_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M24_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M24_L00
M24_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M24_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M24_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M24_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M24_L09:
       xor       r14d,r14d
       jmp       near ptr M24_L03
M24_L10:
       xor       r14d,r14d
       jne       near ptr M24_L04
M24_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A93
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M24_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M24_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M24_L02
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC07378]; System.Guid.NewGuid()
       mov       r8,1774B400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,1B7DD3F34A0
       call      qword ptr [7FF94CC07198]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+28]
       cmp       rdi,rbx
       je        near ptr M26_L06
       test      rdi,rdi
       jne       short M26_L05
M26_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       ebp,1
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M26_L12
M26_L01:
       test      eax,eax
       je        short M26_L07
M26_L02:
       test      rbx,rbx
       je        near ptr M26_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M26_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M26_L03:
       test      r14d,r14d
       je        near ptr M26_L11
M26_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M26_L05:
       test      rbx,rbx
       je        short M26_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M26_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M26_L00
M26_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M26_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M26_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M26_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M26_L09:
       xor       r14d,r14d
       jmp       near ptr M26_L03
M26_L10:
       xor       r14d,r14d
       jne       near ptr M26_L04
M26_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A13
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A80]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M26_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M26_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M26_L02
; Total bytes of code 387
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+30]
       cmp       rdi,rbx
       je        near ptr M27_L06
       test      rdi,rdi
       jne       short M27_L05
M27_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       xor       ebp,ebp
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M27_L12
M27_L01:
       test      eax,eax
       je        short M27_L07
M27_L02:
       test      rbx,rbx
       je        near ptr M27_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M27_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M27_L03:
       test      r14d,r14d
       je        near ptr M27_L11
M27_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+30]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M27_L05:
       test      rbx,rbx
       je        short M27_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M27_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M27_L00
M27_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M27_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M27_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M27_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M27_L09:
       xor       r14d,r14d
       jmp       near ptr M27_L03
M27_L10:
       xor       r14d,r14d
       jne       near ptr M27_L04
M27_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0AA7
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017A98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M27_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M27_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M27_L02
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+38]
       cmp       rdi,rbx
       je        near ptr M28_L06
       test      rdi,rdi
       jne       short M28_L05
M28_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       xor       ebp,ebp
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M28_L12
M28_L01:
       test      eax,eax
       je        short M28_L07
M28_L02:
       test      rbx,rbx
       je        near ptr M28_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M28_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M28_L03:
       test      r14d,r14d
       je        near ptr M28_L11
M28_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M28_L05:
       test      rbx,rbx
       je        short M28_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M28_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF94CC05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M28_L00
M28_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M28_L07:
       call      qword ptr [7FF94D086D78]
       mov       r14,rax
       test      r14,r14
       jne       short M28_L08
       call      qword ptr [7FF94D086B98]
       mov       r14,rax
M28_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7DD3EF468
       mov       r8,r14
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M28_L09:
       xor       r14d,r14d
       jmp       near ptr M28_L03
M28_L10:
       xor       r14d,r14d
       jne       near ptr M28_L04
M28_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A19
       mov       rdx,7FF94CEAA5E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D017B10]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M28_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M28_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC047B0]
       mov       ecx,eax
       jmp       near ptr M28_L02
; Total bytes of code 384
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M29_L09
       test      edx,edx
       jg        short M29_L01
M29_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       test      rdx,rdx
       jne       short M29_L04
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M29_L02
       jmp       short M29_L03
M29_L01:
       mov       rcx,rbx
       call      qword ptr [7FF94CB5EE80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       short M29_L00
M29_L02:
       mov       rdx,7FF94D264980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M29_L03:
       mov       rcx,rdx
       call      qword ptr [7FF94CB5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M29_L04:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       jne       near ptr M29_L08
       mov       rcx,[rbx+18]
       mov       rdx,1774B401D60
       cmp       rcx,[rdx]
       je        near ptr M29_L10
       mov       rdx,1774B4002D8
       cmp       rcx,[rdx]
       je        near ptr M29_L11
       mov       rdx,1774B4002E0
       xor       esi,esi
       mov       rax,1774B401970
       cmp       rcx,[rdx]
       cmove     rsi,[rax]
M29_L05:
       test      rsi,rsi
       je        short M29_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M29_L06
       jmp       short M29_L07
M29_L06:
       mov       rdx,7FF94D264970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M29_L07:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF94CB54390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M29_L08:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M29_L09:
       mov       ecx,16
       call      qword ptr [7FF94CD5ED30]
       int       3
M29_L10:
       mov       rax,1774B401960
       mov       rsi,[rax]
       jmp       short M29_L05
M29_L11:
       mov       rax,1774B401968
       mov       rsi,[rax]
       jmp       short M29_L05
; Total bytes of code 339
```
```assembly
; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M30_L09
       test      rdi,rdi
       je        near ptr M30_L10
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M30_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M30_L00
       jmp       short M30_L01
M30_L00:
       mov       rcx,rbx
       mov       rdx,7FF94D4E8718
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L01:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M30_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M30_L02
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M30_L02
       jmp       short M30_L03
M30_L02:
       mov       rcx,rbx
       mov       rdx,7FF94D4E8950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L03:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M30_L12
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M30_L04
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M30_L04
       jmp       short M30_L05
M30_L04:
       mov       rcx,rbx
       mov       rdx,7FF94D4E8A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L05:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M30_L18
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M30_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M30_L06
       jmp       short M30_L07
M30_L06:
       mov       rcx,rbx
       mov       rdx,7FF94D4E8F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M30_L08:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M30_L09:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M30_L10:
       mov       ecx,0C
       call      qword ptr [7FF94CD84F30]
       int       3
M30_L11:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [rax+10]
M30_L12:
       cmp       dword ptr [rbp+8],0
       je        short M30_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],70
       jle       short M30_L13
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M30_L13
       jmp       short M30_L14
M30_L13:
       mov       rcx,rbx
       mov       rdx,7FF94D4E9160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rdi
       call      qword ptr [7FF94CF6FF18]
       mov       rax,rbx
       jmp       near ptr M30_L08
M30_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M30_L16
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M30_L16
       jmp       short M30_L17
M30_L16:
       mov       rcx,rbx
       mov       rdx,7FF94D4E90A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF94CFAE1A8]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M30_L18:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M30_L19
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M30_L19
       jmp       short M30_L20
M30_L19:
       mov       rcx,rbx
       mov       rdx,7FF94D4E9060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M30_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF94CF6FC90]
       mov       rax,rbx
       jmp       near ptr M30_L08
; Total bytes of code 601
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M31_L03
       test      rdi,rdi
       je        near ptr M31_L04
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M31_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M31_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M31_L00
       jmp       short M31_L01
M31_L00:
       mov       rdx,7FF94D4E99A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M31_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CE66C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M31_L02:
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,byte ptr [rsp+70]
       mov       [rbx+28],sil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M31_L03:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M31_L04:
       mov       ecx,9
       call      qword ptr [7FF94CD84F30]
       int       3
; Total bytes of code 203
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M32_L04
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M32_L00
       jmp       short M32_L01
M32_L00:
       mov       rcx,rbx
       mov       rdx,7FF94D4E9A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L01:
       mov       rdx,rsi
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M32_L05
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M32_L02
       jmp       short M32_L03
M32_L02:
       mov       rcx,rbx
       mov       rdx,7FF94D4E9BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M32_L03:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M32_L04:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M32_L05:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M32_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M32_L06
       jmp       short M32_L07
M32_L06:
       mov       rcx,rbx
       mov       rdx,7FF94D4E9E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L07:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF94D4D7090]
; Total bytes of code 196
```
```assembly
; System.Reflection.RuntimePropertyInfo.GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       push      rbx
       sub       rsp,20
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M33_L01
       test      rcx,rcx
       je        short M33_L02
M33_L00:
       mov       rax,[rsp+50]
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+58],rax
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF94CD9DEB8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M33_L01:
       xor       ecx,ecx
       test      rcx,rcx
       jne       short M33_L00
M33_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94CE9DED8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 99
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M34_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M34_L00:
       call      qword ptr [7FF94CB541F8]
       int       3
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M35_L06
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M35_L00
       jmp       short M35_L01
M35_L00:
       mov       rcx,rdi
       mov       rdx,7FF94D438238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M35_L01:
       mov       rdx,rsi
       mov       r8,1B7DD3E0008
       mov       r9,1B7DD3F3C50
       call      qword ptr [7FF94D42EF10]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M35_L02
       jmp       short M35_L03
M35_L02:
       mov       rcx,rdi
       mov       rdx,7FF94D4382E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M35_L03:
       vmovdqu   xmm0,xmmword ptr [rbx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rdx,rsi
       lea       r8,[rsp+28]
       call      qword ptr [7FF94D42EF58]; System.Linq.Enumerable.Contains[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       test      eax,eax
       jne       near ptr M35_L07
       mov       rcx,[rdi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M35_L04
       jmp       short M35_L05
M35_L04:
       mov       rcx,rdi
       mov       rdx,7FF94D438308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M35_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M35_L06:
       call      qword ptr [7FF94D086D90]
       mov       ecx,1374
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M35_L07:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 395
```
```assembly
; DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M36_L04
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M36_L02
M36_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF94D4A4258]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M36_L03
M36_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M36_L02:
       mov       rcx,rbx
       mov       rdx,7FF94D4838F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M36_L00
M36_L03:
       mov       rcx,rbx
       mov       rdx,7FF94D4839D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M36_L01
M36_L04:
       call      qword ptr [7FF94D086D90]
       mov       ecx,146A
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB320
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D086B80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 293
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
; System.Reflection.RuntimePropertyInfo.get_Name()
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M38_L01
M38_L00:
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M38_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+28],xmm0
       mov       rdx,[rbx+48]
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CDC51B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+28]
       vmovups   [rsp+38],xmm0
       lea       rcx,[rsp+38]
       call      qword ptr [7FF94CDC5230]; System.MdUtf8String.ToString()
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M38_L00
; Total bytes of code 96
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M39_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M39_L02
       test      rbx,rbx
       je        short M39_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M39_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M39_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M39_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M39_L01:
       call      qword ptr [7FF94CD5EF40]
       int       3
M39_L02:
       test      rbx,rbx
       je        short M39_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M39_L04
M39_L03:
       mov       rax,1B7DD3E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M39_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
M40_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M40_L01
       je        short M40_L01
       je        short M40_L01
       je        short M40_L01
       je        short M40_L01
       je        short M40_L01
       je        short M40_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M40_L03
       jne       short M40_L03
       jne       short M40_L03
       jne       short M40_L03
       jne       short M40_L03
       jne       short M40_L03
       jne       short M40_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
M40_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M40_L02
       jne       short M40_L02
       jne       short M40_L02
       jne       short M40_L02
       jne       short M40_L02
       jne       short M40_L02
       jne       short M40_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
M40_L02:
       mov       rcx,rbx
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       lea       rax,[7FF969423CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
M40_L03:
       cmp       edi,8
       ja        short M40_L04
       ja        short M40_L04
       ja        short M40_L04
       ja        short M40_L04
       ja        short M40_L04
       ja        short M40_L04
       ja        short M40_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       lea       rdx,[7FF9692A43D8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       lea       rax,[M40_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       call      qword ptr [7FF969423C90]
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       call      qword ptr [7FF969423C98]
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       jmp       short M40_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M40_L05
       je        short M40_L05
       je        short M40_L05
       je        short M40_L05
       je        short M40_L05
       je        short M40_L05
       je        short M40_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
M40_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       call      qword ptr [7FF96941B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       call      qword ptr [7FF969423C88]
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       call      qword ptr [7FF969406918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       call      qword ptr [7FF9694295D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       call      qword ptr [7FF969423CA0]
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
M40_L05:
       mov       rcx,rbx
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       call      qword ptr [7FF969423CB0]
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
       jmp       near ptr M40_L01
; Total bytes of code 1841
```
```assembly
; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r9
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Object.GetType()

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+20],1
       mov       byte ptr [rsp+21],0
       mov       byte ptr [rsp+22],1
       mov       word ptr [rsp+24],2B
       lea       rdx,[rsp+20]
       mov       rcx,25CB9C53B88
       call      qword ptr [7FF94D42D518]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DisplayNameOptions)
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
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DisplayNameOptions)
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
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-78],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L29
       mov       rcx,21C27C08B30
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L30
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L30
M01_L00:
       mov       r14,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [r14],r14b
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF94CE1C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF94D42D3B0]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DisplayNameOptions ByRef)
       mov       rcx,[rbp-40]
       mov       rdx,25CB9C53BBC
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
       jmp       near ptr M01_L28
M01_L07:
       mov       rcx,rbx
       mov       rax,[r15+68]
       call      qword ptr [rax+28]
       mov       r8,rax
       mov       rcx,[rbp-40]
       mov       edx,[r8+8]
       mov       [rbp-58],edx
       mov       rdx,rbx
       mov       r9d,[rsi]
       mov       [rbp-60],r9d
       mov       r9w,[rsi+4]
       mov       [rbp-5C],r9w
       lea       r9,[rbp-60]
       mov       [rsp+20],r9
       lea       r9,[rbp-58]
       call      qword ptr [7FF94D42D578]
       jmp       near ptr M01_L28
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
       call      qword ptr [7FF94CE1CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L28
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rsi,[rbp-40]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L28
M01_L16:
       mov       rcx,rbx
       mov       rax,[r15+58]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L25
M01_L17:
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       mov       r12,rax
       jmp       short M01_L20
M01_L18:
       mov       rcx,[rbp-40]
       movzx     r8d,word ptr [rsi+4]
       mov       r9,[rbp-40]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[r12+8]
       jo        short M01_L14
       mov       edx,[r12+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE1CA50]
       jmp       near ptr M01_L28
M01_L19:
       cmp       byte ptr [rsi],0
       je        short M01_L21
       mov       rcx,rbx
       cmp       r15,r13
       jne       short M01_L17
       mov       edx,2
       call      qword ptr [7FF94CAD6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       r12,rax
M01_L20:
       mov       rdi,[rbp-40]
       cmp       [rdi],dil
       test      r12,r12
       je        near ptr M01_L27
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M01_L27
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L26
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L22
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L23
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L23
M01_L21:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       jmp       short M01_L20
M01_L22:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L23:
       mov       [rdi+18],r14d
       jmp       short M01_L27
M01_L24:
       cmp       r15,r13
       jne       near ptr M01_L16
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
M01_L25:
       test      eax,eax
       je        near ptr M01_L19
       cmp       byte ptr [rsi+1],0
       jne       near ptr M01_L15
       jmp       short M01_L28
M01_L26:
       mov       rcx,rdi
       call      qword ptr [7FF94CE1CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L27:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M01_L18
M01_L28:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CE0E3F0]; System.Text.StringBuilder.ToString()
       mov       [rbp-68],rax
       mov       rcx,rsp
       call      M01_L32
       nop
       mov       rax,[rbp-68]
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
M01_L29:
       call      qword ptr [7FF94D094438]
       mov       ecx,1498
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2ED488]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L31
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L31:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L32:
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
       mov       rcx,21C27C08B30
       mov       rdi,[rcx]
       mov       r14,[rbp-40]
       mov       rax,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L33
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF94CE1C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,r14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L35
       lea       rcx,[rdi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L36
       mov       rcx,[rdi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2ED458]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L37:
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
; Total bytes of code 1303
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ProcessGenericType()
       push      rsi
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
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
       mov       rcx,17C980053C8
       mov       r8,[rcx]
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],0
       mov       byte ptr [rsp+32],1
       mov       word ptr [rsp+34],2E
       mov       rcx,rsi
       lea       r9,[rsp+30]
       mov       [rsp+20],r9
       lea       r9,[rsp+40]
       mov       rdx,1BD29CFC8C8
       call      qword ptr [7FF94D3FD590]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32 ByRef, DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FF94CDDE3F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 193
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32 ByRef, DisplayNameOptions)
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
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+90],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rbp,[rsp+0B0]
       mov       rcx,[rsp+90]
       test      rcx,rcx
       je        near ptr M01_L38
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L39
       test      rsi,rsi
       je        near ptr M01_L40
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       r14,[rbx]
       mov       r15,offset MT_System.RuntimeType
       cmp       r14,r15
       jne       near ptr M01_L43
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L14
M01_L01:
       cmp       qword ptr [r13+10],0
       je        near ptr M01_L41
M01_L02:
       mov       rcx,1BD29CF1E80
       cmp       [r13+10],rcx
       jne       near ptr M01_L42
       xor       r12d,r12d
M01_L03:
       test      r12,r12
       jne       near ptr M01_L44
M01_L04:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L17
       cmp       r14,r15
       jne       near ptr M01_L47
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L15
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L15
M01_L05:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L45
M01_L06:
       mov       rcx,1BD29CF1E80
       cmp       [r12+10],rcx
       jne       near ptr M01_L46
       xor       eax,eax
M01_L07:
       test      rax,rax
       jne       near ptr M01_L48
       cmp       r14,r15
       jne       near ptr M01_L50
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L26
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD9CFC0]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L49
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L49
M01_L09:
       test      rax,rax
       je        near ptr M01_L17
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L17
       mov       r12,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L52
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L29
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L10:
       cmp       [rcx],ecx
       call      qword ptr [7FF94CD9CFC0]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L51
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L51
M01_L11:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L28
       lea       rdx,[rax+0C]
       mov       r13d,[rax+8]
       test      r13d,r13d
       je        near ptr M01_L28
       mov       r8,[r12+8]
       mov       eax,[r12+18]
       mov       [rsp+3C],eax
       lea       ecx,[rax+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L27
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L13
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       add       r13d,[rsp+3C]
       mov       [r12+18],r13d
       jmp       near ptr M01_L28
M01_L13:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L14:
       mov       rcx,rbx
       call      qword ptr [7FF94CAA6658]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rbx
       call      qword ptr [7FF94CAA6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       edx,2E
       call      qword ptr [7FF94CDEC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L17:
       cmp       r14,r15
       jne       near ptr M01_L53
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF94CAA6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L18:
       lea       rcx,[rax+0C]
       mov       r8d,[rax+8]
       mov       edx,60
       call      qword ptr [7FF94CDECBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jle       near ptr M01_L54
       mov       r13,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L55
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF94CAA6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L19:
       cmp       [r13],r13b
       test      rax,rax
       je        near ptr M01_L56
       mov       r8d,[rax+8]
       sub       r8d,r12d
       js        near ptr M01_L57
       lea       rdx,[rax+0C]
       mov       r8,[r13+8]
       mov       ebx,[r13+18]
       lea       ecx,[rbx+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L33
       cmp       [r8],r8b
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M01_L25
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L20:
       add       r12d,ebx
       mov       [r13+18],r12d
M01_L21:
       cmp       byte ptr [rbp+2],0
       je        short M01_L24
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L31
       cmp       edx,[rax+8]
       jae       near ptr M01_L58
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L22:
       mov       ebx,[rsp+40]
       cmp       ebx,[rdi]
       jl        near ptr M01_L34
M01_L23:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L32
       cmp       edx,[rax+8]
       jae       near ptr M01_L58
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
M01_L24:
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
M01_L25:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       near ptr M01_L20
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L20
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FF94CAA6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L27:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FF94CDECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L28:
       mov       rcx,[rsp+90]
       mov       r12d,[rcx+18]
       mov       r13,[rcx+8]
       cmp       [r13+8],r12d
       jbe       near ptr M01_L16
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       call      qword ptr [7FF94CAA6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L30:
       mov       eax,r12d
       mov       word ptr [r13+rax*2+10],2E
       inc       dword ptr [rcx+18]
       jmp       near ptr M01_L17
M01_L31:
       mov       edx,3C
       call      qword ptr [7FF94CDEC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L22
M01_L32:
       mov       edx,3E
       call      qword ptr [7FF94CDEC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L24
M01_L33:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FF94CDECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L21
M01_L34:
       cmp       ebx,[rsi+8]
       jae       near ptr M01_L58
       mov       edx,ebx
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FF94D3FD3C8]
       add       ebx,1
       jo        short M01_L37
       cmp       ebx,[rdi]
       je        short M01_L36
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDEC3D8]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L35
       cmp       ebx,[rsi+8]
       jae       near ptr M01_L58
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L36
M01_L35:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDEC3D8]; System.Text.StringBuilder.Append(Char)
M01_L36:
       cmp       ebx,[rdi]
       jl        short M01_L34
       jmp       near ptr M01_L23
M01_L37:
       call      CORINFO_HELP_OVERFLOW
M01_L38:
       call      qword ptr [7FF94D064438]
       mov       ecx,188A
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D064228]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FF94CD76670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L39:
       call      qword ptr [7FF94D064438]
       mov       ecx,1498
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D064228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD76670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       call      qword ptr [7FF94D064438]
       mov       ecx,189A
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D064228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD76670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       mov       rcx,[r13+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r13
       mov       rax,1BD29CF1E80
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L42:
       mov       r12,[r13+10]
       jmp       near ptr M01_L03
M01_L43:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M01_L03
M01_L44:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       ecx,[rax+8]
       mov       [rsp+40],ecx
       jmp       near ptr M01_L04
M01_L45:
       mov       rcx,[r12+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,1BD29CF1E80
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L46:
       mov       rax,[r12+10]
       jmp       near ptr M01_L07
M01_L47:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L07
M01_L48:
       mov       r13,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       ecx,[rbp]
       mov       [rsp+30],ecx
       mov       cx,[rbp+4]
       mov       [rsp+34],cx
       mov       rcx,r13
       mov       r8,rsi
       lea       r9,[rsp+30]
       mov       [rsp+20],r9
       lea       r9,[rsp+40]
       call      qword ptr [7FF94D3FD590]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDEC3D8]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L17
M01_L49:
       xor       eax,eax
       jmp       near ptr M01_L09
M01_L50:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L09
M01_L51:
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L52:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L11
M01_L53:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L18
M01_L54:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94CDEC2A0]; System.Text.StringBuilder.Append(System.String)
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
M01_L55:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L56:
       mov       ecx,2E5
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD766E8]
       int       3
M01_L57:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D09EEE0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2149
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF94CA04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF94D09EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CC0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1BD29CF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

