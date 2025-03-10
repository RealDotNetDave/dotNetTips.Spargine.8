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
       mov       rdx,242B3644380
       mov       [rax+10],rdx
       mov       rdx,242B36443A8
       mov       [rax+18],rdx
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.Create[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Object[])
       call      qword ptr [7FFE5CD6DB78]; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
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
       call      qword ptr [7FFE5C416DF0]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FFE5C4C4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FFE5C9D44C8]
       mov       ecx,1804
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA0CE58]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF750]
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
       mov       rdx,1ED64C00428
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
       mov       r8,22DF2D54380
       call      qword ptr [7FFE5C76C930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FFE5C75E3F0]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE5C6CEFE8]
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
       call      qword ptr [7FFE5C4D43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FFE5C7DDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       call      qword ptr [7FFE5C76CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L45
M01_L09:
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L12
       mov       r12,[rsp+40]
       test      r12,r12
       jne       near ptr M01_L18
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
       mov       r11,7FFE5C3909E8
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
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L22:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L17
M01_L23:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE5C76CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L24:
       xor       edx,edx
       jmp       near ptr M01_L00
M01_L25:
       xor       r12d,r12d
       jmp       short M01_L19
M01_L26:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L17
M01_L27:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE5C76C3D8]; System.Text.StringBuilder.Append(Char)
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
       mov       r11,7FFE5C3909F8
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
       mov       r11,7FFE5C3909F0
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
       call      qword ptr [7FFE5C76C258]
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
       jmp       near ptr M01_L19
M01_L52:
       mov       r12,22DF2D40008
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
       call      qword ptr [7FFE5C76C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFE5C76C258]
       jmp       near ptr M01_L01
M01_L54:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFE5C76C258]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFE5C76C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L55:
       mov       r13,[rsp+30]
       mov       [rsp+60],r13
       mov       ebx,[rsp+70]
       mov       [rsp+68],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+60]
       call      qword ptr [7FFE5C76C558]
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
       call      qword ptr [7FFE5C6CF180]
       int       3
M01_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFE5C6CF180]
       int       3
M01_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFE5C6CF180]
       int       3
M01_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFE5C6CF180]
       int       3
M01_L60:
       mov       ecx,21
       call      qword ptr [7FFE5C6CED30]
       int       3
M01_L61:
       call      qword ptr [7FFE5C6CF198]
       int       3
M01_L62:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M01_L63:
       call      qword ptr [7FFE5C6CF168]
       int       3
M01_L64:
       mov       ecx,2F1
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C6F66E8]
       int       3
M01_L65:
       mov       rcx,rdi
       mov       rdx,22DF2D543A8
       mov       r11,7FFE5C3909E0
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
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22DF2D40008
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
       call      qword ptr [7FFE5CD8DDB8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltinTypes()
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
       mov       rbx,19979808B28
       cmp       qword ptr [rbx],0
       je        short M01_L02
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE5C59DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE5CD8DB90]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltinTypes()
       mov       rsi,[rbx]
       test      rsi,rsi
       jne       short M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FFE5C704F30]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FFE5C3A0B08
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
       call      qword ptr [7FFE5C74C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FFE5C456E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FFE5C504390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FFE5CD9DC38]; DotNetTips.Spargine.Core.TypeHelper.DoesObjectEqualInstance(System.Object, System.Object)
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
       call      qword ptr [7FFE5CA044C8]
       mov       ecx,17BE
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA042B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L01:
       call      qword ptr [7FFE5CA044C8]
       mov       ecx,181A
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA042B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
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
       mov       rcx,1FCB2C00170
       mov       rcx,[rcx]
       mov       rdx,23D44A74380
       mov       r8d,1
       call      qword ptr [7FFE5CD8E1A8]; DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.AppDomain, System.Type, Boolean)
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
       call      qword ptr [7FFE5C4E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L12
       mov       r8d,[rbx+8]
       test      r8d,r8d
       jl        near ptr M01_L07
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableExtensions.ToArray[[System.Reflection.Assembly, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.Assembly>, Int32)
       call      qword ptr [7FFE5CDC7630]; System.Collections.Immutable.ImmutableExtensions.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rsi,rax
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1FCB2C054E0
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
       call      qword ptr [7FFE5C71BB20]; System.Reflection.RuntimeAssembly.get_DefinedTypes()
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
       call      qword ptr [7FFE5C59DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FFE5CF95998]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jle       short M01_L05
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L02
       mov       rcx,[rbp-28]
       mov       rdx,rdi
       call      qword ptr [7FFE5C59E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE5C9F44C8]
       mov       ecx,183E
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       call      qword ptr [7FFE5C9F44C8]
       mov       ecx,182C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[System.Reflection.Assembly, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4E4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rsi,[rax]
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,40B
       mov       rdx,7FFE5CD7FB48
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CDC6388]
       int       3
M01_L12:
       mov       rcx,rax
       mov       r11,7FFE5C3A0B28
       call      qword ptr [r11]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L13
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CDC78D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C706718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.Reflection.Assembly[]
       call      qword ptr [7FFE5C4E4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FFE5CC4FDE0]
       mov       rcx,rax
       call      qword ptr [7FFE5CDC5110]
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
       mov       rdx,1BFBC254380
       call      qword ptr [7FFE5CD6DFF8]; DotNetTips.Spargine.Core.TypeHelper.GetMembersWithAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)
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
       sub       rsp,88
       mov       [rsp+80],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L52
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.MemberInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,17F2A4055B0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFE5C417330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M01_L01
M01_L00:
       mov       rcx,1BFBC242DB8
       cmp       rax,rcx
       je        short M01_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C417330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M01_L00
M01_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       [rsi],rcx
       jne       near ptr M01_L53
M01_L02:
       mov       rbp,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rbx],rbp
       jne       short M01_L04
       mov       r14d,8
       jmp       short M01_L05
M01_L03:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rax,[rsp+70]
       cmp       rax,rbp
       jne       near ptr M01_L39
       jmp       near ptr M01_L12
M01_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
M01_L05:
       cmp       r14d,2
       je        near ptr M01_L57
       cmp       r14d,10
       je        near ptr M01_L13
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       cmp       [rbx],rbp
       jne       near ptr M01_L11
       test      rdx,rdx
       je        near ptr M01_L48
       mov       r14,offset MT_System.RuntimeType
       cmp       [rdx],r14
       jne       near ptr M01_L54
       mov       r15,rdx
M01_L06:
       test      r15,r15
       je        near ptr M01_L55
       cmp       [r15],r14
       jne       near ptr M01_L55
       mov       r13,rbx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFE5C7263A0]; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L56
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
       call      qword ptr [7FFE5C7261D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       je        short M01_L08
       jmp       near ptr M01_L56
M01_L07:
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
       call      qword ptr [7FFE5C7261D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L56
M01_L08:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C70EB68]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       r13,rax
       test      r13,r13
       jne       short M01_L07
       xor       r13d,r13d
M01_L09:
       movzx     eax,r13b
M01_L10:
       test      eax,eax
       je        near ptr M01_L28
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L58
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L28
M01_L11:
       mov       rcx,rbx
       mov       r8d,1
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       short M01_L09
M01_L12:
       test      rdx,rdx
       je        near ptr M01_L48
       jmp       short M01_L15
M01_L13:
       mov       rcx,rbx
       mov       rdx,offset MT_System.Reflection.PropertyInfo
       cmp       [rcx],rdx
       jne       short M01_L16
M01_L14:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE5C724018]; System.Attribute.InternalIsDefined(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M01_L10
M01_L15:
       cmp       [rdx],r14
       jne       near ptr M01_L67
       cmp       [rdx],dl
       mov       rax,rdx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFE5C4C43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M01_L14
M01_L17:
       mov       r8,rax
       mov       [rsp+50],r8
       test      r8,r8
       je        near ptr M01_L49
       cmp       [r8],r14
       jne       near ptr M01_L49
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FFE5C7263A0]; System.Reflection.PseudoCustomAttribute.IsDefined(System.Reflection.RuntimeMethodInfo, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L68
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+40],rax
       mov       rcx,rbx
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rsp+40]
       mov       r8,[rsp+50]
       xor       r9d,r9d
       call      qword ptr [7FFE5C7261D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L68
       test      byte ptr [rbx+5C],40
       je        short M01_L19
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       mov       rax,rcx
       test      rax,rax
       je        near ptr M01_L69
       mov       rcx,rax
       call      System.RuntimeTypeHandle.IsInterface(System.RuntimeType)
M01_L18:
       test      eax,eax
       je        near ptr M01_L40
M01_L19:
       xor       edx,edx
M01_L20:
       mov       rax,rdx
       test      rax,rax
       jne       near ptr M01_L43
M01_L21:
       xor       eax,eax
M01_L22:
       movzx     edx,al
M01_L23:
       test      edx,edx
       je        short M01_L24
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L44
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
M01_L24:
       inc       r12d
       cmp       r15d,r12d
       jle       short M01_L27
M01_L25:
       mov       ecx,r12d
       mov       rbx,[r13+rcx*8+10]
       test      rbx,rbx
       je        near ptr M01_L45
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFE5C417330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M01_L30
M01_L26:
       mov       rcx,1BFBC242DB8
       cmp       rax,rcx
       je        short M01_L31
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C417330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M01_L26
       jmp       short M01_L30
M01_L27:
       mov       rax,rdi
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L28:
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M01_L59
       mov       rcx,rbx
       mov       edx,3C
       call      qword ptr [7FFE5C40A670]; System.RuntimeType.GetMembers(System.Reflection.BindingFlags)
       mov       r13,rax
M01_L29:
       xor       r12d,r12d
       mov       r15d,[r13+8]
       test      r15d,r15d
       jle       short M01_L27
       jmp       near ptr M01_L25
M01_L30:
       mov       rcx,offset MT_System.Attribute
       cmp       [rsi],rcx
       jne       near ptr M01_L46
M01_L31:
       mov       rax,[rbx]
       mov       [rsp+70],rax
       cmp       rax,rbp
       jne       short M01_L32
       mov       edx,8
       jmp       short M01_L33
M01_L32:
       mov       rcx,rbx
       mov       rdx,[rax+40]
       call      qword ptr [rdx+28]
       mov       edx,eax
M01_L33:
       cmp       edx,2
       je        near ptr M01_L66
       cmp       edx,10
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       cmp       [rsp+70],rcx
       jne       short M01_L35
M01_L34:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       rdx,[rsp+70]
       cmp       rdx,rcx
       jne       near ptr M01_L61
       test      rax,rax
       je        near ptr M01_L48
       cmp       [rax],r14
       jne       near ptr M01_L60
       jmp       short M01_L36
M01_L35:
       mov       rdx,rbx
       call      qword ptr [7FFE5C4C43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M01_L34
M01_L36:
       mov       [rsp+58],rax
       test      rax,rax
       je        near ptr M01_L47
       cmp       [rax],r14
       jne       near ptr M01_L47
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbx+50]
       mov       r8,[rsp+58]
       xor       r9d,r9d
       call      qword ptr [7FFE5C7261D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       je        near ptr M01_L62
M01_L37:
       mov       edx,1
M01_L38:
       jmp       near ptr M01_L23
M01_L39:
       mov       rcx,rbx
       mov       r8d,1
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L22
M01_L40:
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       call      qword ptr [7FFE5C417330]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L41
       mov       rcx,r14
       cmp       [rdx],rcx
       jne       near ptr M01_L50
M01_L41:
       mov       rax,rdx
       test      rax,rax
       mov       [rsp+30],rax
       je        near ptr M01_L19
       mov       rcx,[rbx+50]
       call      System.RuntimeMethodHandle.GetSlot(System.RuntimeMethodHandleInternal)
       mov       [rsp+7C],eax
       mov       rcx,[rsp+30]
       call      System.RuntimeTypeHandle.GetNumVirtuals(System.RuntimeType)
       mov       ecx,[rsp+7C]
       cmp       eax,ecx
       jle       near ptr M01_L19
       mov       edx,ecx
       mov       rax,[rsp+30]
       mov       [rsp+30],rax
       mov       rcx,rax
       call      System.RuntimeTypeHandle.GetMethodAt(System.RuntimeType, Int32)
       mov       rdx,rax
       mov       rcx,[rsp+30]
       call      qword ptr [7FFE5C416400]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L42
       mov       rcx,rbp
       cmp       [rdx],rcx
       jne       near ptr M01_L51
M01_L42:
       mov       rcx,rdx
       mov       rdx,rcx
       jmp       near ptr M01_L20
M01_L43:
       mov       [rsp+48],rax
       mov       rcx,[rax+38]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+38],rax
       mov       rcx,[rsp+48]
       call      System.RuntimeMethodHandle.GetMethodDef(System.IRuntimeMethodInfo)
       mov       edx,eax
       mov       dword ptr [rsp+20],1
       mov       rcx,[rsp+38]
       mov       r8,[rsp+50]
       xor       r9d,r9d
       call      qword ptr [7FFE5C7261D8]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L68
       mov       rax,[rsp+48]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C70EB68]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       rcx,rax
       test      rcx,rcx
       mov       rax,rcx
       jne       short M01_L43
       jmp       near ptr M01_L21
M01_L44:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L24
M01_L45:
       mov       ecx,0D9
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C6E66E8]
       int       3
M01_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA0E4F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA0CE58]
       mov       rdi,rax
       mov       ecx,0E9
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L48:
       mov       ecx,0E9
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C6E66E8]
       int       3
M01_L49:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE5CA0CE58]
       mov       r14,rax
       mov       ecx,0E9
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L50:
       mov       rdx,rax
       call      qword ptr [7FFE5C4C43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L51:
       mov       rdx,rax
       call      qword ptr [7FFE5C4C43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L52:
       call      qword ptr [7FFE5C9D44C8]
       mov       ecx,14A0
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5C9D42B8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA0E4F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       r15,rax
       jmp       near ptr M01_L06
M01_L55:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA0CE58]
       mov       rbx,rax
       mov       ecx,0E9
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L56:
       mov       r13d,1
       jmp       near ptr M01_L09
M01_L57:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFE5C4C43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE5C724078]
       jmp       near ptr M01_L10
M01_L58:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L28
M01_L59:
       mov       rcx,rbx
       mov       edx,3C
       mov       rax,[rbx]
       mov       rax,[rax+88]
       call      qword ptr [rax+20]
       mov       r13,rax
       jmp       near ptr M01_L29
M01_L60:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L36
M01_L61:
       mov       rcx,rbx
       mov       rdx,rax
       mov       r8d,1
       mov       rax,[rsp+70]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L37
M01_L62:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFE5C724120]
       cmp       byte ptr [rax+0D],0
       je        short M01_L65
       mov       rcx,rbx
       call      qword ptr [7FFE5C7240F0]
       mov       rcx,rbx
       mov       [rsp+68],rax
       mov       rdx,rax
       call      qword ptr [7FFE5C724030]
       jmp       short M01_L64
M01_L63:
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,[rsp+60]
       xor       r8d,r8d
       mov       [rsp+60],rcx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L37
       mov       rax,[rsp+60]
       mov       r8,[rsp+68]
       mov       rcx,rax
       mov       [rsp+68],r8
       mov       rdx,r8
       call      qword ptr [7FFE5C724030]
       mov       rdx,rax
       mov       rax,rdx
M01_L64:
       mov       [rsp+60],rax
       test      rax,rax
       jne       short M01_L63
M01_L65:
       xor       edx,edx
       jmp       near ptr M01_L38
M01_L66:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFE5C4C43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE5C724078]
       mov       edx,eax
       jmp       near ptr M01_L23
M01_L67:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L17
M01_L68:
       mov       eax,1
       jmp       near ptr M01_L22
M01_L69:
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       setne     al
       movzx     eax,al
       jmp       near ptr M01_L18
; Total bytes of code 2469
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
       sub       rsp,0E8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0E0],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+0E0],1
       mov       dword ptr [rsp+0E4],2
       mov       esi,2
       xor       edx,edx
       mov       [rsp+0E0],rdx
       mov       edi,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L63
M00_L01:
       test      eax,eax
       je        near ptr M00_L64
M00_L02:
       xor       edx,edx
       mov       [rsp+0E0],rdx
       mov       ebp,14
       mov       edx,1
       mov       r8d,edx
       test      edx,edx
       je        near ptr M00_L66
M00_L03:
       test      r8d,r8d
       je        near ptr M00_L67
M00_L04:
       mov       rdx,2803C408260
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L69
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M00_L70
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L71
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       short M00_L06
       mov       rcx,[rax+8]
       mov       r11,7FFE5C391040
       call      qword ptr [r11]
       jmp       short M00_L07
M00_L06:
       mov       rcx,rax
       mov       r11,7FFE5C391038
       call      qword ptr [r11]
M00_L07:
       test      eax,eax
       jle       near ptr M00_L28
       mov       rcx,r14
       call      qword ptr [7FFE5CC3FD80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L75
       mov       rcx,2803C40B2C8
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L77
M00_L08:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M00_L51
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2803C405470
       mov       rdx,[rcx]
       lea       rcx,[r13+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+10],r8d
       mov       [r14+14],r8d
       mov       rdx,r14
       lea       r8,[rsp+0B0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C974F78]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       test      rax,rax
       je        near ptr M00_L17
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L30
       mov       rcx,[rax+8]
       mov       r11,7FFE5C391058
       call      qword ptr [r11]
M00_L10:
       test      eax,eax
       jle       near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFE5C974F78]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       mov       r15,rax
       test      r15,r15
       je        near ptr M00_L78
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L79
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L37
       mov       rcx,[rax+8]
       mov       r11,7FFE5C391080
       call      qword ptr [r11]
M00_L11:
       test      eax,eax
       jle       near ptr M00_L42
       mov       rcx,r15
       call      qword ptr [7FFE5CC3FD80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L83
       mov       rcx,2803C40B2E8
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L85
M00_L12:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M00_L51
       xor       ecx,ecx
       mov       [r12+10],rcx
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2803C405470
       mov       rdx,[rcx]
       lea       rcx,[r12+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r12+28],0
       mov       r8d,1
       mov       rdx,r12
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Int32)
       call      qword ptr [7FFE5CC74EE8]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+0A8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r15,rax
M00_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CB77270]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       test      rax,rax
       je        near ptr M00_L17
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L40
       mov       rcx,[rax+8]
       mov       r11,7FFE5C391090
       call      qword ptr [r11]
M00_L14:
       test      eax,eax
       jle       near ptr M00_L17
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CB77270]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       mov       r15,rax
       test      r15,r15
       je        near ptr M00_L43
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L39
       mov       rcx,[rax+8]
       mov       r11,7FFE5C3910B8
       call      qword ptr [r11]
M00_L15:
       test      eax,eax
       jle       near ptr M00_L17
       mov       rcx,r15
       call      qword ptr [7FFE5CC3FD80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L48
       mov       rcx,2803C40B2F8
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L50
M00_L16:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M00_L51
       xor       ecx,ecx
       mov       [r12+10],rcx
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2803C405470
       mov       rdx,[rcx]
       lea       rcx,[r12+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r12+28],0
       mov       r8d,1
       mov       rdx,r12
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Int32)
       call      qword ptr [7FFE5CC74EE8]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+0A0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M00_L17:
       mov       rdx,2803C408270
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L52
       mov       r13,[rcx+18]
M00_L18:
       test      r13,r13
       je        near ptr M00_L53
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L38
       mov       rcx,[rax+8]
       mov       r11,7FFE5C3910E0
       call      qword ptr [r11]
M00_L19:
       test      eax,eax
       jle       near ptr M00_L41
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       mov       r8,2C0CA510008
       mov       r9,2C0CA51F328
       call      qword ptr [7FFE5CC74C60]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       r12,rax
       mov       rcx,2803C40B2D8
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L58
M00_L20:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFE5C8F7D50]; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IComparer`1<Int32>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       r8d,1
       mov       rdx,r15
       mov       rcx,offset MD_System.Linq.Enumerable.Take[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FFE5CC74BE8]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+98]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r12,rax
M00_L21:
       mov       rcx,2803C408278
       mov       rcx,[rcx]
       call      qword ptr [7FFE5C8C5F08]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE5CC74918]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FFE5CC74018]; DotNetTips.Spargine.Tester.PersonData..ctor()
       call      qword ptr [7FFE5C765B90]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0D0]
       mov       r8d,1
       call      qword ptr [7FFE5C7DC780]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+0C8],rcx
       mov       ecx,1
       mov       edx,5A
       call      qword ptr [7FFE5C934D68]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L62
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+0C8]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE5C7DCB58]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+0D0]
       lea       rdx,[rsp+0B8]
       mov       r8,[rsp+0C8]
       call      qword ptr [7FFE5C7DC6F0]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+0B8]
       vmovups   [r13+38],xmm0
       mov       ecx,[r14+0B8]
       call      qword ptr [7FFE5C934DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       call      qword ptr [7FFE5C934B88]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+0B8]
       call      qword ptr [7FFE5C934DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C935A88]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rsp+20],ebp
       mov       rdx,[r13+10]
       mov       r8d,esi
       mov       r9d,edi
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Core.Data.Models.Country, Int32, Int32, Int32)
       call      qword ptr [7FFE5CC74600]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Core.Data.Models.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C950F00]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r13+38]
       vmovups   [rsp+60],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+60]
       call      qword ptr [7FFE5C950F10]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r13+8]
       mov       rcx,r15
       call      qword ptr [7FFE5C950F20]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r13+18]
       mov       rcx,r15
       call      qword ptr [7FFE5C950F30]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r13+20]
       mov       rcx,r15
       call      qword ptr [7FFE5C950F40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFE5CC77750]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C950F50]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r13+28]
       mov       rcx,r15
       call      qword ptr [7FFE5C950F60]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r13+30]
       mov       rcx,r15
       call      qword ptr [7FFE5C950F70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE5C4DEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,2803C40B308
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M00_L27
M00_L22:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FFE5C8CC138]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       mov       rcx,2803C40B310
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L23:
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
       call      qword ptr [7FFE5C8F7E40]; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>)
       call      qword ptr [7FFE5C8F5FB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       near ptr M00_L34
M00_L24:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       r12,[r14]
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rsp+48],rax
       cmp       r12,rax
       jne       near ptr M00_L59
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C74A388]; System.Reflection.RuntimePropertyInfo.GetValue(System.Object, System.Object[])
       jmp       near ptr M00_L35
M00_L25:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2803C40B300
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CD7A070
       mov       [rsi+18],rcx
       mov       rcx,2803C40B310
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L23
M00_L26:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r9,rax
       jmp       near ptr M00_L32
M00_L27:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2803C40B300
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CD7A058
       mov       [rbp+18],rcx
       mov       rcx,2803C40B308
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbp
       jmp       near ptr M00_L22
M00_L28:
       xor       r14d,r14d
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,offset MT_System.String
       mov       r14,[rsp+40]
       cmp       [r14],rcx
       jne       near ptr M00_L26
       jmp       short M00_L31
M00_L30:
       mov       rcx,rax
       mov       r11,7FFE5C391050
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L31:
       cmp       [r14],r14b
       mov       r9,r14
M00_L32:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       lea       rcx,[rsp+88]
       mov       r8,r12
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4DF348]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       r8,[rsp+50]
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFE5CD7E118]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
M00_L33:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M00_L24
M00_L34:
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       call      qword ptr [7FFE5CD7E148]; DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+70],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+70]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CDD54B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L35:
       mov       r9,rax
       mov       [rsp+40],r9
       mov       rdx,r9
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+38],rax
       test      rax,rax
       jne       near ptr M00_L60
M00_L36:
       cmp       qword ptr [rsp+40],0
       je        near ptr M00_L33
       mov       rdx,[rsp+48]
       cmp       r12,rdx
       jne       near ptr M00_L61
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C74A2C0]; System.Reflection.RuntimePropertyInfo.get_Name()
       mov       r12,rax
       jmp       near ptr M00_L29
M00_L37:
       mov       rcx,rax
       mov       r11,7FFE5C391078
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L38:
       mov       rcx,rax
       mov       r11,7FFE5C3910D8
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,rax
       mov       r11,7FFE5C3910B0
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L40:
       mov       rcx,rax
       mov       r11,7FFE5C391088
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L41:
       xor       r12d,r12d
       jmp       near ptr M00_L21
M00_L42:
       xor       r15d,r15d
       jmp       near ptr M00_L13
M00_L43:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,49
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L44:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L45
       mov       rcx,rax
       mov       r11,7FFE5C3910A8
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L45:
       xor       r13d,r13d
       mov       rcx,r15
       mov       r11,7FFE5C391098
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M00_L47
M00_L46:
       add       r13d,1
       jo        near ptr M00_L62
M00_L47:
       mov       rcx,r12
       mov       r11,7FFE5C3910A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L46
       mov       eax,r13d
       jmp       near ptr M00_L15
M00_L48:
       call      qword ptr [7FFE5C9E42E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L49
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M00_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F328
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L50:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,2803C40B2F0
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2803C40B2F8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L51:
       mov       ecx,9
       call      qword ptr [7FFE5C6F4F30]
       int       3
M00_L52:
       call      qword ptr [7FFE5C8C5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M00_L18
M00_L53:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,49
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M00_L54:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L55
       mov       rcx,rax
       mov       r11,7FFE5C3910D0
       call      qword ptr [r11]
       jmp       near ptr M00_L19
M00_L55:
       xor       r15d,r15d
       mov       rcx,r13
       mov       r11,7FFE5C3910C0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M00_L57
M00_L56:
       add       r15d,1
       jo        near ptr M00_L62
M00_L57:
       mov       rcx,r12
       mov       r11,7FFE5C3910C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L56
       mov       eax,r15d
       jmp       near ptr M00_L19
M00_L58:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,2803C40B2D0
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2803C40B2D8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L20
M00_L59:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       mov       r10,[r12+58]
       call      qword ptr [r10+38]
       jmp       near ptr M00_L35
M00_L60:
       mov       rcx,rax
       mov       r11,7FFE5C3910E8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M00_L36
       mov       rcx,r14
       mov       rdx,[r12+40]
       call      qword ptr [rdx+30]
       mov       r14,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       mov       rcx,[rsp+38]
       mov       edx,2C
       call      qword ptr [7FFE5CC3FEA0]
       mov       r9,rax
       lea       rcx,[rsp+78]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4DF348]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       r8,[rsp+50]
       mov       rdx,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFE5CD7E118]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M00_L33
M00_L61:
       mov       rcx,r14
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       jmp       near ptr M00_L29
M00_L62:
       call      CORINFO_HELP_OVERFLOW
M00_L63:
       movzx     ecx,byte ptr [rsp+0E0]
       test      cl,cl
       je        near ptr M00_L01
       lea       rcx,[rsp+0E0]
       call      qword ptr [7FFE5C5847B0]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L64:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L65
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M00_L65:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F450
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L66:
       movzx     ecx,byte ptr [rsp+0E0]
       test      cl,cl
       je        near ptr M00_L03
       lea       rcx,[rsp+0E0]
       call      qword ptr [7FFE5C5847B0]
       mov       ebp,eax
       jmp       near ptr M00_L04
M00_L67:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L68
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M00_L68:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F480
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L69:
       call      qword ptr [7FFE5C8C5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L05
M00_L70:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,49
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L71:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L72
       mov       rcx,rax
       mov       r11,7FFE5C391030
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L72:
       xor       r15d,r15d
       mov       rcx,r14
       mov       r11,7FFE5C391020
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M00_L74
M00_L73:
       add       r15d,1
       jo        near ptr M00_L62
M00_L74:
       mov       rcx,r13
       mov       r11,7FFE5C391028
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L73
       mov       eax,r15d
       jmp       near ptr M00_L07
M00_L75:
       call      qword ptr [7FFE5C9E42E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L76
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M00_L76:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F328
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L77:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,2803C40B2C0
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2803C40B2C8
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L78:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,49
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M00_L79:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L80
       mov       rcx,rax
       mov       r11,7FFE5C391070
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L80:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FFE5C391060
       call      qword ptr [r11]
       mov       r13,rax
       jmp       short M00_L82
M00_L81:
       add       r12d,1
       jo        near ptr M00_L62
M00_L82:
       mov       rcx,r13
       mov       r11,7FFE5C391068
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L81
       mov       eax,r12d
       jmp       near ptr M00_L11
M00_L83:
       call      qword ptr [7FFE5C9E42E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L84
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M00_L84:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F328
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L85:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,2803C40B2E0
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2803C40B2E8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L12
; Total bytes of code 4811
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
       jmp       qword ptr [7FFE5C4D4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       je        short M02_L00
       mov       rcx,rax
       mov       r11,7FFE5C390D70
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,[rax+8]
       mov       r11,7FFE5C390D78
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE5C390D68
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE5C390D58
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE5C390D60
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
; Total bytes of code 221
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
       mov       rdx,7FFE5CDF0F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFE5CDF14D8
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
       mov       rdx,7FFE5CDF10F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFE5CDF13A0
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
       mov       rdx,7FFE5CDF13B8
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
       mov       rdx,7FFE5CDF12B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE5C390CB8
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
       mov       rdx,7FFE5CDF12C8
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
       call      qword ptr [7FFE5C6F4F30]
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
       mov       r11,7FFE5C390CC0
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
; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M04_L00
; Total bytes of code 69
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
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,rbx
       mov       rdx,7FFE5CE46618
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L04
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L02
       jmp       short M05_L03
M05_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE46808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L03:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M05_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M05_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M05_L05
       jmp       short M05_L06
M05_L05:
       mov       rcx,rbx
       mov       rdx,7FFE5CE468A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M05_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L07
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       mov       rdx,7FFE5CE47718
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE5C7DE2B0]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M05_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M05_L10
       jmp       short M05_L11
M05_L10:
       mov       rcx,rbx
       mov       rdx,7FFE5CE47660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE5CE65098]
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
; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M06_L00
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFE5CC65B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       mov       r9,2C0CA510008
       call      qword ptr [7FFE5CC74E28]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef, System.String)
       test      eax,eax
       je        short M07_L02
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L02:
       call      qword ptr [7FFE5C9E42E8]
       test      rsi,rsi
       je        short M07_L03
       xor       ecx,ecx
       cmp       dword ptr [rsi+8],0
       sete      cl
       test      ecx,ecx
       jne       short M07_L03
       jmp       short M07_L04
M07_L03:
       mov       rsi,rax
M07_L04:
       test      rsi,rsi
       jne       short M07_L05
       call      qword ptr [7FFE5C9E42B8]
       mov       rsi,rax
M07_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
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
       je        short M08_L00
       test      rdi,rdi
       je        short M08_L01
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,2803C405470
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
M08_L00:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
M08_L01:
       mov       ecx,9
       call      qword ptr [7FFE5C6F4F30]
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
       je        short M09_L05
       test      esi,esi
       jle       short M09_L02
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFE5CE46578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M09_L01:
       mov       rdx,rbx
       mov       r8d,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE5CC74EE8]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M09_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M09_L03
       jmp       short M09_L04
M09_L03:
       mov       rdx,7FFE5CE46528
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M09_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE5C8F67F0]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M09_L05:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
; Total bytes of code 140
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M10_L00
       mov       rax,[rcx+18]
       ret
M10_L00:
       jmp       qword ptr [7FFE5C8C5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M11_L08
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M11_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       je        short M11_L01
       mov       rcx,rax
       mov       r11,7FFE5C390CF8
       call      qword ptr [r11]
M11_L00:
       test      eax,eax
       jle       near ptr M11_L06
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M11_L02
       jmp       short M11_L03
M11_L01:
       mov       rcx,[rax+8]
       mov       r11,7FFE5C390D00
       call      qword ptr [r11]
       jmp       short M11_L00
M11_L02:
       mov       rcx,rsi
       mov       rdx,7FFE5CC649E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M11_L03:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M11_L04
       jmp       short M11_L05
M11_L04:
       mov       rcx,rsi
       mov       rdx,7FFE5CC64A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M11_L05:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE5CC74AC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5C647900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L07:
       call      CORINFO_HELP_OVERFLOW
M11_L08:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,49
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M11_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M11_L10
       mov       rcx,rax
       mov       r11,7FFE5C390CF0
       call      qword ptr [r11]
       jmp       near ptr M11_L00
M11_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFE5C390CE0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M11_L12
M11_L11:
       add       edi,1
       jo        near ptr M11_L07
M11_L12:
       mov       rcx,rbp
       mov       r11,7FFE5C390CE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L11
       mov       eax,edi
       jmp       near ptr M11_L00
; Total bytes of code 492
```
```assembly
; DotNetTips.Spargine.Tester.PersonData..ctor()
       push      rsi
       push      rbx
       mov       rbx,rcx
       lea       rcx,[rbx+8]
       mov       rsi,2C0CA510008
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
       mov       rax,7FFEEE055380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,2803C4001C8
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFEBC3940DC],0
       jne       short M13_L02
M13_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M13_L01
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M13_L01:
       call      qword ptr [7FFE5C765C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M13_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M13_L00
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
       mov       rcx,2803C400350
       mov       rbp,[rcx]
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M14_L02
M14_L00:
       mov       rdx,rsi
       mov       r9,rbp
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CC75518]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rcx,rax
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rsi
       add       r8,rcx
       js        near ptr M14_L08
       mov       rax,2BCA2875F4373FFF
       cmp       r8,rax
       jg        near ptr M14_L08
M14_L01:
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
       jne       near ptr M14_L04
       mov       rdx,0FFFFFF8AA7425000
       cmp       rcx,rdx
       jl        near ptr M14_L05
       mov       rdx,7558BDB000
       cmp       rcx,rdx
       jg        near ptr M14_L05
       cwde
       mov       rdx,2BCA2875F4373FFF
       cmp       r8,rdx
       ja        near ptr M14_L07
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rdx,rcx
       js        near ptr M14_L06
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       jg        near ptr M14_L06
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M14_L07
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
M14_L02:
       mov       rcx,rbp
       call      qword ptr [7FFE5CC75E90]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rcx,rax
       jmp       near ptr M14_L00
M14_L03:
       xor       eax,eax
       mov       rdx,2BCA2875F4373FFF
       test      r8,r8
       cmovge    rax,rdx
       mov       r8,rax
       jmp       near ptr M14_L01
M14_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1E6E8]
       mov       rsi,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M14_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5CA1E6D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M14_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EA90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M14_L07:
       call      qword ptr [7FFE5C764AB0]
       int       3
M14_L08:
       test      dil,dil
       je        near ptr M14_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1C318]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF708]
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
       jo        short M15_L00
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FFE5C9754A0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       nop
       add       rsp,28
       ret
M15_L00:
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
       jg        short M16_L00
       mov       rdx,0F333333333333334
       cmp       rax,rdx
       jl        short M16_L00
       lea       rax,[rax+rax*4]
       add       rax,rax
       mov       [rcx],rax
       add       rsp,28
       ret
M16_L00:
       call      qword ptr [7FFE5C6CEBB0]
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
       call      qword ptr [7FFE5C7DC168]; System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rdi
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        short M17_L00
       mov       rcx,0C000000000000000
       and       rcx,rax
       or        rdx,rcx
       movsx     rcx,word ptr [rbx]
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        short M17_L01
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        short M17_L01
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE5C7DC048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovups   xmm0,[rsp+20]
       vmovups   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M17_L00:
       xor       ecx,ecx
       call      qword ptr [7FFE5C764B10]
       int       3
M17_L01:
       call      qword ptr [7FFE5C6CEBB0]
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
M18_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M18_L00
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
       je        near ptr M18_L36
M18_L01:
       test      eax,eax
       je        near ptr M18_L37
M18_L02:
       mov       rcx,2803C408290
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M18_L05
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       short M18_L05
M18_L03:
       mov       rdi,[rbp-48]
M18_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      rdi,rdi
       je        near ptr M18_L39
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5C76C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       edx,ebx
       call      qword ptr [7FFE5C76C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],rdi
       jmp       short M18_L07
M18_L05:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CC3ECE8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M18_L40
M18_L06:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       short M18_L03
M18_L07:
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M18_L20
M18_L08:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       r15,[rbp-4C]
       mov       [rbp-0A8],r15
M18_L09:
       mov       rdx,r15
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M18_L10]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEEBA43670
       call      rax
M18_L10:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEBC3940DC],0
       je        short M18_L11
       call      qword ptr [7FFEBC3843A8]; CORINFO_HELP_STOP_FOR_GC
M18_L11:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M18_L28
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       r15,[rbp-0A8]
       ja        near ptr M18_L09
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
       ja        near ptr M18_L29
       mov       ecx,r10d
       lea       r15,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M18_L21
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE78C587F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r14d
       jg        near ptr M18_L16
       mov       [rbp-68],eax
       mov       [rbp-70],r15
       movsxd    rcx,eax
       lea       rcx,[r15+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M18_L14
       cmp       eax,64
       jb        short M18_L13
       mov       rdx,2803C400290
       mov       rdx,[rdx]
M18_L12:
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
       jae       short M18_L12
M18_L13:
       cmp       eax,0A
       jb        short M18_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,2803C400290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M18_L15
M18_L14:
       add       eax,30
       mov       [rcx-2],ax
M18_L15:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M18_L17
M18_L16:
       xor       eax,eax
       mov       [rbp-68],eax
M18_L17:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M18_L18:
       test      eax,eax
       je        near ptr M18_L27
       mov       ecx,[rbp-68]
       add       [rdi+18],ecx
M18_L19:
       add       r13d,1
       jo        near ptr M18_L30
       cmp       r13d,ebx
       jl        near ptr M18_L08
M18_L20:
       mov       rdi,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FFE5C75E3F0]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M18_L33
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M18_L24
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M18_L31
       jmp       short M18_L25
M18_L21:
       call      qword ptr [7FFE5C64F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M18_L22
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M18_L23
M18_L22:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M18_L23:
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
       call      qword ptr [7FFE5CDDC078]
       jmp       near ptr M18_L18
M18_L24:
       call      qword ptr [7FFE5CE16388]
       test      eax,eax
       jne       short M18_L31
M18_L25:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M18_L26
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M18_L32
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       short M18_L31
       jmp       short M18_L33
M18_L26:
       call      CORINFO_HELP_RNGCHKFAIL
M18_L27:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFE5C67FC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C76C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M18_L19
M18_L28:
       mov       ecx,eax
       call      qword ptr [7FFE5CC3FBD0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M18_L29:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M18_L30:
       call      CORINFO_HELP_OVERFLOW
M18_L31:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE5C4D73F0]
       mov       rsi,rax
       jmp       short M18_L33
M18_L32:
       call      qword ptr [7FFE5CE16388]
       test      eax,eax
       jne       short M18_L31
M18_L33:
       mov       [rbp-0A0],rsi
       mov       rcx,rsp
       call      M18_L43
       jmp       short M18_L35
M18_L34:
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
M18_L35:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M18_L34
M18_L36:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M18_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE5C5847B0]
       mov       ebx,eax
       jmp       near ptr M18_L02
M18_L37:
       call      qword ptr [7FFE5C9E44B0]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M18_L38
       call      qword ptr [7FFE5C9E42D0]
       mov       rsi,rax
M18_L38:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,2C0CA5186E0
       mov       r8,rsi
       call      qword ptr [7FFE5C58D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M18_L39:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,9B8
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE5C9529E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M18_L40:
       cmp       qword ptr [r15+10],0
       jne       short M18_L41
       xor       edx,edx
       mov       [rbp-48],rdx
       jmp       short M18_L42
M18_L41:
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFE5CC3E808]
       test      eax,eax
       jne       near ptr M18_L06
M18_L42:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M18_L04
M18_L43:
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
       mov       rcx,2803C408290
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M18_L44
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        near ptr M18_L48
       xor       edx,edx
       call      qword ptr [7FFE5C76C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M18_L45
M18_L44:
       mov       rdx,[rbp-98]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M18_L48
M18_L45:
       cmp       qword ptr [rsi+20],0
       jne       short M18_L46
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M18_L48
M18_L46:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M18_L47
       mov       r14,[rsi+18]
       mov       rcx,[r14+10]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CC3ED18]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M18_L48
       mov       rcx,r14
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE5CC3E7D8]
       jmp       short M18_L48
M18_L47:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M18_L48:
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
; Total bytes of code 1672
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       rcx,2803C405430
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE5C7E6FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M19_L14
       lea       rdi,[rax+10]
       mov       ebp,[rax+8]
M19_L00:
       mov       [rsp+48],rdi
       mov       [rsp+50],ebp
       xor       r8d,r8d
       mov       [rsp+40],r8d
       mov       byte ptr [rsp+44],0
       test      rbx,rbx
       je        near ptr M19_L16
       cmp       dword ptr [rbx+8],0
       je        near ptr M19_L16
       cmp       byte ptr [rsp+44],0
       jne       near ptr M19_L17
M19_L01:
       test      rbx,rbx
       je        near ptr M19_L17
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M19_L17
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+40]
       add       r8d,[rbx+8]
       mov       [rsp+40],r8d
M19_L02:
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M19_L18
       mov       r8,2C0CA510C54
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+40]
       inc       r8d
       mov       [rsp+40],r8d
M19_L03:
       test      rsi,rsi
       je        near ptr M19_L19
       cmp       dword ptr [rsi+8],0
       je        near ptr M19_L19
       cmp       byte ptr [rsp+44],0
       jne       near ptr M19_L20
M19_L04:
       test      rsi,rsi
       je        near ptr M19_L20
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M19_L20
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M19_L05:
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+50]
       ja        near ptr M19_L27
       mov       rdx,[rsp+48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,ecx
       cmp       eax,1
       jb        near ptr M19_L21
       mov       rcx,2C0CA51FBAC
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M19_L06:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       r14d,5
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,0F
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M19_L15
M19_L07:
       test      eax,eax
       je        near ptr M19_L22
M19_L08:
       mov       edx,r14d
       add       edx,1
       jo        near ptr M19_L13
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,r14d
       call      qword ptr [7FFE5C9754A0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE5C934FF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M19_L24
       test      r15,r15
       je        near ptr M19_L24
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M19_L24
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+40]
       add       edx,[r15+8]
       mov       [rsp+40],edx
M19_L09:
       mov       edx,[rsp+40]
       cmp       edx,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M19_L25
       mov       rdx,2C0CA510C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rsp+40]
       inc       edx
       mov       [rsp+40],edx
M19_L10:
       mov       rdx,2803C408268
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M19_L26
       mov       r13,[rcx+18]
M19_L11:
       mov       edx,[r13+8]
       sub       edx,1
       jo        near ptr M19_L13
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE5C9754A0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r13+8]
       jae       near ptr M19_L29
       mov       r8d,eax
       mov       r12,[r13+r8*8+10]
       cmp       byte ptr [rsp+44],0
       jne       near ptr M19_L28
       test      r12,r12
       je        near ptr M19_L28
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M19_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M19_L28
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[r12+8]
       mov       [rsp+40],ecx
M19_L12:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE5C645740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M19_L13:
       call      CORINFO_HELP_OVERFLOW
M19_L14:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M19_L00
M19_L15:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M19_L07
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M19_L08
M19_L16:
       mov       rbx,2C0CA51FB50
       cmp       byte ptr [rsp+44],0
       je        near ptr M19_L01
M19_L17:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE5C645848]
       jmp       near ptr M19_L02
M19_L18:
       lea       rcx,[rsp+30]
       mov       rdx,2C0CA510C48
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M19_L03
M19_L19:
       mov       rsi,2C0CA51FB78
       cmp       byte ptr [rsp+44],0
       je        near ptr M19_L04
M19_L20:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE5C645848]
       jmp       near ptr M19_L05
M19_L21:
       lea       rcx,[rsp+30]
       mov       rdx,2C0CA51FBA0
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M19_L06
M19_L22:
       call      qword ptr [7FFE5C9E44B0]
       mov       r15,rax
       test      r15,r15
       jne       short M19_L23
       call      qword ptr [7FFE5C9E42D0]
       mov       r15,rax
M19_L23:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,2C0CA51FC10
       mov       r8,r15
       call      qword ptr [7FFE5C58D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M19_L24:
       lea       rcx,[rsp+30]
       mov       rdx,r15
       call      qword ptr [7FFE5C645848]
       jmp       near ptr M19_L09
M19_L25:
       lea       rcx,[rsp+30]
       mov       rdx,2C0CA510C48
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M19_L10
M19_L26:
       call      qword ptr [7FFE5C8C5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M19_L11
M19_L27:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M19_L28:
       lea       rcx,[rsp+30]
       mov       rdx,r12
       call      qword ptr [7FFE5C645848]
       jmp       near ptr M19_L12
M19_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1293
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
       je        short M20_L00
       jmp       short M20_L01
M20_L00:
       mov       rdx,7FFE5CC6AD10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M20_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       sub       rsp,1D8
       vzeroupper
       lea       rbp,[rsp+210]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rbx,0FFFFFFFFFFFFFFA0
M21_L00:
       vmovdqa   xmmword ptr [rbp+rbx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rbx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rbx-20],xmm4
       add       rbx,30
       jne       short M21_L00
       mov       [rbp-40],rcx
       mov       r14,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       edi,r9d
       mov       r15d,[rbp+30]
       lea       rcx,[rbp-1E0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r13,rax
       mov       rcx,rsp
       mov       [rbp-1C0],rcx
       mov       rcx,rbp
       mov       [rbp-1B0],rcx
       test      rbx,rbx
       je        near ptr M21_L81
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
       je        near ptr M21_L82
M21_L01:
       test      eax,eax
       je        near ptr M21_L83
M21_L02:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       edx,edx
       cmp       edi,64
       setle     dl
       cmp       edi,5
       cmovge    ecx,edx
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M21_L85
M21_L03:
       test      r8d,r8d
       je        near ptr M21_L86
M21_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       edx,edx
       cmp       r15d,32
       setle     dl
       cmp       r15d,5
       cmovge    ecx,edx
       mov       r10d,ecx
       test      ecx,ecx
       je        near ptr M21_L88
M21_L05:
       test      r10d,r10d
       je        near ptr M21_L89
M21_L06:
       mov       rcx,[r14+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M21_L12
M21_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,esi
       call      qword ptr [7FFE5C58DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       [rbp-0B8],r12
       xor       eax,eax
       mov       [rbp-4C],eax
       test      esi,esi
       jle       short M21_L11
M21_L08:
       mov       [rbp+18],rbx
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M21_L91
       test      r8,r8
       je        short M21_L10
M21_L09:
       mov       r10,r8
       mov       [rbp-110],r10
       mov       rdx,r10
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M21_L94
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M21_L14
       mov       rcx,[rax+8]
       mov       r11,7FFE5C390F70
       call      qword ptr [r11]
       jmp       near ptr M21_L15
M21_L10:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       jmp       near ptr M21_L92
M21_L11:
       mov       rbx,[rbp-0B8]
       jmp       near ptr M21_L66
M21_L12:
       mov       rcx,r14
       mov       rdx,7FFE5CC6B488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M21_L07
M21_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       test      rax,rax
       je        near ptr M21_L141
       jmp       short M21_L16
M21_L14:
       mov       rcx,rax
       mov       r11,7FFE5C390F68
       call      qword ptr [r11]
M21_L15:
       test      eax,eax
       jle       near ptr M21_L22
       mov       rdx,[rbp-110]
       mov       r8,rdx
       mov       [rbp-120],r8
       mov       rcx,r8
       call      qword ptr [7FFE5CC3FD80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       edx,edx
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M21_L137
       mov       rdx,2803C40B2E8
       mov       rax,[rdx]
       mov       r8,[rbp-120]
       mov       [rbp-128],r8
       mov       [rbp-130],rax
       test      rax,rax
       je        near ptr M21_L98
       jmp       near ptr M21_L13
M21_L16:
       xor       ecx,ecx
       mov       r8,[rbp-140]
       mov       [r8+10],rcx
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2803C405470
       mov       rdx,[rcx]
       mov       rax,[rbp-140]
       lea       rcx,[rax+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       mov       byte ptr [rax+28],0
       mov       [rbp-148],rax
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-150],rdx
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-148]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       rdx,[rbp-150]
       mov       [rdx+10],r8d
       mov       [rdx+14],r8d
       lea       r8,[rbp-68]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r10,rax
M21_L17:
       mov       r9,r10
M21_L18:
       mov       r11,r9
       mov       [rbp-0C0],r11
       test      r11,r11
       je        short M21_L21
       mov       rdx,[r11+8]
       test      rdx,rdx
       je        near ptr M21_L99
M21_L19:
       test      rdx,rdx
       je        short M21_L20
       mov       [rbp-160],rdx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M21_L100
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       short M21_L24
       mov       rcx,[rax+8]
       mov       r11,7FFE5C390FA0
       call      qword ptr [r11]
       jmp       short M21_L25
M21_L20:
       mov       r11,[rbp-0C0]
M21_L21:
       xor       ecx,ecx
       mov       r10,rcx
       jmp       near ptr M21_L28
M21_L22:
       xor       r10d,r10d
       jmp       short M21_L17
M21_L23:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-190],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-180]
       test      rax,rax
       je        near ptr M21_L141
       jmp       short M21_L26
M21_L24:
       mov       rcx,rax
       mov       r11,7FFE5C390F98
       call      qword ptr [r11]
M21_L25:
       test      eax,eax
       jle       near ptr M21_L79
       mov       rdx,[rbp-160]
       mov       r8,rdx
       mov       [rbp-170],r8
       mov       rcx,r8
       call      qword ptr [7FFE5CC3FD80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M21_L139
       mov       rcx,2803C40B2F8
       mov       rax,[rcx]
       mov       r8,[rbp-170]
       mov       [rbp-178],r8
       mov       [rbp-180],rax
       test      rax,rax
       je        near ptr M21_L104
       jmp       near ptr M21_L23
M21_L26:
       xor       ecx,ecx
       mov       r8,[rbp-190]
       mov       [r8+10],rcx
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2803C405470
       mov       rdx,[rcx]
       mov       rax,[rbp-190]
       lea       rcx,[rax+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-190]
       mov       byte ptr [rax+28],0
       mov       [rbp-198],rax
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-1A0],rdx
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       rdx,[rbp-1A0]
       mov       [rdx+10],r8d
       mov       [rdx+14],r8d
       lea       r8,[rbp-78]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FFE5C7DE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,rax
M21_L27:
       mov       r10,rcx
M21_L28:
       mov       [rbp-0C8],r10
       mov       rcx,[r14+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M21_L70
M21_L29:
       call      qword ptr [7FFE5C71C978]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-58],rax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-88],xmm0
       lea       rcx,[rbp-98]
       mov       rax,offset MD_Interop+Ole32.<CoCreateGuid>g____PInvoke|1_0(System.Guid*)
       mov       [rbp-1D0],rax
       lea       rax,[M21_L30]
       mov       [rbp-1B8],rax
       lea       rax,[rbp-1E0]
       mov       [r13+10],rax
       mov       byte ptr [r13+0C],0
       mov       rax,7FFEEC33EF80
       call      rax
M21_L30:
       mov       byte ptr [r13+0C],1
       cmp       dword ptr [7FFEBC3940DC],0
       je        short M21_L31
       call      qword ptr [7FFEBC3843A8]; CORINFO_HELP_STOP_FOR_GC
M21_L31:
       mov       r8,[rbp-1D8]
       mov       [r13+10],r8
       mov       ebx,eax
       test      ebx,ebx
       jne       near ptr M21_L142
       vmovups   xmm0,[rbp-98]
       vmovups   [rbp-88],xmm0
       mov       r8,2803C400428
       mov       r8,[r8]
       lea       rcx,[rbp-88]
       mov       rdx,2C0CA523C48
       call      qword ptr [7FFE5C587180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       mov       r12,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [r12],rcx
       jne       near ptr M21_L112
       mov       rax,[r12+30]
       cmp       rax,rbx
       je        short M21_L35
       test      rax,rax
       jne       near ptr M21_L78
M21_L32:
       mov       r8d,1
       mov       ecx,32
       cmp       r8d,32
       jg        near ptr M21_L109
       mov       edx,1
M21_L33:
       test      edx,edx
       je        near ptr M21_L143
       test      rbx,rbx
       je        near ptr M21_L111
       mov       edx,[rbx+8]
       cmp       edx,r8d
       jl        near ptr M21_L110
       xor       r10d,r10d
       cmp       edx,ecx
       setle     r10b
M21_L34:
       test      r10d,r10d
       je        near ptr M21_L145
       mov       rdx,rbx
       lea       rcx,[r12+30]
       call      CORINFO_HELP_ASSIGN_REF
M21_L35:
       mov       ecx,5
       call      qword ptr [7FFE5C934DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r12,rax
       mov       ecx,edi
       sub       ecx,5
       jo        near ptr M21_L80
       sub       ecx,1
       jo        near ptr M21_L80
       test      ecx,ecx
       jle       near ptr M21_L113
       xor       eax,eax
       cmp       ecx,7FFFFFFF
       setle     al
M21_L36:
       mov       edx,eax
       test      eax,eax
       je        near ptr M21_L107
       test      edx,edx
       je        near ptr M21_L146
M21_L37:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE5C934FF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r8,rax
       mov       rcx,r12
       mov       rdx,2C0CA517D38
       call      qword ptr [7FFE5C4D6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       mov       r12,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [r12],rcx
       jne       near ptr M21_L116
       mov       rax,[r12+8]
       cmp       rax,rbx
       je        short M21_L40
       test      rax,rax
       jne       near ptr M21_L77
M21_L38:
       mov       ecx,64
       mov       eax,1
       test      eax,eax
       je        near ptr M21_L148
       test      rbx,rbx
       je        near ptr M21_L115
       mov       edx,[rbx+8]
       xor       r8d,r8d
       cmp       edx,ecx
       setle     r8b
M21_L39:
       test      r8d,r8d
       je        near ptr M21_L150
       mov       rdx,rbx
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
M21_L40:
       mov       ecx,edi
       sub       ecx,5
       jo        near ptr M21_L80
       sub       ecx,1
       jo        near ptr M21_L80
       test      ecx,ecx
       jle       near ptr M21_L117
       xor       r12d,r12d
       cmp       ecx,7FFFFFFF
       setle     r12b
M21_L41:
       mov       edx,r12d
       test      r12d,r12d
       je        near ptr M21_L106
       test      edx,edx
       je        near ptr M21_L151
M21_L42:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE5C934FF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFE5C934DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2C0CA517D38
       call      qword ptr [7FFE5C4D6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r12,rax
       mov       rcx,[rbp-58]
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rbx],rcx
       jne       near ptr M21_L120
       mov       rax,[rbx+10]
       cmp       rax,r12
       je        short M21_L45
       test      rax,rax
       jne       near ptr M21_L76
M21_L43:
       mov       ecx,64
       mov       eax,1
       test      eax,eax
       je        near ptr M21_L153
       test      r12,r12
       je        near ptr M21_L119
       mov       edx,[r12+8]
       xor       r8d,r8d
       cmp       edx,ecx
       setle     r8b
M21_L44:
       test      r8d,r8d
       je        near ptr M21_L155
       mov       rdx,r12
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M21_L45:
       lea       rcx,[rbp-58]
       mov       rbx,[rbp-0C8]
       test      rbx,rbx
       je        near ptr M21_L69
       mov       r12,[rbx+18]
M21_L46:
       mov       rcx,[rcx]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rdx
       jne       near ptr M21_L123
       mov       [rbp-0E0],rcx
       mov       rax,[rcx+18]
       cmp       rax,r12
       je        short M21_L49
       test      rax,rax
       jne       near ptr M21_L75
M21_L47:
       mov       edx,96
       mov       eax,1
       test      eax,eax
       je        near ptr M21_L156
       test      r12,r12
       je        near ptr M21_L122
       mov       eax,[r12+8]
       cmp       eax,edx
       setle     al
       movzx     eax,al
M21_L48:
       test      eax,eax
       je        near ptr M21_L158
       mov       rdx,r12
       lea       rcx,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
M21_L49:
       mov       r12,[rbp+18]
       mov       rax,[r12+68]
       mov       rdx,rax
       mov       [rbp-0D0],rdx
       mov       rcx,[rbp-58]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M21_L128
       mov       [rbp-0E8],rcx
       mov       rax,[rcx+20]
       cmp       rax,rdx
       je        near ptr M21_L55
       test      rax,rax
       jne       near ptr M21_L74
M21_L50:
       xor       eax,eax
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
       mov       [rbp-9C],eax
       xor       r8d,r8d
       mov       [rbp-0A8],r8
       mov       r8d,32
       cmp       eax,32
       jg        near ptr M21_L125
       mov       r10d,1
M21_L51:
       mov       r9d,r10d
       test      r10d,r10d
       je        near ptr M21_L105
M21_L52:
       test      r9d,r9d
       je        near ptr M21_L159
M21_L53:
       test      rdx,rdx
       je        near ptr M21_L127
       mov       r10d,[rdx+8]
       cmp       r10d,eax
       jl        near ptr M21_L126
       cmp       r10d,r8d
       setle     r8b
       movzx     r8d,r8b
M21_L54:
       test      r8d,r8d
       je        near ptr M21_L161
       lea       rcx,[rcx+20]
       call      CORINFO_HELP_ASSIGN_REF
M21_L55:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
       mov       byte ptr [rbp-0B0],1
       mov       dword ptr [rbp-0AC],1
       mov       ecx,r15d
       test      ecx,ecx
       jle       near ptr M21_L129
       xor       eax,eax
       cmp       r15d,7FFFFFFF
       setle     al
M21_L56:
       mov       r10d,eax
       test      eax,eax
       je        near ptr M21_L130
M21_L57:
       test      r10d,r10d
       je        near ptr M21_L162
M21_L58:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE5C934FF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       [rbp-0D8],rdx
       mov       rcx,[rbp-58]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M21_L132
       mov       [rbp-0F0],rcx
       mov       rax,[rcx+28]
       cmp       rax,rdx
       je        short M21_L61
       test      rax,rax
       jne       near ptr M21_L73
M21_L59:
       test      rdx,rdx
       je        short M21_L60
       cmp       dword ptr [rdx+8],32
       jg        near ptr M21_L164
M21_L60:
       lea       rcx,[rcx+28]
       call      CORINFO_HELP_ASSIGN_REF
M21_L61:
       mov       ecx,[r12+0B8]
       mov       rax,[rbp-58]
       mov       [rbp-0F8],rax
       call      qword ptr [7FFE5C934DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       mov       r8,[rbp-0F8]
       cmp       [r8],rcx
       jne       near ptr M21_L133
       mov       rcx,r8
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92F848]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Phone(System.String)
       mov       rax,[rbp-58]
       mov       [rbp-100],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [7FFE5C934BA0]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.Core.Data.Models.City)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       mov       rbx,[rbp-100]
       cmp       [rbx],rcx
       jne       near ptr M21_L134
       mov       rcx,rbx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92F858]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_PostalCode(System.String)
M21_L62:
       lea       rcx,[rbp-58]
       mov       rbx,[rbp-0C0]
       test      rbx,rbx
       je        near ptr M21_L71
       mov       rdx,[rbx+20]
M21_L63:
       mov       rcx,[rcx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],rax
       jne       near ptr M21_L135
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92F868]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_State(System.String)
M21_L64:
       mov       r8,[rbp-58]
       mov       rbx,[rbp-0B8]
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M21_L136
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M21_L65:
       mov       eax,[rbp-4C]
       add       eax,1
       jo        near ptr M21_L80
       cmp       eax,esi
       mov       [rbp-4C],eax
       jl        short M21_L68
M21_L66:
       mov       rcx,[r14+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M21_L72
M21_L67:
       mov       rdx,rbx
       call      qword ptr [7FFE5CC774F8]; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       nop
       add       rsp,1D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M21_L68:
       mov       rbx,r12
       jmp       near ptr M21_L08
M21_L69:
       mov       r12,2C0CA510008
       jmp       near ptr M21_L46
M21_L70:
       mov       rcx,r14
       mov       rdx,7FFE5CC6B4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M21_L29
M21_L71:
       mov       rdx,2C0CA510008
       jmp       near ptr M21_L63
M21_L72:
       mov       rcx,r14
       mov       rdx,7FFE5CC6BD80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M21_L67
M21_L73:
       test      rdx,rdx
       je        near ptr M21_L59
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       je        near ptr M21_L131
       jmp       near ptr M21_L59
M21_L74:
       test      rdx,rdx
       je        near ptr M21_L50
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       je        near ptr M21_L124
       jmp       near ptr M21_L50
M21_L75:
       test      r12,r12
       je        near ptr M21_L47
       mov       edx,[rax+8]
       cmp       edx,[r12+8]
       je        near ptr M21_L121
       jmp       near ptr M21_L47
M21_L76:
       test      r12,r12
       je        near ptr M21_L43
       mov       ecx,[rax+8]
       cmp       ecx,[r12+8]
       je        near ptr M21_L118
       jmp       near ptr M21_L43
M21_L77:
       test      rbx,rbx
       je        near ptr M21_L38
       mov       ecx,[rax+8]
       cmp       ecx,[rbx+8]
       je        near ptr M21_L114
       jmp       near ptr M21_L38
M21_L78:
       test      rbx,rbx
       je        near ptr M21_L32
       mov       ecx,[rax+8]
       cmp       ecx,[rbx+8]
       je        near ptr M21_L108
       jmp       near ptr M21_L32
M21_L79:
       xor       ecx,ecx
       jmp       near ptr M21_L27
M21_L80:
       call      CORINFO_HELP_OVERFLOW
M21_L81:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,15
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,189
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r13
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M21_L82:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M21_L01
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE5C5847B0]
       mov       esi,eax
       jmp       near ptr M21_L02
M21_L83:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L84
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L84:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2C0CA514368
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M21_L85:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M21_L03
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE5C5847B0]
       mov       edi,eax
       jmp       near ptr M21_L04
M21_L86:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L87
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L87:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F450
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L88:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M21_L05
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE5C5847B0]
       mov       r15d,eax
       jmp       near ptr M21_L06
M21_L89:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L90
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L90:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2C0CA51F480
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M21_L91:
       mov       r12,[rbp-0B8]
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-108],r8
       mov       rcx,r8
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rbp+18]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-108]
       test      r8,r8
       jne       short M21_L93
M21_L92:
       xor       r9d,r9d
       mov       [rbp+18],rbx
       jmp       near ptr M21_L18
M21_L93:
       mov       [rbp+18],rbx
       jmp       near ptr M21_L09
M21_L94:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       mov       rdx,[rbp-110]
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M21_L95
       mov       rcx,rax
       mov       r11,7FFE5C390F60
       call      qword ptr [r11]
       mov       [rbp+18],rbx
       jmp       near ptr M21_L15
M21_L95:
       xor       eax,eax
       mov       [rbp-5C],eax
       mov       rcx,[rbp-110]
       mov       r11,7FFE5C390F50
       call      qword ptr [r11]
       mov       [rbp-118],rax
       jmp       short M21_L97
M21_L96:
       mov       eax,[rbp-5C]
       add       eax,1
       jo        near ptr M21_L80
       mov       [rbp-5C],eax
       mov       rax,[rbp-118]
M21_L97:
       mov       rcx,rax
       mov       r11,7FFE5C390F58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M21_L96
       mov       eax,[rbp-5C]
       mov       [rbp+18],rbx
       jmp       near ptr M21_L15
M21_L98:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-138],rax
       mov       rcx,2803C40B2E0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       mov       rax,[rbp-138]
       mov       [rax+18],rcx
       mov       rcx,2803C40B2E8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-138]
       mov       rcx,rax
       mov       [rbp+18],rbx
       mov       [rbp-130],rcx
       jmp       near ptr M21_L13
M21_L99:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-158],rdx
       mov       rcx,rdx
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rax,[rbp-0C0]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-158]
       mov       [rbp+18],rbx
       jmp       near ptr M21_L19
M21_L100:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       mov       rdx,[rbp-160]
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M21_L101
       mov       rcx,rax
       mov       r11,7FFE5C390F90
       call      qword ptr [r11]
       mov       [rbp+18],rbx
       jmp       near ptr M21_L25
M21_L101:
       xor       eax,eax
       mov       [rbp-6C],eax
       mov       rcx,[rbp-160]
       mov       r11,7FFE5C390F80
       call      qword ptr [r11]
       mov       [rbp-168],rax
       jmp       short M21_L103
M21_L102:
       mov       eax,[rbp-6C]
       add       eax,1
       jo        near ptr M21_L80
       mov       [rbp-6C],eax
       mov       rax,[rbp-168]
M21_L103:
       mov       rcx,rax
       mov       r11,7FFE5C390F88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M21_L102
       mov       eax,[rbp-6C]
       mov       [rbp+18],rbx
       jmp       near ptr M21_L25
M21_L104:
       mov       rbx,[rbp+18]
       mov       r12,[rbp-0B8]
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-188],rax
       mov       rcx,2803C40B2F0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       mov       rax,[rbp-188]
       mov       [rax+18],rcx
       mov       rcx,2803C40B2F8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-188]
       mov       r8,rax
       mov       [rbp+18],rbx
       mov       [rbp-180],r8
       jmp       near ptr M21_L23
M21_L105:
       movzx     r10d,byte ptr [rbp-0A8]
       test      r10b,r10b
       je        near ptr M21_L52
       lea       rcx,[rbp-0A8]
       call      qword ptr [7FFE5C5847B0]
       mov       r8d,eax
       mov       eax,[rbp-9C]
       mov       rcx,[rbp-0E8]
       mov       rdx,[rbp-0D0]
       jmp       near ptr M21_L53
M21_L106:
       mov       ecx,1
       jmp       near ptr M21_L42
M21_L107:
       mov       ecx,1
       jmp       near ptr M21_L37
M21_L108:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [rbx],bl
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L35
       jmp       near ptr M21_L32
M21_L109:
       xor       edx,edx
       jmp       near ptr M21_L33
M21_L110:
       xor       r10d,r10d
       jmp       near ptr M21_L34
M21_L111:
       xor       r10d,r10d
       jmp       near ptr M21_L34
M21_L112:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r11,7FFE5C390F08
       call      qword ptr [r11]
       jmp       near ptr M21_L35
M21_L113:
       xor       eax,eax
       jmp       near ptr M21_L36
M21_L114:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [rbx],bl
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L40
       jmp       near ptr M21_L38
M21_L115:
       xor       r8d,r8d
       jmp       near ptr M21_L39
M21_L116:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r11,7FFE5C390F10
       call      qword ptr [r11]
       jmp       near ptr M21_L40
M21_L117:
       xor       r12d,r12d
       jmp       near ptr M21_L41
M21_L118:
       cmp       [rax],al
       lea       rcx,[rax+0C]
       cmp       [r12],r12b
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[r12+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L45
       jmp       near ptr M21_L43
M21_L119:
       xor       r8d,r8d
       jmp       near ptr M21_L44
M21_L120:
       mov       rcx,rbx
       mov       rdx,r12
       mov       r11,7FFE5C390F18
       call      qword ptr [r11]
       jmp       near ptr M21_L45
M21_L121:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [r12],r12b
       mov       r8d,[rax+8]
       add       r8d,r8d
       lea       rdx,[r12+0C]
       mov       rcx,r10
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L49
       mov       rcx,[rbp-0E0]
       jmp       near ptr M21_L47
M21_L122:
       xor       eax,eax
       jmp       near ptr M21_L48
M21_L123:
       mov       rdx,r12
       mov       r11,7FFE5C390F20
       call      qword ptr [r11]
       jmp       near ptr M21_L49
M21_L124:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [rdx],dl
       mov       r8d,[rax+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L55
       mov       rcx,[rbp-0E8]
       mov       rdx,[rbp-0D0]
       jmp       near ptr M21_L50
M21_L125:
       xor       r10d,r10d
       jmp       near ptr M21_L51
M21_L126:
       xor       r8d,r8d
       jmp       near ptr M21_L54
M21_L127:
       xor       r8d,r8d
       jmp       near ptr M21_L54
M21_L128:
       mov       r11,7FFE5C390F28
       call      qword ptr [r11]
       jmp       near ptr M21_L55
M21_L129:
       xor       eax,eax
       jmp       near ptr M21_L56
M21_L130:
       movzx     eax,byte ptr [rbp-0B0]
       test      al,al
       je        near ptr M21_L57
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M21_L58
M21_L131:
       cmp       [rax],al
       lea       r10,[rax+0C]
       cmp       [rdx],dl
       mov       r8d,[rax+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M21_L61
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0D8]
       jmp       near ptr M21_L59
M21_L132:
       mov       r11,7FFE5C390F30
       call      qword ptr [r11]
       jmp       near ptr M21_L61
M21_L133:
       mov       rcx,r8
       mov       rdx,rax
       mov       r11,7FFE5C390F38
       call      qword ptr [r11]
       mov       rcx,[rbp-58]
       mov       [rbp-100],rcx
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [7FFE5C934BA0]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.Core.Data.Models.City)
       mov       rbx,[rbp-100]
M21_L134:
       mov       rcx,rbx
       mov       rdx,rax
       mov       r11,7FFE5C390F40
       call      qword ptr [r11]
       jmp       near ptr M21_L62
M21_L135:
       mov       r11,7FFE5C390F48
       call      qword ptr [r11]
       jmp       near ptr M21_L64
M21_L136:
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FFE5C58E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M21_L65
M21_L137:
       call      qword ptr [7FFE5C9E42E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L138
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M21_L138:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51F328
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L139:
       call      qword ptr [7FFE5C9E42E8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M21_L140
       call      qword ptr [7FFE5C9E42B8]
       mov       rdi,rax
M21_L140:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2C0CA51F328
       mov       r8,rdi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M21_L141:
       mov       ecx,9
       call      qword ptr [7FFE5C6F4F30]
       int       3
M21_L142:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4DCC30]
       mov       [r15+74],ebx
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M21_L143:
       call      qword ptr [7FFE5C9E44B0]
       mov       r13,rax
       test      r13,r13
       jne       short M21_L144
       call      qword ptr [7FFE5C9E42D0]
       mov       r13,rax
M21_L144:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2C0CA51FC10
       mov       r8,r13
       call      qword ptr [7FFE5C58D470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M21_L145:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A19
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9751A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L146:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L147
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L147:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA5186E0
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L148:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L149
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L149:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51FC10
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L150:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9BD
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9750E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L151:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L152
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L152:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA5186E0
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L153:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L154
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L154:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51FC10
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L155:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9CF
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9750E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L156:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L157
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L157:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51FC10
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L158:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9E1
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9750F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L159:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L160
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L160:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA51FC10
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L161:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9EB
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975110]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M21_L162:
       call      qword ptr [7FFE5C9E44B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L163
       call      qword ptr [7FFE5C9E42D0]
       mov       rbx,rax
M21_L163:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C0CA5186E0
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M21_L164:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9FB
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975128]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 6158
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
       je        near ptr M22_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M22_L16
M22_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5CB77408]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CB99670]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       test      rax,rax
       je        near ptr M22_L09
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       near ptr M22_L09
       jmp       short M22_L03
M22_L01:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+18]
       test      r11,r11
       je        short M22_L06
M22_L02:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5CB99650]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-40]
M22_L03:
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M22_L05
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M22_L05
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       short M22_L04
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M22_L01
M22_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M22_L05:
       mov       rcx,r14
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE5C71E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       test      eax,eax
       jne       short M22_L01
       jmp       near ptr M22_L14
M22_L06:
       mov       rcx,rsi
       mov       rdx,7FFE5CC6D088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M22_L02
M22_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+18]
       test      r11,r11
       je        short M22_L11
M22_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5CB99650]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-40]
M22_L09:
       mov       rbx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       short M22_L13
       lea       r14,[rax+8]
       mov       r15,[r14]
       mov       ecx,[r14+14]
       cmp       ecx,[r15+14]
       jne       short M22_L12
       mov       r8d,[r14+10]
       cmp       r8d,[r15+10]
       jae       short M22_L12
       lea       rcx,[r14+8]
       mov       r13,[r15+8]
       cmp       r8d,[r13+8]
       jae       near ptr M22_L04
       mov       edx,r8d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
       jmp       short M22_L07
M22_L10:
       test      eax,eax
       jne       short M22_L07
       jmp       short M22_L14
M22_L11:
       mov       rcx,rsi
       mov       rdx,7FFE5CC6D088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M22_L08
M22_L12:
       mov       rcx,r14
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE5C71E688]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
       jmp       short M22_L10
M22_L13:
       mov       rcx,rax
       mov       r11,7FFE5C390FB0
       call      qword ptr [r11]
       jmp       short M22_L10
M22_L14:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,rcx
       jne       short M22_L18
M22_L15:
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
M22_L16:
       mov       rcx,rdx
       mov       rdx,7FFE5CC6AD10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M22_L00
M22_L17:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M22_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFE5C390FB8
       call      qword ptr [r11]
       jmp       short M22_L15
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
       je        short M22_L19
       mov       rcx,[rbp-40]
       mov       rbx,[rcx]
       mov       r11,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       rbx,r11
       je        short M22_L19
       mov       r11,7FFE5C390FB8
       call      qword ptr [r11]
M22_L19:
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
       je        near ptr M23_L14
       mov       rcx,0C000000000000000
       and       rcx,rbp
       je        short M23_L00
       mov       rax,4000000000000000
       cmp       rcx,rax
       je        short M23_L03
M23_L00:
       mov       rcx,2803C400350
       mov       r14,[rcx]
       mov       rcx,[r14+8]
       test      rcx,rcx
       je        short M23_L02
M23_L01:
       mov       rdx,rbp
       mov       r9,r14
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CC75518]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rcx,rax
       jmp       short M23_L04
M23_L02:
       mov       rcx,r14
       call      qword ptr [7FFE5CC75E90]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rcx,rax
       jmp       short M23_L01
M23_L03:
       xor       ecx,ecx
M23_L04:
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
       jne       near ptr M23_L07
       mov       rax,0FFFFFF8AA7425000
       cmp       r8,rax
       jl        near ptr M23_L08
       mov       rax,7558BDB000
       cmp       r8,rax
       jg        near ptr M23_L08
       mov       r14,3FFFFFFFFFFFFFFF
       and       rbp,r14
       sub       rbp,rcx
       js        near ptr M23_L09
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       jg        near ptr M23_L09
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       ja        near ptr M23_L10
       lea       rcx,[rsp+28]
       mov       rax,7FFEEE055380
       call      rax
       mov       rbx,[rsp+28]
       mov       rcx,2803C4001C8
       mov       r14,[rcx]
       sub       rbx,[r14+8]
       cmp       dword ptr [7FFEBC3940DC],0
       jne       near ptr M23_L11
       mov       ecx,0B2D05E00
       cmp       rbx,rcx
       jae       near ptr M23_L12
M23_L05:
       add       rbx,[r14+10]
M23_L06:
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
       jg        near ptr M23_L13
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
M23_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5CA1E6E8]
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M23_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FFE5CA1E6D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M23_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EA90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M23_L10:
       call      qword ptr [7FFE5C764AB0]
       int       3
M23_L11:
       call      CORINFO_HELP_POLL_GC
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jb        near ptr M23_L05
M23_L12:
       call      qword ptr [7FFE5C765C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M23_L06
M23_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A6B
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975218]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M23_L14:
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
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M24_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M24_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
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
       mov       ecx,0A79
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975230]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M24_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M24_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M24_L02
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
       je        near ptr M25_L06
       test      rdi,rdi
       jne       short M25_L05
M25_L00:
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
       je        near ptr M25_L12
M25_L01:
       test      eax,eax
       je        short M25_L07
M25_L02:
       test      rbx,rbx
       je        near ptr M25_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M25_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M25_L03:
       test      r14d,r14d
       je        near ptr M25_L11
M25_L04:
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
M25_L05:
       test      rbx,rbx
       je        short M25_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M25_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M25_L00
M25_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M25_L07:
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M25_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M25_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M25_L09:
       xor       r14d,r14d
       jmp       near ptr M25_L03
M25_L10:
       xor       r14d,r14d
       jne       near ptr M25_L04
M25_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A8D
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975158]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M25_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M25_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M25_L02
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
       je        near ptr M26_L06
       test      rdi,rdi
       jne       short M26_L05
M26_L00:
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
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M26_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M26_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
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
       mov       ecx,0A99
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M26_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M26_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M26_L02
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C587360]; System.Guid.NewGuid()
       mov       r8,2803C400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,2C0CA523C48
       call      qword ptr [7FFE5C587180]; System.Guid.ToString(System.String, System.IFormatProvider)
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
       je        near ptr M28_L06
       test      rdi,rdi
       jne       short M28_L05
M28_L00:
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
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M28_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M28_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
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
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9751A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M28_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M28_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M28_L02
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
       je        near ptr M29_L06
       test      rdi,rdi
       jne       short M29_L05
M29_L00:
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
       je        near ptr M29_L12
M29_L01:
       test      eax,eax
       je        short M29_L07
M29_L02:
       test      rbx,rbx
       je        near ptr M29_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M29_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M29_L03:
       test      r14d,r14d
       je        near ptr M29_L11
M29_L04:
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
M29_L05:
       test      rbx,rbx
       je        short M29_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M29_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M29_L00
M29_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M29_L07:
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M29_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M29_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M29_L09:
       xor       r14d,r14d
       jmp       near ptr M29_L03
M29_L10:
       xor       r14d,r14d
       jne       near ptr M29_L04
M29_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0AAD
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C9751B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M29_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M29_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M29_L02
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
       je        near ptr M30_L06
       test      rdi,rdi
       jne       short M30_L05
M30_L00:
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
       je        near ptr M30_L12
M30_L01:
       test      eax,eax
       je        short M30_L07
M30_L02:
       test      rbx,rbx
       je        near ptr M30_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M30_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M30_L03:
       test      r14d,r14d
       je        near ptr M30_L11
M30_L04:
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
M30_L05:
       test      rbx,rbx
       je        short M30_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M30_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE5C585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M30_L00
M30_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M30_L07:
       call      qword ptr [7FFE5C9E44B0]
       mov       r14,rax
       test      r14,r14
       jne       short M30_L08
       call      qword ptr [7FFE5C9E42D0]
       mov       r14,rax
M30_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C0CA51FC10
       mov       r8,r14
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M30_L09:
       xor       r14d,r14d
       jmp       near ptr M30_L03
M30_L10:
       xor       r14d,r14d
       jne       near ptr M30_L04
M30_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A1F
       mov       rdx,7FFE5C7EA7D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5C975230]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M30_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M30_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5847B0]
       mov       ecx,eax
       jmp       near ptr M30_L02
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
       jl        near ptr M31_L10
       test      edx,edx
       jg        near ptr M31_L11
M31_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       test      rdx,rdx
       jne       short M31_L03
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M31_L01
       jmp       short M31_L02
M31_L01:
       mov       rdx,7FFE5CDF7C28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M31_L02:
       mov       rcx,rdx
       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M31_L03:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       jne       near ptr M31_L09
       mov       rdx,[rbx+18]
       mov       rax,2803C401D60
       cmp       rdx,[rax]
       jne       short M31_L04
       mov       rdx,2803C401960
       mov       rsi,[rdx]
       jmp       short M31_L06
M31_L04:
       mov       rax,2803C4002D8
       cmp       rdx,[rax]
       jne       short M31_L05
       mov       rdx,2803C401968
       mov       rsi,[rdx]
       jmp       short M31_L06
M31_L05:
       mov       rax,2803C4002E0
       xor       esi,esi
       mov       r8,2803C401970
       cmp       rdx,[rax]
       cmove     rsi,[r8]
M31_L06:
       test      rsi,rsi
       je        short M31_L09
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M31_L07
       jmp       short M31_L08
M31_L07:
       mov       rdx,7FFE5CDF7C18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M31_L08:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M31_L09:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M31_L10:
       mov       ecx,16
       call      qword ptr [7FFE5C6CED30]
       int       3
M31_L11:
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DEE80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M31_L00
; Total bytes of code 335
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
       je        near ptr M32_L09
       test      rdi,rdi
       je        near ptr M32_L10
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M32_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M32_L00
       jmp       short M32_L01
M32_L00:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFF190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M32_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M32_L02
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M32_L02
       jmp       short M32_L03
M32_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFF3C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L03:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M32_L12
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M32_L04
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M32_L04
       jmp       short M32_L05
M32_L04:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFF4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L05:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M32_L18
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M32_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M32_L06
       jmp       short M32_L07
M32_L06:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFF990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L07:
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
M32_L08:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M32_L09:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
M32_L10:
       mov       ecx,0C
       call      qword ptr [7FFE5C6F4F30]
       int       3
M32_L11:
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
M32_L12:
       cmp       dword ptr [rbp+8],0
       je        short M32_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],70
       jle       short M32_L13
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M32_L13
       jmp       short M32_L14
M32_L13:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFFBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rdi
       call      qword ptr [7FFE5C8CC720]
       mov       rax,rbx
       jmp       near ptr M32_L08
M32_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M32_L16
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M32_L16
       jmp       short M32_L17
M32_L16:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFFB18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE5C8F67F0]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M32_L18:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M32_L19
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M32_L19
       jmp       short M32_L20
M32_L19:
       mov       rcx,rbx
       mov       rdx,7FFE5CDFFAD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M32_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE5C8CC498]
       mov       rax,rbx
       jmp       near ptr M32_L08
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
       je        near ptr M33_L03
       test      rdi,rdi
       je        near ptr M33_L04
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M33_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M33_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M33_L00
       jmp       short M33_L01
M33_L00:
       mov       rdx,7FFE5CE403D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M33_L01:
       mov       rcx,rdx
       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M33_L02:
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
M33_L03:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
M33_L04:
       mov       ecx,9
       call      qword ptr [7FFE5C6F4F30]
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
       je        short M34_L04
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M34_L00
       jmp       short M34_L01
M34_L00:
       mov       rcx,rbx
       mov       rdx,7FFE5CE40498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M34_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M34_L05
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M34_L02
       jmp       short M34_L03
M34_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE405F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M34_L03:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M34_L04:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
M34_L05:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M34_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M34_L06
       jmp       short M34_L07
M34_L06:
       mov       rcx,rbx
       mov       rdx,7FFE5CE40880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M34_L07:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE5CE1DED8]
; Total bytes of code 196
```
```assembly
; System.Reflection.RuntimePropertyInfo.GetValue(System.Object, System.Object[])
       push      rbx
       sub       rsp,30
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M35_L01
       test      rcx,rcx
       je        short M35_L02
M35_L00:
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE5C70DEB8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       nop
       add       rsp,30
       pop       rbx
       ret
M35_L01:
       xor       ecx,ecx
       test      rcx,rcx
       jne       short M35_L00
M35_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 106
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
       je        near ptr M37_L06
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M37_L00
       jmp       short M37_L01
M37_L00:
       mov       rcx,rdi
       mov       rdx,7FFE5CD5C5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M37_L01:
       mov       rdx,rsi
       mov       r8,2C0CA510008
       mov       r9,2C0CA5243F8
       call      qword ptr [7FFE5CD7EA00]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M37_L02
       jmp       short M37_L03
M37_L02:
       mov       rcx,rdi
       mov       rdx,7FFE5CD5C658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M37_L03:
       vmovdqu   xmm0,xmmword ptr [rbx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rdx,rsi
       lea       r8,[rsp+28]
       call      qword ptr [7FFE5CD7EA48]; System.Linq.Enumerable.Contains[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       test      eax,eax
       jne       near ptr M37_L07
       mov       rcx,[rdi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M37_L04
       jmp       short M37_L05
M37_L04:
       mov       rcx,rdi
       mov       rdx,7FFE5CD5C678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M37_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M37_L06:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,136C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M37_L07:
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
       je        short M38_L04
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M38_L02
M38_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE5CDD4270]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M38_L03
M38_L01:
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
M38_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CDB8600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M38_L00
M38_L03:
       mov       rcx,rbx
       mov       rdx,7FFE5CDB86D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M38_L01
M38_L04:
       call      qword ptr [7FFE5C9E44C8]
       mov       ecx,1472
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
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
       je        short M40_L01
M40_L00:
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M40_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+28],xmm0
       mov       rdx,[rbx+48]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C7351B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+28]
       vmovups   [rsp+38],xmm0
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5C735230]; System.MdUtf8String.ToString()
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M40_L00
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
       je        near ptr M41_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M41_L02
       test      rbx,rbx
       je        short M41_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M41_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M41_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M41_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M41_L01:
       call      qword ptr [7FFE5C6CEF40]
       int       3
M41_L02:
       test      rbx,rbx
       je        short M41_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M41_L04
M41_L03:
       mov       rax,2C0CA510008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M41_L04:
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__38`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__38_0(System.__Canon)
       xor       ecx,ecx
       mov       edx,7FFFFFFF
       jmp       qword ptr [7FFE5C9754A0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
; Total bytes of code 13
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M43_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M43_L00:
       call      qword ptr [7FFE5C4D41F8]
       int       3
; Total bytes of code 44
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
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
M44_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M44_L01
       je        short M44_L01
       je        short M44_L01
       je        short M44_L01
       je        short M44_L01
       je        short M44_L01
       je        short M44_L01
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
       jne       short M44_L03
       jne       short M44_L03
       jne       short M44_L03
       jne       short M44_L03
       jne       short M44_L03
       jne       short M44_L03
       jne       short M44_L03
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
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
M44_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M44_L02
       jne       short M44_L02
       jne       short M44_L02
       jne       short M44_L02
       jne       short M44_L02
       jne       short M44_L02
       jne       short M44_L02
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
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
M44_L02:
       mov       rcx,rbx
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
       lea       rax,[7FFE796C3CC8]
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
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
M44_L03:
       cmp       edi,8
       ja        short M44_L04
       ja        short M44_L04
       ja        short M44_L04
       ja        short M44_L04
       ja        short M44_L04
       ja        short M44_L04
       ja        short M44_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       lea       rdx,[7FFE795443D8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
       lea       rax,[M44_L00]
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
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       call      qword ptr [7FFE796C3C90]
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
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
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       call      qword ptr [7FFE796C3C98]
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
       jmp       short M44_L01
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
       je        short M44_L05
       je        short M44_L05
       je        short M44_L05
       je        short M44_L05
       je        short M44_L05
       je        short M44_L05
       je        short M44_L05
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
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
M44_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
       call      qword ptr [7FFE796BB0E8]
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
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       call      qword ptr [7FFE796C3C88]
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       call      qword ptr [7FFE796A6918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
       call      qword ptr [7FFE796C95D0]
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
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       call      qword ptr [7FFE796C3CA0]
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
M44_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       call      qword ptr [7FFE796C3CB0]
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
       jmp       near ptr M44_L01
; Total bytes of code 1841
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
       mov       rcx,2CB879B4380
       call      qword ptr [7FFE5CDAE148]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DisplayNameOptions)
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
       mov       rcx,28AF9C08B38
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
       call      qword ptr [7FFE5C79C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE5CDADFE0]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DisplayNameOptions ByRef)
       mov       rcx,[rbp-40]
       mov       rdx,2CB879B43B4
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
       call      qword ptr [7FFE5CDAE1A8]
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
       call      qword ptr [7FFE5C79CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE5C79C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFE5C79CA50]
       jmp       near ptr M01_L28
M01_L19:
       cmp       byte ptr [rsi],0
       je        short M01_L21
       mov       rcx,rbx
       cmp       r15,r13
       jne       short M01_L17
       mov       edx,2
       call      qword ptr [7FFE5C456DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
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
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE5C79CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L27:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M01_L18
M01_L28:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C78E3F0]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE5CA144C8]
       mov       ecx,14A0
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA142B8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CC6EB98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,28AF9C08B38
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
       call      qword ptr [7FFE5C79C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE5CC6EB68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,1E65E4053C8
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
       mov       rdx,226EC3FC8C8
       call      qword ptr [7FFE5CD6DCB0]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32 ByRef, DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FFE5C74E3F0]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L40
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L41
       test      rsi,rsi
       je        near ptr M01_L42
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       r14,[rbx]
       mov       r15,offset MT_System.RuntimeType
       cmp       r14,r15
       jne       near ptr M01_L45
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L14
M01_L01:
       cmp       qword ptr [r13+10],0
       je        near ptr M01_L43
M01_L02:
       mov       rcx,226EC3F1E80
       cmp       [r13+10],rcx
       jne       near ptr M01_L44
       xor       r12d,r12d
M01_L03:
       test      r12,r12
       jne       near ptr M01_L46
M01_L04:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L25
       cmp       r14,r15
       jne       near ptr M01_L49
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L15
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L15
M01_L05:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L47
M01_L06:
       mov       rcx,226EC3F1E80
       cmp       [r12+10],rcx
       jne       near ptr M01_L48
       xor       eax,eax
M01_L07:
       test      rax,rax
       jne       near ptr M01_L50
       cmp       r14,r15
       jne       near ptr M01_L52
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C70CFC0]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L51
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L51
M01_L09:
       test      rax,rax
       je        near ptr M01_L25
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L25
       mov       r12,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L55
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L23
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L23
M01_L10:
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C70CFC0]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L54
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L54
M01_L11:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L22
       lea       rdx,[rax+0C]
       mov       r13d,[rax+8]
       test      r13d,r13d
       je        near ptr M01_L22
       mov       r8,[r12+8]
       mov       eax,[r12+18]
       mov       [rsp+3C],eax
       lea       ecx,[rax+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L21
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L13
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       add       r13d,[rsp+3C]
       mov       [r12+18],r13d
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE5C416658]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rbx
       call      qword ptr [7FFE5C416658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       r8d,[rax+8]
       sub       r8d,r13d
       js        near ptr M01_L59
       lea       rdx,[rax+0C]
       mov       r8,[r12+8]
       mov       ebx,[r12+18]
       lea       ecx,[rbx+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L34
       cmp       [r8],r8b
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L19
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L17:
       add       r13d,ebx
       mov       [r12+18],r13d
M01_L18:
       cmp       byte ptr [rbp+2],0
       je        near ptr M01_L30
       jmp       near ptr M01_L31
M01_L19:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M01_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L17
M01_L20:
       mov       rcx,rbx
       call      qword ptr [7FFE5C416658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L21:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FFE5C75CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L22:
       mov       rcx,[rsp+90]
       mov       r12d,[rcx+18]
       mov       r13,[rcx+8]
       cmp       [r13+8],r12d
       jbe       short M01_L24
       jmp       near ptr M01_L28
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFE5C416658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L24:
       mov       edx,2E
       call      qword ptr [7FFE5C75C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L25:
       cmp       r14,r15
       jne       near ptr M01_L56
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5C416DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L26:
       lea       rcx,[rax+0C]
       mov       r8d,[rax+8]
       mov       edx,60
       call      qword ptr [7FFE5C75CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r13d,eax
       test      r13d,r13d
       jle       near ptr M01_L53
       mov       r12,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L57
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5C416DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L27:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L58
       jmp       near ptr M01_L16
M01_L28:
       mov       eax,r12d
       mov       word ptr [r13+rax*2+10],2E
       inc       dword ptr [rcx+18]
       jmp       short M01_L25
M01_L29:
       mov       edx,3E
       call      qword ptr [7FFE5C75C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L30:
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
M01_L31:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L35
       cmp       edx,[rax+8]
       jae       near ptr M01_L60
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L32:
       mov       ebx,[rsp+40]
       cmp       ebx,[rdi]
       jl        short M01_L36
M01_L33:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L29
       cmp       edx,[rax+8]
       jae       near ptr M01_L60
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
       jmp       short M01_L30
M01_L34:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FFE5C75CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L18
M01_L35:
       mov       edx,3C
       call      qword ptr [7FFE5C75C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L32
M01_L36:
       cmp       ebx,[rsi+8]
       jae       near ptr M01_L60
       mov       edx,ebx
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FFE5CD6DAE8]
       add       ebx,1
       jo        short M01_L39
       cmp       ebx,[rdi]
       je        short M01_L38
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C75C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L37
       cmp       ebx,[rsi+8]
       jae       near ptr M01_L60
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L38
M01_L37:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C75C3D8]; System.Text.StringBuilder.Append(Char)
M01_L38:
       cmp       ebx,[rdi]
       jl        short M01_L36
       jmp       near ptr M01_L33
M01_L39:
       call      CORINFO_HELP_OVERFLOW
M01_L40:
       call      qword ptr [7FFE5C9D44C8]
       mov       ecx,1898
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5C9D42B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L41:
       call      qword ptr [7FFE5C9D44C8]
       mov       ecx,14A0
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5C9D42B8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L42:
       call      qword ptr [7FFE5C9D44C8]
       mov       ecx,18A8
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L43:
       mov       rcx,[r13+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r13
       mov       rax,226EC3F1E80
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L44:
       mov       r12,[r13+10]
       jmp       near ptr M01_L03
M01_L45:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M01_L03
M01_L46:
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
M01_L47:
       mov       rcx,[r12+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,226EC3F1E80
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L48:
       mov       rax,[r12+10]
       jmp       near ptr M01_L07
M01_L49:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L07
M01_L50:
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
       call      qword ptr [7FFE5CD6DCB0]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C75C3D8]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L25
M01_L51:
       xor       eax,eax
       jmp       near ptr M01_L09
M01_L52:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L09
M01_L53:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C75C2A0]; System.Text.StringBuilder.Append(System.String)
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
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L55:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L11
M01_L56:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L26
M01_L57:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L27
M01_L58:
       mov       ecx,2E5
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C6E66E8]
       int       3
M01_L59:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE5CA0EEE0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFE5C57D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2134
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
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE5CA0EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C57D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,226EC3F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

