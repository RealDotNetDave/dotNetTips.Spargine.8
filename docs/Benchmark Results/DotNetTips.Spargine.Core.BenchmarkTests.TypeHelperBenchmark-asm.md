## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rdx,2AA4B5943A8
       mov       [rax+10],rdx
       mov       rdx,2AA4B5943D0
       mov       [rax+18],rdx
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.Create[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Object[])
       call      qword ptr [7FFF7EC4ED48]; DotNetTips.Spargine.Core.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]](System.Object[])
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
       call      qword ptr [7FFF7E2E6DF0]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FFF7E394390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FFF7E8A44C8]
       mov       ecx,17D6
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8A42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E516718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7E8DCE58]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7E39F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 352
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rdx,26D0CC00428
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
       mov       r8,2AD9EC743A8
       call      qword ptr [7FFF7E55D830]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FFF7E5696D0]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFF7E685E00]
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
       call      qword ptr [7FFF7E3943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FFF7E68D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       call      qword ptr [7FFF7E55D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF7E394348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L45
M01_L09:
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFF7E394348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r11,7FFF7E250A00
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
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L22:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L17
M01_L23:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF7E55D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF7E55D2D8]; System.Text.StringBuilder.Append(Char)
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
       mov       r11,7FFF7E250A10
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
       mov       r11,7FFF7E250A08
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
       call      qword ptr [7FFF7E55D158]
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
       mov       r12,2AD9EC60008
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
       call      qword ptr [7FFF7E55D1A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFF7E55D158]
       jmp       near ptr M01_L01
M01_L54:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFF7E55D158]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFF7E55D1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L55:
       mov       r13,[rsp+30]
       mov       [rsp+60],r13
       mov       ebx,[rsp+70]
       mov       [rsp+68],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+60]
       call      qword ptr [7FFF7E55D458]
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
       call      qword ptr [7FFF7E685F98]
       int       3
M01_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFF7E685F98]
       int       3
M01_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFF7E685F98]
       int       3
M01_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFF7E685F98]
       int       3
M01_L60:
       mov       ecx,21
       call      qword ptr [7FFF7E685B48]
       int       3
M01_L61:
       call      qword ptr [7FFF7E685FB0]
       int       3
M01_L62:
       call      qword ptr [7FFF7E6857E8]
       int       3
M01_L63:
       call      qword ptr [7FFF7E685F80]
       int       3
M01_L64:
       mov       ecx,2F1
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7E516790]
       int       3
M01_L65:
       mov       rcx,rdi
       mov       rdx,2AD9EC743D0
       mov       r11,7FFF7E2509F8
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
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF7E8DEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7E44D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2AD9EC60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltinTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF7EC4ED18]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltinTypes()
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
; 			if (_builtinTypes == null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ComputeBuiltinTypes();
; 				^^^^^^^^^^^^^^^^^^^^^^
; 			return _builtinTypes.ToList().AsReadOnly();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,1DC7300AB10
       cmp       qword ptr [rbx],0
       je        short M01_L02
       mov       rsi,[rbx]
       test      rsi,rsi
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FFF7E394348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L04
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFF7E44DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF7EC4EAF0]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltinTypes()
       mov       rsi,[rbx]
       test      rsi,rsi
       jne       short M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FFF7E687A38]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FFF7E250B10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M01_L01
; Total bytes of code 176
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFF7E536130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FFF7E306E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L00
       mov       rdx,rax
       call      qword ptr [7FFF7E3B4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.DoesObjectEqualInstance()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       mov       rdx,[rbx+58]
       call      qword ptr [7FFF7EC7EB98]; DotNetTips.Spargine.Core.TypeHelper.DoesObjectEqualInstance(System.Object, System.Object)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.DoesObjectEqualInstance(System.Object, System.Object)
; 		value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		instance = instance.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return ReferenceEquals(value, instance);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFF7E8D44C8]
       mov       ecx,1790
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8D42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E546718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L01:
       call      qword ptr [7FFF7E8D44C8]
       mov       ecx,17EC
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6DB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8D42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E546718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 328
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,25364000170
       mov       rcx,[rcx]
       mov       rdx,293F5F643A8
       mov       r8d,1
       call      qword ptr [7FFF7EC6F378]; DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.AppDomain, System.Type, Boolean)
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
; 		currentDomain = currentDomain.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		baseType = baseType.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var assemblyCollection = currentDomain.ArgumentNotNull().GetAssemblies().ToImmutableArray();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		List<Type> types = [];
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		foreach (var assembly in assemblyCollection)
; 		                         ^^^^^^^^^^^^^^^^^^
; 				var tempTypes = LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly).ToList();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (tempTypes?.FastCount() > 0)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					if (types is null)
; 					^^^^^^^^^^^^^^^^^^
; 						types = tempTypes;
; 						^^^^^^^^^^^^^^^^^^
; 						types.AddRange(tempTypes);
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return types is not null ? types.AsReadOnly() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			catch (ReflectionTypeLoadException reflectionEx)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				Trace.WriteLine(reflectionEx.GetAllMessages());
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFF7E3B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L12
       mov       r8d,[rbx+8]
       test      r8d,r8d
       jl        near ptr M01_L07
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableExtensions.ToArray[[System.Reflection.Assembly, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.Assembly>, Int32)
       call      qword ptr [7FFF7EC9C840]; System.Collections.Immutable.ImmutableExtensions.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rsi,rax
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,25364001E98
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
       call      qword ptr [7FFF7E5422D8]; System.Reflection.RuntimeAssembly.get_DefinedTypes()
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
       call      qword ptr [7FFF7E46DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FFF7EE666A0]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jle       short M01_L05
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L02
       mov       rcx,[rbp-28]
       mov       rdx,rdi
       call      qword ptr [7FFF7E46E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF7E8C44C8]
       mov       ecx,1810
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7E3B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8C42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E536718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       call      qword ptr [7FFF7E8C44C8]
       mov       ecx,17FE
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6CB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3B6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8C42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E536718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[System.Reflection.Assembly, System.Private.CoreLib]]
       call      qword ptr [7FFF7E3B4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rsi,[rax]
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,40B
       mov       rdx,7FFF7EC72900
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EC97408]
       int       3
M01_L12:
       mov       rcx,rax
       mov       r11,7FFF7E270B40
       call      qword ptr [r11]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L13
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7EC9CAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E555F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.Reflection.Assembly[]
       call      qword ptr [7FFF7E3B4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FFF7EB54738]
       mov       rcx,rax
       call      qword ptr [7FFF7EC96190]
       lea       rax,[M01_L05]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 1015
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,2419D4243A8
       call      qword ptr [7FFF7EC5E880]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, DisplayNameOptions)
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
       mov       rcx,20113402B58
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
       call      qword ptr [7FFF7E56D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       je        near ptr M01_L24
       mov       rcx,rbx
       cmp       r15,r13
       jne       near ptr M01_L14
       call      System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
M01_L06:
       mov       [rbp-50],rax
       lea       rcx,[rbp-40]
       lea       rdx,[rbp-50]
       mov       r8,rsi
       call      qword ptr [7FFF7EC5E718]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DisplayNameOptions ByRef)
       mov       rcx,[rbp-40]
       mov       rdx,2419D4243DC
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
       jmp       near ptr M01_L28
M01_L07:
       mov       r8d,2
       call      qword ptr [7FFF7E56D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L28
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
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
       call      qword ptr [7FFF7EC5E8E0]
       jmp       near ptr M01_L28
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
       mov       rsi,[rbp-40]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E56D1A0]; System.Text.StringBuilder.Append(System.String)
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
       jo        near ptr M01_L08
       mov       edx,[r12+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E56D950]
       jmp       near ptr M01_L28
M01_L19:
       cmp       byte ptr [rsi],0
       je        short M01_L21
       mov       rcx,rbx
       cmp       r15,r13
       jne       short M01_L17
       mov       edx,2
       call      qword ptr [7FFF7E2F6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
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
       call      qword ptr [7FFF7E455B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF7E56D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L27:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M01_L18
M01_L28:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E5796D0]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFF7E8B44C8]
       mov       ecx,1472
       mov       rdx,7FFF7E6BB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6BB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E3A6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6BB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7E3A6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8B42B8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rsi
       call      qword ptr [7FFF7E526718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EB0EEC8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,20113402B58
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
       call      qword ptr [7FFF7E56D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF7EB0EE98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,27F3F801D78
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
       mov       rdx,2BFC957C8C8
       call      qword ptr [7FFF7EC4EE80]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32 ByRef, DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FFF7E5696D0]; System.Text.StringBuilder.ToString()
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
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+90],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rbp,[rsp+0B0]
       mov       rcx,[rsp+90]
       test      rcx,rcx
       je        near ptr M01_L34
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L35
       test      rsi,rsi
       je        near ptr M01_L36
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       r14,[rbx]
       mov       r15,offset MT_System.RuntimeType
       cmp       r14,r15
       jne       near ptr M01_L39
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L14
M01_L01:
       cmp       qword ptr [r13+10],0
       je        near ptr M01_L37
M01_L02:
       mov       rcx,2BFC9571A50
       cmp       [r13+10],rcx
       jne       near ptr M01_L38
       xor       r12d,r12d
M01_L03:
       test      r12,r12
       jne       near ptr M01_L40
M01_L04:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L28
       cmp       r14,r15
       jne       near ptr M01_L43
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L15
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L15
M01_L05:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L41
M01_L06:
       mov       rcx,2BFC9571A50
       cmp       [r12+10],rcx
       jne       near ptr M01_L42
       xor       eax,eax
M01_L07:
       test      rax,rax
       jne       near ptr M01_L44
       cmp       r14,r15
       jne       near ptr M01_L46
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L23
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L23
M01_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E516988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L45
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L45
M01_L09:
       test      rax,rax
       je        near ptr M01_L28
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L28
       mov       r12,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L48
       mov       rcx,rbx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L24
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L10:
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E516988]; System.RuntimeType+RuntimeTypeCache.GetNameSpace()
       test      rax,rax
       je        near ptr M01_L47
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L47
M01_L11:
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L26
       lea       rdx,[rax+0C]
       mov       r13d,[rax+8]
       test      r13d,r13d
       je        near ptr M01_L26
       mov       r8,[r12+8]
       mov       eax,[r12+18]
       mov       [rsp+3C],eax
       lea       ecx,[rax+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L25
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L13
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       add       r13d,[rsp+3C]
       mov       [r12+18],r13d
       jmp       near ptr M01_L26
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
       call      qword ptr [7FFF7E2E6658]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rbx
       call      qword ptr [7FFF7E2E6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       r8d,[rax+8]
       sub       r8d,r13d
       js        near ptr M01_L53
       lea       rdx,[rax+0C]
       mov       r8,[r12+8]
       mov       ebx,[r12+18]
       lea       ecx,[rbx+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L30
       cmp       [r8],r8b
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       near ptr M01_L22
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L17:
       add       r13d,ebx
       mov       [r12+18],r13d
M01_L18:
       cmp       byte ptr [rbp+2],0
       je        short M01_L21
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L31
       cmp       edx,[rax+8]
       jae       near ptr M01_L57
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L19:
       mov       ebx,[rsp+40]
       cmp       ebx,[rdi]
       jl        near ptr M01_L54
M01_L20:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L32
       cmp       edx,[rax+8]
       jae       near ptr M01_L57
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
M01_L21:
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
M01_L22:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M01_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L17
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFF7E2E6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L24:
       mov       rcx,rbx
       call      qword ptr [7FFF7E2E6658]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L25:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FFF7E55D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF7E55D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L28:
       cmp       r14,r15
       jne       near ptr M01_L49
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF7E2E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
M01_L29:
       lea       rcx,[rax+0C]
       mov       r8d,[rax+8]
       mov       edx,60
       call      qword ptr [7FFF7E55DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r13d,eax
       test      r13d,r13d
       jle       near ptr M01_L50
       mov       r12,[rsp+90]
       cmp       r14,r15
       jne       near ptr M01_L51
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF7E2E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L52
       jmp       near ptr M01_L16
M01_L30:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FFF7E55D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L18
M01_L31:
       mov       edx,3C
       call      qword ptr [7FFF7E55D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L19
M01_L32:
       mov       edx,3E
       call      qword ptr [7FFF7E55D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L21
M01_L33:
       call      CORINFO_HELP_OVERFLOW
M01_L34:
       call      qword ptr [7FFF7E8A44C8]
       mov       ecx,186A
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7E8A42B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7E516718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L35:
       call      qword ptr [7FFF7E8A44C8]
       mov       ecx,1472
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7E8A42B8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FFF7E516718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L36:
       call      qword ptr [7FFF7E8A44C8]
       mov       ecx,187A
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFF7E6AB8C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7E396B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7E8A42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7E516718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       mov       rcx,[r13+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r13
       mov       rax,2BFC9571A50
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L38:
       mov       r12,[r13+10]
       jmp       near ptr M01_L03
M01_L39:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M01_L03
M01_L40:
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
M01_L41:
       mov       rcx,[r12+8]
       call      System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,2BFC9571A50
       test      rdx,rdx
       cmove     rdx,rax
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L42:
       mov       rax,[r12+10]
       jmp       near ptr M01_L07
M01_L43:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L07
M01_L44:
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
       call      qword ptr [7FFF7EC4EE80]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E55D2D8]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L28
M01_L45:
       xor       eax,eax
       jmp       near ptr M01_L09
M01_L46:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L09
M01_L47:
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L48:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L11
M01_L49:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L29
M01_L50:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E55D1A0]; System.Text.StringBuilder.Append(System.String)
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
M01_L51:
       mov       rcx,rbx
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       cmp       [r12],r12b
       test      rax,rax
       jne       near ptr M01_L16
M01_L52:
       mov       ecx,2E5
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7E516790]
       int       3
M01_L53:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFF7E8DEEE0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFF7E44D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L54:
       cmp       ebx,[rsi+8]
       jae       short M01_L57
       mov       edx,ebx
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FFF7EC4ECB8]
       add       ebx,1
       jo        near ptr M01_L33
       cmp       ebx,[rdi]
       je        short M01_L56
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E55D2D8]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L55
       cmp       ebx,[rsi+8]
       jae       short M01_L57
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L56
M01_L55:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFF7E55D2D8]; System.Text.StringBuilder.Append(Char)
M01_L56:
       cmp       ebx,[rdi]
       jl        short M01_L54
       jmp       near ptr M01_L20
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2147
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
       call      qword ptr [7FFF7E445B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFF7E244000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF7E8DEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7E44D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2BFC9570008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

